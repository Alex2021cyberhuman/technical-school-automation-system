using Application.Data;
using Application.Schedules.Data;
using Application.Schedules.Services.TeacherSchedule;
using Microsoft.EntityFrameworkCore;

namespace Application.Schedules.Services.GroupsSchedule;

public class GroupsScheduleGenerator
{
    private readonly IDbContextFactory<MainDbContext> _factory;
    private readonly IConfiguration _configuration;

    public GroupsScheduleGenerator(IDbContextFactory<MainDbContext> factory, IConfiguration configuration)
    {
        _factory = factory;
        _configuration = configuration;
    }

    public async Task<string> GenerateScheduleAndSaveAsync(DateTime? moment = null)
    {
        moment ??= DateTime.UtcNow.Date;
        await using var context = await _factory.CreateDbContextAsync();
        var groupList = await context.Group
            .Where(x => x.Enrollment <= moment && x.Graduation > moment)
            .OrderByDescending(x => x.EnrollmentYear)
            .ThenBy(x => x.Name)
            .Select(x => new { x.Enrollment, x.Name, x.Id })
            .ToListAsync();
        var groups = groupList
            .Select(x => (GetCourse(x.Enrollment, moment.Value), x.Name, x.Id))
            .ToList();
        var schedule = await context.ClassSchedule
            .Where(x => groupList.Select(g => g.Id)
                .Contains(x.Schedule.GroupId))
            .Select(x => new
            {
                DayOfWeek = (int)x.DayOfWeek - 1,
                Number = x.Number - 1,
                x.Schedule.GroupId,
                Subject = x.Subject.Name,
                Cabinet = x.Cabinet == null ? null : x.Cabinet.Code,
                x.WeeksSeparation
            })
            .ToListAsync();
        var scheduleDict =
            new Dictionary<(int dayOfWeek, int number, long groupId), (GroupsScheduleModel.ScheduleItem? numerator,
                GroupsScheduleModel.ScheduleItem? divisor,
                GroupsScheduleModel.ScheduleItem? all)>();
        foreach (var item in schedule)
        {
            var key = (item.DayOfWeek, item.Number, item.GroupId);
            var value = new GroupsScheduleModel.ScheduleItem
            {
                Subject = item.Subject,
                Cabinet = item.Cabinet
            };

            if (!scheduleDict.ContainsKey(key)) scheduleDict[key] = (null, null, null);

            scheduleDict[key] = item.WeeksSeparation switch
            {
                WeeksSeparationType.Numerator => (value, scheduleDict[key].divisor, null),
                WeeksSeparationType.Divisor => (scheduleDict[key].numerator, value, null),
                WeeksSeparationType.All => (null, null, value),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        var model = new GroupsScheduleModel
        {
            Groups = groups,
            Schedule = scheduleDict
        };
        var printer = new GeneratedGroupsSchedulePrinter(model);
        var basePath = _configuration["TempFilesPath"];
        var fileName = $"Расписание_Для_Студентов_{Path.GetRandomFileName()}.xlsx";
        var fullFileName = Path.Combine(basePath, fileName);
        _ = await printer.CreateAsync(fullFileName);
        return fileName;
    }

    private static int GetCourse(DateTime enrollment, DateTime moment)
    {
        if (moment.Month >= 9) return moment.Year - enrollment.Year + 1;

        return moment.Year - enrollment.Year;
    }
}