using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public class EditProofreadingTeacherLoadForm
{
    public EditProofreadingTeacherLoadForm(ProofreadingTeacherLoad load)
    {
        TeacherLoad = load.TeacherLoad;
        Month = load.Month;
        Year = load.Year;
        Days = load.Days.ToProofreadingTeacherDayForms();
    }

    public TeacherLoad TeacherLoad { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public List<ProofreadingTeacherDayForm> Days { get; set; }

    public void ToProofreadingTeacherLoad(ProofreadingTeacherLoad load)
    {
        load.TeacherLoadId = TeacherLoad.Id;
        load.Month = Month;
        load.Year = Year;
        load.TotalHours = Days.Sum(x => x.Hours);
        load.Days = Days.ToProofreadingTeacherDays();
    }
}