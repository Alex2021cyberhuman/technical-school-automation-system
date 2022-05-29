using Application.Groups.Data;

namespace Application.Schedules.Data;

public class Schedule
{
    public long Id { get; set; }

    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public List<ClassSchedule> ClassSchedule { get; set; } = null!;
}