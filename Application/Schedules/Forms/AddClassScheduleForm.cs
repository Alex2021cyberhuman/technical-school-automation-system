using System.ComponentModel.DataAnnotations;
using Application.Access.Data;
using Application.Common.Data;
using Application.Schedules.Data;
using Application.Specialities.Data;

namespace Application.Schedules.Forms;

public class AddClassScheduleForm
{
    public WeeksSeparationType? WeeksSeparation { get; set; }

    [Display(Name = "Дисциплина")]
    [MyRequired]
    public Subject? Subject { get; set; }

    public User? Teacher { get; set; }

    public Cabinet? Cabinet { get; set; }

    public ClassSchedule ToClassSchedule(
        DayOfWeek dayOfWeek,
        int number,
        long scheduleId)
    {
        var classSchedule = new ClassSchedule()
        {
            WeeksSeparation = WeeksSeparation!.Value,
            DayOfWeek = dayOfWeek,
            Number = number,
            ScheduleId = scheduleId,
            SubjectId = Subject!.Id,
            TeacherId = Teacher?.Id,
            CabinetId = Cabinet?.Id
        };
        return classSchedule;
    }
}