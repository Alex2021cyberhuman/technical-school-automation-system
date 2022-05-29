namespace Application.Schedules.Data;

public class TeacherAvailabilityFilter
{
    public int Number { get; set; }

    public bool ReplacementMode { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public DateOnly Date { get; set; }

    public long? ClassScheduleId { get; set; }

    public long? ClassScheduleReplacementId { get; set; }

    public WeeksSeparationType WeekSeparation { get; set; }
}