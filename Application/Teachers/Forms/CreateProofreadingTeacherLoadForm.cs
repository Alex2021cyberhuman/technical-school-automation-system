using System.ComponentModel.DataAnnotations;
using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public class CreateProofreadingTeacherLoadForm
{
    [Required] public TeacherLoad? TeacherLoad { get; set; }

    public int Year { get; set; } = DateTime.Today.Year;

    public int Month { get; set; } = DateTime.Today.Month;

    public List<ProofreadingTeacherDayForm> Days { get; set; } =
        ProofreadingTeacherDayForm.GetZeroHourDaysByMonth(DateTime.Today.Month, DateTime.Today.Year);

    public ProofreadingTeacherLoad ToProofreadingTeacherLoad()
    {
        return new()
        {
            TeacherLoadId = TeacherLoad!.Id,
            Month = Month,
            Year = Year,
            TotalHours = Days.Sum(x => x.Hours),
            Days = Days.ToProofreadingTeacherDays()
        };
    }
}