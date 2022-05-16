using System.Globalization;
using Application.AdmissionCommittee.Data;
using Application.Common.Enums;
using Application.Common.Helpers;
using Application.Specialities.Data;

namespace Application.AdmissionCommittee.Services.StatementDocument;

public class StatementDocumentModel
{
    public StatementDocumentModel(Applicant applicant, IEnumerable<Speciality> specialities)
    {
        var applicantSpecialityIds = applicant.ApplicantSpecialities.Select(x => x.SpecialityId).ToHashSet();
        Now = applicant.Submitted;
        Culture = new CultureInfo("ru-RU");
        Specialities = specialities.Select(x => new SpecialityModel
        {
            Code = x.Code,
            Name = x.Name,
            IsSelected = applicantSpecialityIds.Contains(x.Id),
            EntranceTest = x.EntranceTest
        }).ToList();
        FullName = applicant.FullName;
        DateOfBirth = applicant.DateOfBirth;
        PassportNumber = applicant.Passport.Number;
        PassportSerial = applicant.Passport.Serial;
        PassportType = applicant.Passport.Type;
        PassportIssueDate = applicant.Passport.IssueDate;
        PassportIssuerCode = applicant.Passport.IssuerCode;
        PassportIssuer = applicant.Passport.Issuer;
        EducationType = applicant.EducationType;
        EducationDescription = applicant.EducationDescription;
        EducationDocumentSerial = applicant.EducationDocumentSerial;
        EducationDocumentNumber = applicant.EducationDocumentNumber;
        EducationDocumentIssued = applicant.EducationDocumentIssued;
        Form = applicant.EducationForm;
        FirstTimeInTechnicalSchool = applicant.FirstTimeInTechnicalSchool;
        NeedDormitory = applicant.NeedDormitory;
        Finance = applicant.FinanceEducationType;
        NeedFirefighterAssignment =
            Specialities.Any(x => x.IsSelected && x.EntranceTest == EntranceTestType.Firefighter);
        Address = applicant.Address;
        PostalCode = applicant.PostalCode;
        Phone = applicant.Phone;
        if (applicant.Mother is not null)
            Mother = new ParentModel
            {
                FirstName = applicant.Mother.FirstName,
                FamilyName = applicant.Mother.FamilyName,
                SurName = applicant.Mother.SurName,
                WorkDescription = applicant.Mother.WorkDescription,
                MobilePhone = applicant.Mother.MobilePhone,
                WorkPhone = applicant.Mother.WorkPhone,
                HomePhone = applicant.Mother.HomePhone
            };
        if (applicant.Father is not null)
            Father = new ParentModel
            {
                FirstName = applicant.Father.FirstName,
                FamilyName = applicant.Father.FamilyName,
                SurName = applicant.Father.SurName,
                WorkDescription = applicant.Father.WorkDescription,
                MobilePhone = applicant.Father.MobilePhone,
                WorkPhone = applicant.Father.WorkPhone,
                HomePhone = applicant.Father.HomePhone
            };
        DistanceApplicantWorkDescription = applicant.DistanceApplicantWorkDescription;
    }

    public DateTime Now { get; set; } = DateTime.Now;

    public CultureInfo Culture { get; set; } = CultureInfo.CurrentCulture;

    public List<SpecialityModel> Specialities { get; set; } = new();

    public string NowDay => Now.Day.ToString("00");

    public string NowMonth => Now.ToString("MMMM", Culture);

    public string NowYear => Now.Year.ToString("0000");

    public string FullName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public string DateOfBirthText => DateOfBirth.ToShortDateString();

    public string PassportNumber { get; set; } = string.Empty;

    public string PassportSerial { get; set; } = string.Empty;

    public string PassportType { get; set; } = string.Empty;

    public DateTime PassportIssueDate { get; set; }


    public string PassportIssuerCode { get; set; } = string.Empty;

    public string PassportIssuer { get; set; } = string.Empty;

    public EducationType EducationType { get; set; }

    public string EducationDescription { get; set; } = string.Empty;

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

    public string EducationDocumentSerial { get; set; } = string.Empty;

    public string EducationDocumentNumber { get; set; } = string.Empty;

    public DateTime EducationDocumentIssued { get; set; }

    public string EducationDocumentIssuedText => EducationDocumentIssued.ToShortDateString();

    public EducationForm Form { get; set; }

    public string DistanceFormSelection => Form == EducationForm.Distance ? "✓" : string.Empty;

    public string FullTimeFormSelection => Form == EducationForm.FullTime ? "✓" : string.Empty;

    public bool FirstTimeInTechnicalSchool { get; set; }

    public string FirstTimeInTechnicalSchoolSelection => FirstTimeInTechnicalSchool ? "✓" : string.Empty;

    public string NotFirstTimeInTechnicalSchoolSelection => !FirstTimeInTechnicalSchool ? "✓" : string.Empty;

    public bool NeedDormitory { get; set; }

    public string NeedDormitorySelection => NeedDormitory ? "✓" : string.Empty;

    public FinanceEducationType Finance { get; set; }

    public string BudgetSelection => Finance == FinanceEducationType.Budget ? "✓" : string.Empty;

    public string LegalEntitiesSelection => Finance == FinanceEducationType.LegalEntities ? "✓" : string.Empty;

    public string IndividualEntitiesSelection =>
        Finance == FinanceEducationType.IndividualEntities ? "✓" : string.Empty;

    public bool NeedFirefighterAssignment { get; set; }

    public string NeedFirefighterAssignmentSelection => NeedFirefighterAssignment ? "✓" : string.Empty;

    public string Address { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public ParentModel? Mother { get; set; }

    public ParentModel? Father { get; set; }

    public string? DistanceApplicantWorkDescription { get; set; } = string.Empty;

    public class SpecialityModel
    {
        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public bool IsSelected { get; set; }

        public string Selection => IsSelected ? "✓" : string.Empty;

        public EntranceTestType? EntranceTest { get; set; }
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