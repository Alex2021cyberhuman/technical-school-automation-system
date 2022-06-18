using Application.Schedules.Data;

namespace Application.Schedules.Services.TeacherReplacementSchedule;

public class TeacherReplacementScheduleModel
{
    public DateOnly Date { get; set; }

    public WeeksSeparationType WeekSeparation { get; set; }

    public List<(string name, long teacherId)> Teachers { get; set; } = new();

    public Dictionary<(int number, long teacherId), ScheduleItem> Schedule { get; set; } = new();

    public class ScheduleItem
    {
        public string Text { get; set; } = string.Empty;
        
        public long? TeacherId { get; set; }
    }
}