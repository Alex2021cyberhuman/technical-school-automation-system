using Application.Common.Enums;
using Application.Shared.Input;

namespace Application.AdmissionCommittee.Forms;

public class ApplicantsTableFilterForm
{
    public long SelectedSpecialityId { get; set; }

    public List<ValueRadioItem<long>> SpecialityRadioItems { get; set; } = new();

    public int SelectedYear { get; set; }

    public List<ValueRadioItem<int>> YearRadioItems { get; set; } = new();

    public EducationForm SelectedEducationForm { get; set; } = EducationForm.FullTime;

    public List<ValueRadioItem<EducationForm>> EducationForms { get; set; } = new();

    public FinanceEducationType SelectedFinanceType { get; set; }

    public List<ValueRadioItem<FinanceEducationType>> FinanceTypes { get; set; } = new();
}