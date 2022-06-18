namespace Application.Schedules.Services.TeacherSchedule;

public class TeacherScheduleModel
{
    public List<Teacher> Teachers { get; set; } = new();

    public class Teacher
    {
        public string Name { get; set; } = string.Empty;

        public Dictionary<(int Number, int dayOfWeek), (ScheduleItem? numerator, ScheduleItem? divisor,
                ScheduleItem? all)>
            Schedule { get; set; } = null!; // 0 - monday; 0 - first lesson
    }

    public class ScheduleItem
    {
        public string Subject { get; set; } = string.Empty;

        public string Cabinet { get; set; } = string.Empty;
    }
}