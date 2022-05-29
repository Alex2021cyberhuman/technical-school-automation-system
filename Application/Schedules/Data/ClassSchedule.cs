using System.ComponentModel.DataAnnotations;
using Application.Access.Data;
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

    public long? CabinetId { get; set; }

    public Cabinet? Cabinet { get; set; }

    public long? TeacherId { get; set; }

    public User? Teacher { get; set; }

    [Range(1, 25)] public int Number { get; set; }

    public WeeksSeparationType WeeksSeparation { get; set; }
}