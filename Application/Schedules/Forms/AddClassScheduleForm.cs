using System.ComponentModel.DataAnnotations;
using Application.Common.Data;
using Application.Schedules.Data;
using Application.Specialities.Data;

namespace Application.Schedules.Forms;

public class AddClassScheduleForm
{
    public WeeksSeparationType WeeksSeparation { get; set; }
    
    [Display(Name = "Предмет")]
    [MyRequired]
    public Subject? Subject { get; set; }

    public ClassSchedule ToClassSchedule(
        DayOfWeek dayOfWeek,
        int number,
        long scheduleId)
    {
        var classSchedule = new ClassSchedule()
        {
            WeeksSeparation = WeeksSeparation,
            DayOfWeek = dayOfWeek,
            Number = number,
            ScheduleId = scheduleId,
            SubjectId = Subject!.Id
        };
        return classSchedule;
    }
}