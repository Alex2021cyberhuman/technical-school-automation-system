using System.ComponentModel.DataAnnotations;
using Application.Common.Enums;
using Application.Common.Helpers;
using Application.Specialities.Data;

namespace Application.AdmissionCommittee.Data;

public class Applicant
{
    public long Id { get; set; }

    public DateTime Submitted { get; set; } = DateTime.UtcNow;

    public string FullName => NameExtensions.GetFullName(FamilyName, FirstName, SurName);

    [MaxLength(200)] [Required] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string? SurName { get; set; }

    public DateTime DateOfBirth { get; set; }

    [MaxLength(2000)] public string Description { get; set; } = string.Empty;

    [Required]  public decimal LanguageRating { get; set; }

    [Required] public decimal MathRating { get; set; }

    [Required] public decimal AverageAttestRating { get; set; }
    
    [Required] public decimal CommonScore { get; set; }

    public EducationType EducationType { get; set; }

    [MaxLength(2000)] [Required] public string EducationDescription { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string EducationDocumentSerial { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string EducationDocumentNumber { get; set; } = string.Empty;

    public DateTime EducationDocumentIssued { get; set; }

    public EducationForm EducationForm { get; set; }

    public bool FirstTimeInTechnicalSchool { get; set; }

    public bool NeedDormitory { get; set; }

    public FinanceEducationType FinanceEducationType { get; set; }

    [MaxLength(2000)] [Required] public string Address { get; set; } = string.Empty;

    [MaxLength(20)] [Required] public string PostalCode { get; set; } = string.Empty;

    [MaxLength(20)] [Required] public string Phone { get; set; } = string.Empty;

    public ApplicantParent? Mother { get; set; }

    public ApplicantParent? Father { get; set; }

    [MaxLength(2000)] public string DistanceApplicantWorkDescription { get; set; } = string.Empty;

    [Required] public List<ApplicantSpeciality> ApplicantSpecialities { get; set; } = null!;

    public DirectorDecisionType DirectorDecision { get; set; }
    
    public Statement Statement { get; set; } = null!;

    public ApplicantPassport Passport { get; set; } = null!;
}