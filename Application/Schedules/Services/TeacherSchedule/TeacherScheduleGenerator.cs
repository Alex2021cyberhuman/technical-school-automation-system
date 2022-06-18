using Application.Data;
using Application.Schedules.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Schedules.Services.TeacherSchedule;

public class TeacherScheduleGenerator
{
    private readonly IDbContextFactory<MainDbContext> _factory;
    private readonly IConfiguration _configuration;

    public TeacherScheduleGenerator(IDbContextFactory<MainDbContext> factory, IConfiguration configuration)
    {
        _factory = factory;
        _configuration = configuration;
    }

    public async Task<string> GenerateScheduleAndSaveAsync(DateTime? moment = null)
    {
        moment ??= DateTime.UtcNow.Date;
        var model = new TeacherScheduleModel();
        await using var context = await _factory.CreateDbContextAsync();
        var classSchedules = await context
            .ClassSchedule
            .Where(x => x.Schedule.Group.Graduation > moment && x.Schedule.Group.Enrollment <= moment)
            .Where(x => x.TeacherId.HasValue)
            .Select(x => new
            {
                x.Teacher,
                Subject = x.Subject.Name,
                Cabinet = x.Cabinet == null ? string.Empty : x.Cabinet.Code,
                Number = x.Number - 1,
                DayOfWeek = (int)x.DayOfWeek - 1,
                WeekSeparation = x.WeeksSeparation
            })
            .ToListAsync();
        var elements = classSchedules
            .GroupBy(x => x.Teacher!.Id);
        foreach (var grouping in elements)
        {
            var teacher = grouping.First().Teacher!;
            var schedule =
                new Dictionary<(int Number, int dayOfWeek), (TeacherScheduleModel.ScheduleItem? numerator,
                    TeacherScheduleModel.ScheduleItem? divisor,
                    TeacherScheduleModel.ScheduleItem? all)>();
            foreach (var item in grouping)
            {
                var key = (item.Number, item.DayOfWeek);
                if (!schedule.ContainsKey(key)) schedule[key] = (null, null, null);
                var scheduleItem = new TeacherScheduleModel.ScheduleItem()
                {
                    Cabinet = item.Cabinet,
                    Subject = item.Subject
                };
                schedule[key] = item.WeekSeparation switch
                {
                    WeeksSeparationType.Numerator => (scheduleItem, schedule[key].divisor, null),
                    WeeksSeparationType.Divisor => (schedule[key].numerator, scheduleItem, null),
                    WeeksSeparationType.All => (null, null, scheduleItem),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            model.Teachers.Add(new TeacherScheduleModel.Teacher
            {
                Name = teacher.Initials,
                Schedule = schedule
            });
        }

        var printer = new GeneratedTeacherSchedulePrinter(model);
        var basePath = _configuration["TempFilesPath"];
        var fileName = $"Расписание_Для_Преподавателей_{Path.GetRandomFileName()}.xlsx";
        var fullFileName = Path.Combine(basePath, fileName);
        _ = await printer.CreateAsync(fullFileName);
        return fileName;
    }
}