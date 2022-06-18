using Application.Schedules.Data;

namespace Application.Schedules.Services.ReplacementSchedule;

public class ReplacementScheduleModel
{
    public DateOnly Date { get; set; }

    public WeeksSeparationType WeekSeparation { get; set; }

    public List<(string name, long groupId)> Groups { get; set; } = new();

    public Dictionary<(int number, long groupId), ScheduleItem> Schedule { get; set; } = new();

    public class ScheduleItem
    {
        public string Text { get; set; } = string.Empty;
    }
}