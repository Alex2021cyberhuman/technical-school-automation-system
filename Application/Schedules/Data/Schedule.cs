using DocumentFormat.OpenXml.Vml;

namespace Application.Schedules.Data;

public class Schedule
{
    public long Id { get; set; }

    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public List<ClassSchedule> ClassSchedule { get; set; } = null!;
}

public class ClassScheduleReplacement
{
    public long Id { get; set; }
    
    public long? ClassScheduleId { get; set; }

    public ClassSchedule? ClassSchedule { get; set; }

    public DateTime Date { get; set; }

    public int Number { get; set; }
}