using System.Globalization;
using Application.Common.Enums;
using Application.Common.Helpers;

namespace Application.AdmissionCommittee.Services.StatementDocument;

public class StatementDocumentModel
{
    public DateTime Now { get; init; } = DateTime.Now;

    public CultureInfo Culture { get; init; } = CultureInfo.CurrentCulture;

    public List<SpecialityModel> Specialities { get; init; } = new();

    public string NowDay => Now.Day.ToString("00");

    public string NowMonth => Now.ToString("MMMM", Culture);

    public string NowYear => Now.Year.ToString("0000");

    public string FullName { get; init; } = string.Empty;

    public DateTime DateOfBirth { get; init; }

    public string DateOfBirthText => DateOfBirth.ToShortDateString();

    public string PassportNumber { get; init; } = string.Empty;

    public string PassportSerial { get; init; } = string.Empty;

    public string PassportType { get; init; } = string.Empty;

    public DateTime PassportIssueDate { get; init; }


    public string PassportIssuerCode { get; init; } = string.Empty;

    public string PassportIssuer { get; init; } = string.Empty;

    public EducationType EducationType { get; init; }

    public string EducationDescription { get; init; } = string.Empty;

    public int LearnYear => EducationDocumentIssued.Year;

    public string CommonMiddleSchoolDescription =>
        EducationType == EducationType.CommonMiddleSchool ? EducationDescription : string.Empty;

    public string CommonMiddleSchoolSelection =>
        EducationType == EducationType.CommonMiddleSchool ? "✓" : string.Empty;

    public string MiddleSchoolDescription =>
        EducationType == EducationType.MiddleSchool ? EducationDescription : string.Empty;

    public string MiddleSchoolSelection => EducationType == EducationType.MiddleSchool ? "✓" : string.Empty;

    public string TechnicalSchoolDescription =>
        EducationType == EducationType.TechnicalSchool ? EducationDescription : string.Empty;

    public string TechnicalSchoolSelection =>
        EducationType == EducationType.TechnicalSchool ? "✓" : string.Empty;

    public string HigherDescription => EducationType == EducationType.Higher ? EducationDescription : string.Empty;

    public string HigherSelection => EducationType == EducationType.Higher ? "✓" : string.Empty;

    public string AttestSelection =>
        EducationType is EducationType.MiddleSchool or EducationType.CommonMiddleSchool ? "✓" : string.Empty;

    public string DiplomaSelection => EducationType is EducationType.Higher or EducationType.TechnicalSchool
        ? "✓"
        : string.Empty;

    public string EducationDocumentSerial { get; init; } = string.Empty;

    public string EducationDocumentNumber { get; init; } = string.Empty;

    public DateTime EducationDocumentIssued { get; init; }

    public string EducationDocumentIssuedText => EducationDocumentIssued.ToShortDateString();

    public EducationForm Form { get; init; }

    public string DistanceFormSelection => Form == EducationForm.Distance ? "✓" : string.Empty;

    public string FullTimeFormSelection => Form == EducationForm.FullTime ? "✓" : string.Empty;

    public bool FirstTimeInTechnicalSchool { get; init; }

    public string FirstTimeInTechnicalSchoolSelection => FirstTimeInTechnicalSchool ? "✓" : string.Empty;

    public string NotFirstTimeInTechnicalSchoolSelection => !FirstTimeInTechnicalSchool ? "✓" : string.Empty;

    public bool NeedDormitory { get; init; }

    public string NeedDormitorySelection => NeedDormitory ? "✓" : string.Empty;

    public FinanceEducationType Finance { get; init; }

    public string BudgetSelection => Finance == FinanceEducationType.Budget ? "✓" : string.Empty;

    public string LegalEntitiesSelection => Finance == FinanceEducationType.LegalEntities ? "✓" : string.Empty;

    public string IndividualEntitiesSelection =>
        Finance == FinanceEducationType.IndividualEntities ? "✓" : string.Empty;

    public bool NeedFirefighterAssignment { get; init; }

    public string NeedFirefighterAssignmentSelection => NeedFirefighterAssignment ? "✓" : string.Empty;

    public string Address { get; init; } = string.Empty;

    public string PostalCode { get; init; } = string.Empty;

    public string Phone { get; init; } = string.Empty;

    public ParentModel? Mother { get; init; }

    public ParentModel? Father { get; init; }

    public string? DistanceApplicantWorkDescription { get; init; } = string.Empty;

    public class SpecialityModel
    {
        public string Name { get; init; } = string.Empty;

        public string Code { get; init; } = string.Empty;

        public bool IsSelected { get; init; }

        public string Selection => IsSelected ? "✓" : string.Empty;
    }

    public class ParentModel
    {
        public string FullName => NameExtensions.GetFullName(FamilyName, FirstName, SurName);
    
        public string FirstName { get; set; } = string.Empty;

        public string FamilyName { get; set; } = string.Empty;

        public string? SurName { get; set; }

        public string WorkDescription { get; set; } = string.Empty;

        public string MobilePhone { get; set; } = string.Empty;

        public string WorkPhone { get; set; } = string.Empty;

        public string HomePhone { get; set; } = string.Empty;
    }
}