using System.ComponentModel.DataAnnotations;
using Application.Specialities.Data;

namespace Application.Schedules.Data;

public class ClassSchedule
{
    public long Id { get; set; }
    
    public long ScheduleId { get; set; }

    public Schedule Schedule { get; set; } = null!;

    public long SubjectId { get; set; }

    public Subject Subject { get; set; } = null!;

    public DayOfWeek DayOfWeek { get; set; }

    [Range(1, 25)]
    public int Number { get; set; }
    
    public WeeksSeparationType WeeksSeparation { get; set; }
}