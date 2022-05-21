namespace Application.Specialities.Data;

public class ProofreadingTeacherLoad
{
    public long Id { get; set; }

    public long TeacherLoadId { get; set; }

    public TeacherLoad TeacherLoad { get; set; } = null!;

    public int Month { get; set; }

    public int Year { get; set; }

    public List<ProofreadingTeacherDay> Days { get; set; } = new();
}