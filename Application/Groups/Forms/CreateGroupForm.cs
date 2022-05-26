using System.ComponentModel.DataAnnotations;
using Application.Common.Data;
using Application.Common.Enums;
using Application.Groups.Data;

namespace Application.Groups.Forms;

public class CreateGroupForm : IValidatableObject
{
    [Display(Name = "Название группы")]
    [MyRequired]
    [MyMaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public long SpecialityId { get; set; }

    public EducationForm EducationForm { get; set; }

    public FinanceEnrolmentType FinanceEnrolmentType { get; set; }

    [Display(Name = "Год выпуска")]
    [MyRequired]
    public int GraduationYear { get; set; }

    [Display(Name = "Год набора")]
    [MyRequired]
    public int EnrollmentYear { get; set; }

    public Group ToGroup()
    {
        return new Group
        {
            Name = Name,
            Created = DateTime.UtcNow,
            SpecialityId = SpecialityId,
            EducationForm = EducationForm,
            FinanceEnrolmentType = FinanceEnrolmentType,
            GraduationYear = GraduationYear,
            EnrollmentYear = EnrollmentYear
        };
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (GraduationYear < EnrollmentYear)
            yield return new ValidationResult("Год выпуска указан не верно", new[] { nameof(GraduationYear) });
    }
}