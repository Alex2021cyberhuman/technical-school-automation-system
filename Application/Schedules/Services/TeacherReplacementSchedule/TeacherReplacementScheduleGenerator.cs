using Application.Access.Enums;
using Application.Common.Helpers;
using Application.Data;
using Application.Schedules.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Schedules.Services.TeacherReplacementSchedule;

public class TeacherReplacementScheduleGenerator
{
    private readonly IDbContextFactory<MainDbContext> _factory;
    private readonly IConfiguration _configuration;
    private readonly WeekSeparationService _weekSeparationService;

    public TeacherReplacementScheduleGenerator(
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
        var teacherList = await context.User
            .Where(x => x.UserRoles.Any(role => role.Role.Name == RoleIdentifiers.Teacher))
            .Where(x => !x.LockoutEnd.HasValue || x.LockoutEnd <= moment)
            .OrderBy(x => x.FamilyName)
            .ThenBy(x => x.FirstName)
            .Select(x => new { x.FamilyName, x.FirstName, x.SurName, x.Id })
            .ToListAsync();
        var teachers = teacherList
            .Select(x => (NameExtensions.GetInitials(x.FamilyName, x.FirstName, x.SurName), x.Id))
            .ToList();
        var momentDate = DateOnly.FromDateTime(moment.Value);
        var schedule = await context.ClassScheduleReplacement
            .Where(x => x.Date == momentDate)
            .Where(x => x.TeacherId.HasValue &&
                        teacherList.Select(g => g.Id)
                            .Contains(x.TeacherId.Value) ||
                        x.ClassSchedule != null &&
                        x.ClassSchedule.TeacherId.HasValue &&
                        teacherList.Select(g => g.Id)
                            .Contains(x.ClassSchedule.TeacherId.Value))
            .Select(x => new
            {
                Number = x.Number - 1,
                x.TeacherId, 
                OtherTeacherId = x.ClassSchedule != null ? x.ClassSchedule.TeacherId : null,
                Text = x.IsCancel
                    ? "Отмена"
                    : x.Subject!.Name + (x.Cabinet == null ? string.Empty : " " + x.Cabinet.Code) + " " + x.Schedule.Group.Name
            })
            .ToListAsync();
        var scheduleDict =
            new Dictionary<(int number, long teacherId), TeacherReplacementScheduleModel.ScheduleItem>();
        foreach (var item in schedule)
        {
            var value = new TeacherReplacementScheduleModel.ScheduleItem
            {
                Text = item.Text,
                TeacherId = item.TeacherId
            };
            
            if (item.TeacherId.HasValue)
            {
                scheduleDict[(item.Number, item.TeacherId.Value)] = value;
            }
            if (item.OtherTeacherId.HasValue)
            {
                scheduleDict[(item.Number, item.OtherTeacherId.Value)] = value;
            }
        }

        var model = new TeacherReplacementScheduleModel
        {
            Date = momentDate,
            WeekSeparation = _weekSeparationService.GetCurrentWeekSeparation(moment.Value),
            Teachers = teachers,
            Schedule = scheduleDict
        };
        var printer = new GeneratedTeacherReplacementSchedulePrinter(model);
        var basePath = _configuration["TempFilesPath"];
        var fileName = $"Изменения_В_Расписании_Для_Учителей_{Path.GetRandomFileName()}.xlsx";
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