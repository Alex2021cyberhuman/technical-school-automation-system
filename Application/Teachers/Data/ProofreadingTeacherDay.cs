using System.ComponentModel.DataAnnotations;

namespace Application.Teachers.Data;

public class ProofreadingTeacherDay
{
    public int Number { get; set; }

    [Range(0, 24)] public int Hours { get; set; }
}