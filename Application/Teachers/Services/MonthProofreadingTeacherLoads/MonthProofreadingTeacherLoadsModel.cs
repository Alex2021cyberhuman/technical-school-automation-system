namespace Application.Teachers.Services.MonthProofreadingTeacherLoads;

public class MonthProofreadingTeacherLoadsModel
{
    public string Month { get; set; } = string.Empty;

    public int Year { get; set; }

    public List<ItemModel> Items { get; set; } = new();

    public int DaysInMonthCount { get; set; }

    public string TeacherFullName { get; set; } = string.Empty;

    public class ItemModel
    {
        public string SubjectName { get; set; } = string.Empty;

        public string GroupName { get; set; } = string.Empty;

        public string FinanceEnrollmentType { get; set; } = string.Empty;

        public IEnumerable<ItemDayModel> Days { get; set; } = Enumerable.Empty<ItemDayModel>();

        public int TotalHours { get; set; }
    }

    public class ItemDayModel
    {
        public int Hours { get; set; }
    }
}