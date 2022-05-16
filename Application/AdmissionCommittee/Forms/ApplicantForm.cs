using System.ComponentModel.DataAnnotations;
using Application.AdmissionCommittee.Data;
using Application.Common.Enums;
using Application.Specialities.Data;

namespace Application.AdmissionCommittee.Forms;

public class ApplicantForm
{
    [Display(Name = "Фамилия")]
    [MaxLength(200)]
    [Required]
    public string FamilyName { get; set; } = string.Empty;

    [Display(Name = "Имя")]
    [MaxLength(200)]
    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Отчество")]
    [MaxLength(200)]
    public string SurName { get; set; } = string.Empty;

    [Display(Name = "Дата рождения")]
    [Required]
    public DateTime DateOfBirth { get; set; } = DateTime.UtcNow.Date;

    [Display(Name = "Тип паспорта")]
    [Required]
    [MaxLength(20)]
    public string PassportType { get; set; } = "Паспорт";

    [Display(Name = "Серия паспорта")]
    [Required]
    [MaxLength(20)]
    public string PassportSerial { get; set; } = string.Empty;

    [Display(Name = "Номер паспорта")]
    [Required]
    [MaxLength(20)]
    public string PassportNumber { get; set; } = string.Empty;

    [Display(Name = "Кем выдан паспорт")]
    [Required]
    [MaxLength(300)]
    public string PassportIssuer { get; set; } = string.Empty;

    [Display(Name = "Код паспорта")]
    [MaxLength(20)]
    public string PassportIssuerCode { get; set; } = string.Empty;

    [Display(Name = "Дата выдачи паспорта")]
    [Required]
    public DateTime PassportIssueDate { get; set; } = DateTime.UtcNow.Date;

    [Display(Name = "Место жительства")]
    [Required]
    [MaxLength(2000)]
    public string Address { get; set; } = string.Empty;

    [Display(Name = "Почтовый индекс")]
    [MaxLength(20)]
    [Required]
    public string PostalCode { get; set; } = string.Empty;

    [Display(Name = "Мобильный телефон")]
    [MaxLength(20)]
    [Required]
    [MyPhone]
    public string Phone { get; set; } = string.Empty;

    [Display(Name = "Дополнительные сведения")]
    public string Description { get; set; } = string.Empty;

    [Display(Name = "Баллы по русскому языку")]
    public decimal LanguageRating { get; set; } = 50;

    [Display(Name = "Баллы по математике")]
    public decimal MathRating { get; set; } = 50;

    [Display(Name = "Средний бал по атестату")]
    public decimal AverageAttestRating { get; set; } = 3;

    [Display(Name = "Тип базового образования")]
    public EducationType EducationType { get; set; } = EducationType.CommonMiddleSchool;

    [Required]
    [MaxLength(2000)]
    [Display(Name = "Учебное заведение")]
    public string EducationDescription { get; set; } = string.Empty;

    [Display(Name = "Серия документа об образовании")]
    [MaxLength(200)]
    [Required]
    public string EducationDocumentSerial { get; set; } = string.Empty;

    [Display(Name = "Номер документа об образовании")]
    [MaxLength(200)]
    [Required]
    public string EducationDocumentNumber { get; set; } = string.Empty;

    [Display(Name = "Дата выдачи документа об образовании")]
    [Required]
    public DateTime EducationDocumentIssued { get; set; } = DateTime.UtcNow.Date;

    [Display(Name = "Форма обучения")] public EducationForm EducationForm { get; set; }

    [Display(Name = "Первый раз в техникуме")]
    public bool FirstTimeInTechnicalSchool { get; set; }

    [Display(Name = "Нужно общежитие")] public bool NeedDormitory { get; set; }

    [Display(Name = "Тип финансирования")] public FinanceEducationType FinanceEducationType { get; set; }

    [Display(Name = "Есть мать")] public bool HasMother { get; set; }

    [Display(Name = "Имя матери")]
    [MaxLength(200)]
    public string MotherFirstName { get; set; } = string.Empty;

    [Display(Name = "Фамилия матери")]
    [MaxLength(200)]
    public string MotherFamilyName { get; set; } = string.Empty;

    [Display(Name = "Отчество матери")]
    [MaxLength(200)]
    public string MotherSurName { get; set; } = string.Empty;

    [Display(Name = "Описание работы матери")]
    public string MotherWorkDescription { get; set; } = string.Empty;

    [Display(Name = "Мобильный телефон матери")]
    [MaxLength(20)]
    [MyPhone]
    public string MotherMobilePhone { get; set; } = string.Empty;

    [Display(Name = "Рабочий телефон матери")]
    [MaxLength(20)]
    [MyPhone]
    public string MotherWorkPhone { get; set; } = string.Empty;

    [Display(Name = "Домашний телефон матери")]
    [MaxLength(20)]
    [MyPhone]
    public string MotherHomePhone { get; set; } = string.Empty;

    [Display(Name = "Есть отец")] public bool HasFather { get; set; }

    [Display(Name = "Имя отца")]
    [MaxLength(200)]
    public string FatherFirstName { get; set; } = string.Empty;

    [Display(Name = "Фамилия отца")]
    [MaxLength(200)]
    public string FatherFamilyName { get; set; } = string.Empty;

    [Display(Name = "Отчество отца")]
    [MaxLength(200)]
    public string FatherSurName { get; set; } = string.Empty;

    [Display(Name = "Описание работы отца")]
    public string FatherWorkDescription { get; set; } = string.Empty;

    [Display(Name = "Мобильный телефон отца")]
    [MaxLength(20)]
    [MyPhone]
    public string FatherMobilePhone { get; set; } = string.Empty;

    [Display(Name = "Рабочий телефон отца")]
    [MaxLength(20)]
    [MyPhone]
    public string FatherWorkPhone { get; set; } = string.Empty;

    [Display(Name = "Домашний телефон отца")]
    [MaxLength(20)]
    [MyPhone]
    public string FatherHomePhone { get; set; } = string.Empty;

    [Display(Name = "Описание работы")]
    [MaxLength(2000)]
    public string DistanceApplicantWorkDescription { get; set; } = string.Empty;

    [MinLength(1)]
    [MaxLength(3)]
    [Required]
    [Display(Name = "Специальности")]
    public List<long> SelectedSpecialityIds { get; set; } = new();

    public Applicant ConvertToApplicant(IReadOnlyDictionary<long, Speciality> specialities)
    {
        var applicant = new Applicant
        {
            Submitted = DateTime.UtcNow,
            FirstName = FirstName,
            FamilyName = FamilyName,
            SurName = SurName,
            DateOfBirth = DateOfBirth.Date.ToUniversalTime(),
            Description = Description,
            LanguageRating = LanguageRating,
            MathRating = MathRating,
            AverageAttestRating = AverageAttestRating,
            CommonScore = (AverageAttestRating + (MathRating + LanguageRating) / 40) / 2,
            EducationType = EducationType,
            EducationDescription = EducationDescription,
            EducationDocumentSerial = EducationDocumentSerial,
            EducationDocumentNumber = EducationDocumentNumber,
            EducationDocumentIssued = EducationDocumentIssued.Date.ToUniversalTime(),
            EducationForm = EducationForm,
            FirstTimeInTechnicalSchool = FirstTimeInTechnicalSchool,
            NeedDormitory = NeedDormitory,
            FinanceEducationType = FinanceEducationType,
            Address = Address,
            PostalCode = PostalCode,
            Phone = Phone,
            Mother = HasMother
                ? new ApplicantParent
                {
                    WorkDescription = MotherWorkDescription,
                    MobilePhone = MotherMobilePhone,
                    WorkPhone = MotherWorkPhone,
                    HomePhone = MotherHomePhone,
                    FirstName = MotherFirstName,
                    FamilyName = MotherFamilyName,
                    SurName = MotherSurName
                }
                : null,
            Father = HasFather
                ? new ApplicantParent
                {
                    WorkDescription = FatherWorkDescription,
                    MobilePhone = FatherMobilePhone,
                    WorkPhone = FatherWorkPhone,
                    HomePhone = FatherHomePhone,
                    FirstName = FatherFirstName,
                    FamilyName = FatherFamilyName,
                    SurName = FatherSurName
                }
                : null,
            DistanceApplicantWorkDescription = DistanceApplicantWorkDescription,
            ApplicantSpecialities = SelectedSpecialityIds.Select(specialities.GetValueOrDefault)
                .Where(x => x is not null).Select(x => new ApplicantSpeciality()
                {
                    SpecialityId = x!.Id
                }).ToList(),
            DirectorDecision = DirectorDecisionType.NotСonsidered,
            Passport = new ApplicantPassport
            {
                Serial = PassportSerial,
                Number = PassportNumber,
                Issuer = PassportIssuer,
                IssuerCode = PassportIssuerCode,
                Type = PassportType,
                IssueDate = PassportIssueDate.Date.ToUniversalTime()
            }
        };
        return applicant;
    }
}