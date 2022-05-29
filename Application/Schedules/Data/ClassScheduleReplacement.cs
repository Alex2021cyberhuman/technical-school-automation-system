using Application.Access.Data;
using Application.Specialities.Data;

namespace Application.Schedules.Data;

public class ClassScheduleReplacement
{
    public long Id { get; set; }

    public long ScheduleId { get; set; }

    public Schedule Schedule { get; set; } = null!;

    public long? ClassScheduleId { get; set; }

    public ClassSchedule? ClassSchedule { get; set; }

    public long? SubjectId { get; set; }

    public Subject? Subject { get; set; }

    public long? CabinetId { get; set; }

    public Cabinet? Cabinet { get; set; }

    public long? TeacherId { get; set; }

    public User? Teacher { get; set; }

    public DateOnly Date { get; set; }

    public int Number { get; set; }

    public bool IsCancel { get; set; }

    public bool IsAddition { get; set; }
}