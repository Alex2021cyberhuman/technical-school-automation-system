using Application.AdmissionCommittee.Data;
using Application.Specialities.Data;
using Microsoft.Extensions.Localization;

namespace Application.AdmissionCommittee.Services.ApplicantsTable;

public class ApplicantsTableModel
{
    public ApplicantsTableModel(IEnumerable<Applicant> applicants, Speciality speciality, IStringLocalizer stringLocalizer)
    {
        SpecialityName = $"{speciality.Code} {speciality.Name}";
        Items = applicants.Select(x => new ApplicantModel(x, stringLocalizer)).ToList();
    }

    public string SpecialityName { get; set; }

    public List<ApplicantModel> Items { get; set; } = new();

    public class ApplicantModel
    {
        public ApplicantModel(Applicant applicant, IStringLocalizer stringLocalizer)
        {
            Number = applicant.Id;
            FullName = applicant.FullName;
            Education = stringLocalizer[applicant.EducationType.ToString()];
            LanguageRating = applicant.LanguageRating;
            MathRating = applicant.MathRating;
            AverageAttestRating = applicant.AverageAttestRating;
            CommonScore = applicant.CommonScore;
            Description = applicant.Description;
            DirectorDecision = stringLocalizer[applicant.DirectorDecision.ToString()];
        }

        public long Number { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Education { get; set; } = string.Empty;

        public decimal LanguageRating { get; set; }

        public decimal MathRating { get; set; }

        public decimal AverageAttestRating { get; set; }

        public decimal CommonScore { get; set; }

        public string Description { get; set; } = string.Empty;

        public string DirectorDecision { get; set; } = string.Empty;
    }
}