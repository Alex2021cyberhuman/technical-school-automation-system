using System.ComponentModel.DataAnnotations;

namespace Application.AdmissionCommittee.Data;

public class ApplicantParent
{
    [MaxLength(200)] [Required] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string? SurName { get; set; }

    [MaxLength(1000)] public string WorkDescription { get; set; } = string.Empty;

    [Required] [MaxLength(20)] public string MobilePhone { get; set; } = string.Empty;

    [MaxLength(20)] public string WorkPhone { get; set; } = string.Empty;

    [MaxLength(20)] public string HomePhone { get; set; } = string.Empty;
}