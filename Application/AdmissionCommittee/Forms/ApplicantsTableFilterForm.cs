using Application.Common.Enums;
using Application.Shared.Input;

namespace Application.AdmissionCommittee.Forms;

public class ApplicantsTableFilterForm
{
    public long? SelectedSpecialityId { get; set; }

    public int SelectedYear { get; set; } = DateTime.Today.Year;

    public EducationForm? SelectedEducationForm { get; set; }

    public FinanceEnrolmentType? SelectedFinanceEnrolmentType { get; set; }

    public string? SearchString { get; set; }

    public List<ValueRadioItem<long?>> SpecialityRadioItems { get; set; } = new();

    public DirectorDecisionType? SelectedDirectorDecisionType { get; set; }

    public void Reset()
    {
        SelectedSpecialityId = null;
        SelectedYear = DateTime.Today.Year;
        SelectedEducationForm = null;
        SelectedFinanceEnrolmentType = null;
        SearchString = null;
        SelectedDirectorDecisionType = null;
    }
}