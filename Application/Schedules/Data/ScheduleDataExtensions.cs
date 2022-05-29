using Application.Access.Data;
using Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Application.Schedules.Data;

public static class ScheduleDataExtensions
{
    public static async Task<(bool Valid, string Message)> ValidateTeacherAvailabilityAsync(this MainDbContext context,
        IStringLocalizer stringLocalizer,
        TeacherAvailabilityFilter filter,
        User? teacher)
    {
        if (teacher is not null)
        {
            var element = await context.ClassSchedule
                .Where(x => x.Id != filter.ClassScheduleId)
                .Where(x => x.Number == filter.Number)
                .Where(x => x.DayOfWeek == filter.DayOfWeek)
                .Where(x => x.WeeksSeparation == WeeksSeparationType.All ||
                            x.WeeksSeparation == filter.WeekSeparation)
                .Where(x => x.TeacherId == teacher.Id)
                .Include(x => x.Schedule)
                .ThenInclude(x => x.Group)
                .Include(x => x.Subject)
                .SingleOrDefaultAsync();
            if (filter.ReplacementMode)
            {
                if (element is not null)
                {
                    var replacementElement = await context.ClassScheduleReplacement
                        .Where(x => x.Id != filter.ClassScheduleReplacementId)
                        .Where(x => x.Number == filter.Number)
                        .Where(x => x.Date == filter.Date)
                        .Where(x => x.ClassScheduleId == element.Id)
                        .Where(x => x.TeacherId != teacher.Id)
                        .SingleOrDefaultAsync();
                    if (replacementElement is null)
                        return (false,
                            $"Учитель {teacher.FullName} занят в {stringLocalizer[filter.DayOfWeek.ToString()]} на уроках №{filter.Number} дисциплина {element.Subject.Name} группа {element.Schedule.Group.Name}.");
                }
                else
                {
                    var replacementElement = await context.ClassScheduleReplacement
                        .Where(x => x.Id != filter.ClassScheduleReplacementId)
                        .Where(x => x.Number == filter.Number)
                        .Where(x => x.Date == filter.Date)
                        .Where(x => x.TeacherId == teacher.Id)
                        .Include(x => x.Schedule)
                        .ThenInclude(x => x.Group)
                        .Include(x => x.Subject)
                        .SingleOrDefaultAsync();
                    if (replacementElement is not null)
                        return (false,
                            $"Учитель {teacher.FullName} будет занят {filter.Date.ToShortDateString()} на уроке №{filter.Number} дисциплина {replacementElement.Subject.Name} группа {replacementElement.Schedule.Group.Name}.");
                }
            }
            else if (element is not null)
            {
                return (false,
                    $"Учитель {teacher.FullName} занят в {stringLocalizer[filter.DayOfWeek.ToString()]} на уроках №{filter.Number} дисциплина {element.Subject.Name} группа {element.Schedule.Group.Name}.");
            }
        }

        return (true, string.Empty);
    }

    public static async Task<(bool Valid, string Message)> ValidateCabinetAvailabilityAsync(this MainDbContext context,
        IStringLocalizer stringLocalizer,
        TeacherAvailabilityFilter filter,
        Cabinet? cabinet)
    {
        if (cabinet is not null)
        {
            var element = await context.ClassSchedule
                .Where(x => x.Id != filter.ClassScheduleId)
                .Where(x => x.Number == filter.Number)
                .Where(x => x.DayOfWeek == filter.DayOfWeek)
                .Where(x => x.WeeksSeparation == WeeksSeparationType.All ||
                            x.WeeksSeparation == filter.WeekSeparation)
                .Where(x => x.CabinetId == cabinet.Id)
                .Include(x => x.Schedule)
                .ThenInclude(x => x.Group)
                .Include(x => x.Subject)
                .SingleOrDefaultAsync();
            if (filter.ReplacementMode)
            {
                if (element is not null)
                {
                    var replacementElement = await context.ClassScheduleReplacement
                        .Where(x => x.Id != filter.ClassScheduleReplacementId)
                        .Where(x => x.Number == filter.Number)
                        .Where(x => x.Date == filter.Date)
                        .Where(x => x.ClassScheduleId == element.Id)
                        .Where(x => x.CabinetId != cabinet.Id)
                        .SingleOrDefaultAsync();
                    if (replacementElement is null)
                        return (false,
                            $"Кабинет {cabinet.Code} занят в {stringLocalizer[filter.DayOfWeek.ToString()]} на уроках №{filter.Number} дисциплина {element.Subject.Name} группа {element.Schedule.Group.Name}.");
                }
                else
                {
                    var replacementElement = await context.ClassScheduleReplacement
                        .Where(x => x.Id != filter.ClassScheduleReplacementId)
                        .Where(x => x.Number == filter.Number)
                        .Where(x => x.Date == filter.Date)
                        .Where(x => x.CabinetId == cabinet.Id)
                        .Include(x => x.Schedule)
                        .ThenInclude(x => x.Group)
                        .Include(x => x.Subject)
                        .SingleOrDefaultAsync();
                    if (replacementElement is not null)
                        return (false,
                            $"Кабинет {cabinet.Code} будет занят {filter.Date.ToShortDateString()} на уроке №{filter.Number} дисциплина {replacementElement.Subject.Name} группа {replacementElement.Schedule.Group.Name}.");
                }
            }
            else if (element is not null)
            {
                return (false,
                    $"Кабинет {cabinet.Code} занят в {stringLocalizer[filter.DayOfWeek.ToString()]} на уроках №{filter.Number} дисциплина {element.Subject.Name} группа {element.Schedule.Group.Name}.");
            }
        }

        return (true, string.Empty);
    }
}