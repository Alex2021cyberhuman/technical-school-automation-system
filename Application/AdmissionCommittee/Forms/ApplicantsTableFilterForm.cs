using Application.Common.Enums;
using Application.Shared.Input;

namespace Application.AdmissionCommittee.Forms;

public class ApplicantsTableFilterForm
{
    public long SelectedSpecialityId { get; set; }

    public List<MyInputRadioGroup<long>.ValueRadioItem> SpecialityRadioItems { get; set; } = new();

    public int SelectedYear { get; set; }

    public List<MyInputRadioGroup<int>.ValueRadioItem> YearRadioItems { get; set; } = new();

    public EducationForm SelectedEducationForm { get; set; } = EducationForm.FullTime;

    public List<MyInputRadioGroup<EducationForm>.ValueRadioItem> EducationForms { get; set; } = new();
    
    public FinanceEducationType SelectedFinanceType { get; set; }

    public List<MyInputRadioGroup<FinanceEducationType>.ValueRadioItem> FinanceTypes { get; set; } = new();
}