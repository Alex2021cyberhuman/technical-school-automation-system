using System.ComponentModel.DataAnnotations;
using Application.Common.Enums;
using Application.Specialities.Data;

namespace Application.Groups.Data;

public class Group
{
    public long Id { get; set; }

    [Required] [MaxLength(100)] public string Name { get; set; } = string.Empty;

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public Speciality Speciality { get; set; } = null!;

    public long SpecialityId { get; set; }

    public EducationForm EducationForm { get; set; }

    public FinanceEnrolmentType FinanceEnrolmentType { get; set; }

    [Required] [Range(0, 1000)] public int StudentsCount { get; set; }

    public int GraduationYear { get; set; }

    public DateTime Graduation { get; set; }

    public int EnrollmentYear { get; set; }

    public DateTime Enrollment { get; set; }

    public List<Student> Students { get; set; } = null!;
}