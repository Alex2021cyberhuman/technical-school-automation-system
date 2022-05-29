using System.ComponentModel.DataAnnotations;
using Application.Access.Data;
using Application.Common.Data;
using Application.Schedules.Data;
using Application.Specialities.Data;

namespace Application.Schedules.Forms;

public class EditClassScheduleForm
{
    public EditClassScheduleForm(ClassSchedule classSchedule)
    {
        WeeksSeparation = classSchedule.WeeksSeparation;
        Subject = classSchedule.Subject;
        Teacher = classSchedule.Teacher;
    }
    
    public WeeksSeparationType? WeeksSeparation { get; set; }
    
    [Display(Name = "Предмет")]
    [MyRequired]
    public Subject Subject { get; set; }
    
    public User? Teacher { get; set; }
}