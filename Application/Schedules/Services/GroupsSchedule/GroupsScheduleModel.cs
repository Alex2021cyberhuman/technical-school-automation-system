namespace Application.Schedules.Services.GroupsSchedule;

public class GroupsScheduleModel
{
    public List<(int course, string name, long groupId)> Groups { get; set; } = new();

    public Dictionary<(int dayOfWeek, int number, long groupId), (ScheduleItem? numerator, ScheduleItem? divisor,
        ScheduleItem? all)> Schedule { get; set; } = new();

    public class ScheduleItem
    {
        public string Subject { get; set; } = string.Empty;

        public string? Cabinet { get; set; }
    }
}