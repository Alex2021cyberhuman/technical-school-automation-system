using System.ComponentModel.DataAnnotations;

namespace Application.Teachers.Data;

public class ProofreadingTeacherLoad
{
    public long Id { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    public long TeacherLoadId { get; set; }

    public TeacherLoad TeacherLoad { get; set; } = null!;

    public int Month { get; set; }

    public int Year { get; set; }

    [Range(0, 800)]
    public int TotalHours { get; set; }

    public List<ProofreadingTeacherDay> Days { get; set; } = new();
}