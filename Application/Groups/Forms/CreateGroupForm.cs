using System.ComponentModel.DataAnnotations;
using Application.Common.Enums;
using Application.Groups.Data;

namespace Application.Groups.Forms;

public class CreateGroupForm
{
    [Display(Name = "Название группы")]
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public long SpecialityId { get; set; }
    public EducationForm EducationForm { get; set; }

    public FinanceEnrolmentType FinanceEnrolmentType { get; set; }

    public Group ToGroup()
    {
        return new Group
        {
            Name = Name,
            Created = DateTime.UtcNow,
            SpecialityId = SpecialityId,
            EducationForm = EducationForm,
            FinanceEnrolmentType = FinanceEnrolmentType
        };
    }
}