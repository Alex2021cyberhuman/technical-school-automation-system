using System.ComponentModel.DataAnnotations;

namespace Application.Specialities.Data;

public class Subject
{
    public long Id { get; set; }

    [Required] [MaxLength(150)] public string Name { get; set; } = string.Empty;

    [Required] [MaxLength(20)] public string Code { get; set; } = string.Empty;

    public Speciality Speciality { get; set; } = null!;

    public long SpecialityId { get; set; }

    public List<Semester> Semesters { get; set; } = null!;
}