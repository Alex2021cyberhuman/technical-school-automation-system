using System.ComponentModel.DataAnnotations;
using Application.Common.Enums;

namespace Application.AdmissionCommittee.Forms;

public class ApplicantForm
{
    public bool HasMother { get; set; }

    public bool HasFather { get; set; }

    [MaxLength(200)] [Required] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string SurName { get; set; } = string.Empty;

    [Required] public DateTime DateOfBirth { get; set; } = DateTime.Today;

    [Required] [MaxLength(20)] public string PassportSerial { get; set; } = string.Empty;

    [Required] [MaxLength(20)] public string PassportNumber { get; set; } = string.Empty;

    [Required] [MaxLength(300)] public string PassportIssuer { get; set; } = string.Empty;

    [MaxLength(20)] string PassportIssuerCode { get; set; } = string.Empty;

    [Required] [MaxLength(20)] public string PassportType { get; set; } = "Паспорт";

    [Required] public DateTime PassportIssueDate { get; set; } = DateTime.Today;

    public string Description { get; set; } = string.Empty;

    public decimal LanguageRating { get; set; } = 50;

    public decimal MathRating { get; set; } = 50;

    public decimal AverageAttestRating { get; set; } = 3;

    public EducationType EducationType { get; set; } = EducationType.CommonMiddleSchool;

    [Required] [MaxLength(2000)] public string EducationDescription { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string EducationDocumentSerial { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string EducationDocumentNumber { get; set; } = string.Empty;

    [Required] public DateTime EducationDocumentIssued { get; set; } = DateTime.Today;

    public EducationForm EducationForm { get; set; }

    public bool FirstTimeInTechnicalSchool { get; set; }

    public bool NeedDormitory { get; set; }

    public FinanceEducationType FinanceEducationType { get; set; }

    [Required] [MaxLength(2000)] public string Address { get; set; } = string.Empty;

    [MaxLength(20)] [Required] public string PostalCode { get; set; } = string.Empty;

    [MaxLength(20)] [Required] [Phone] public string Phone { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string MotherFirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string MotherFamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string MotherSurName { get; set; } = string.Empty;

    public string MotherWorkDescription { get; set; } = string.Empty;

    [Required] [MaxLength(20)] [Phone] public string MotherMobilePhone { get; set; } = string.Empty;

    [MaxLength(20)] [Phone] public string MotherWorkPhone { get; set; } = string.Empty;

    [MaxLength(20)] [Phone] public string MotherHomePhone { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FatherFirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FatherFamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string FatherSurName { get; set; } = string.Empty;

    public string FatherWorkDescription { get; set; } = string.Empty;

    [Required] [MaxLength(20)] [Phone] public string FatherMobilePhone { get; set; } = string.Empty;

    [MaxLength(20)] [Phone] public string FatherWorkPhone { get; set; } = string.Empty;

    [MaxLength(20)] [Phone] public string FatherHomePhone { get; set; } = string.Empty;

    [MaxLength(2000)] public string DistanceApplicantWorkDescription { get; set; } = string.Empty;

    [MinLength(1)]
    [MaxLength(3)]
    [Required]
    public string[] SelectedSpecialityIds { get; set; } = Array.Empty<string>();
}