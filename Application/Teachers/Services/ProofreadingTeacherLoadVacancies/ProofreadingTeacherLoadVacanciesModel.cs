namespace Application.Teachers.Services.ProofreadingTeacherLoadVacancies;

public class ProofreadingTeacherLoadVacanciesModel
{
    public string Month { get; set; } = string.Empty;

    public int Year { get; set; }

    public List<ItemModel> Items { get; set; } = new();

    public class ItemModel
    {
        public string TeacherFamilyName { get; set; } = string.Empty;

        public string SubjectName { get; set; } = string.Empty;

        public string GroupName { get; set; } = string.Empty;

        public string Kind { get; set; } = string.Empty;

        public int Hours { get; set; }
    }
}