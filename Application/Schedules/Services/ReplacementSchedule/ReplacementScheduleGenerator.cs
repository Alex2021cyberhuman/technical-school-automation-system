using Application.Data;
using Application.Schedules.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Schedules.Services.ReplacementSchedule;

public class ReplacementScheduleGenerator
{
    private readonly IDbContextFactory<MainDbContext> _factory;
    private readonly IConfiguration _configuration;
    private readonly WeekSeparationService _weekSeparationService;

    public ReplacementScheduleGenerator(
        IDbContextFactory<MainDbContext> factory,
        IConfiguration configuration,
        WeekSeparationService weekSeparationService)
    {
        _factory = factory;
        _configuration = configuration;
        _weekSeparationService = weekSeparationService;
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
            .Select(x => (x.Name, x.Id))
            .ToList();
        var momentDate = DateOnly.FromDateTime(moment.Value);
        var schedule = await context.ClassScheduleReplacement
            .Where(x => x.Date == momentDate)
            .Where(x => groupList.Select(g => g.Id)
                .Contains(x.Schedule.GroupId))
            .Select(x => new
            {
                Number = x.Number - 1,
                x.Schedule.GroupId,
                Text = x.IsCancel
                    ? "Отмена"
                    : x.Subject!.Name + (x.Cabinet == null ? string.Empty : " " + x.Cabinet.Code)
            })
            .ToListAsync();
        var scheduleDict =
            new Dictionary<(int number, long groupId), ReplacementScheduleModel.ScheduleItem>();
        foreach (var item in schedule)
        {
            var key = (item.Number, item.GroupId);
            var value = new ReplacementScheduleModel.ScheduleItem
            {
                Text = item.Text
            };
            scheduleDict[key] = value;
        }

        var model = new ReplacementScheduleModel
        {
            Date = momentDate,
            WeekSeparation = _weekSeparationService.GetCurrentWeekSeparation(moment.Value),
            Groups = groups,
            Schedule = scheduleDict
        };
        var printer = new GeneratedReplacementSchedulePrinter(model);
        var basePath = _configuration["TempFilesPath"];
        var fileName = $"Изменения_В_Расписании_Для_Студентов_{Path.GetRandomFileName()}.xlsx";
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