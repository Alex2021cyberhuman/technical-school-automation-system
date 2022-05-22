using System.ComponentModel.DataAnnotations;

namespace Application.Teachers.Forms;

public class ProofreadingTeacherDayForm
{
    public int Number { get; set; }

    [Range(0, 24)] public int Hours { get; set; }

    public static List<ProofreadingTeacherDayForm> GetZeroHourDaysByMonth(int month, int year,
        List<ProofreadingTeacherDayForm>? proofreadingTeacherDayForms = null)
    {
        return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
            .Select((number, index) => new ProofreadingTeacherDayForm
            {
                Hours =
                    proofreadingTeacherDayForms?.ElementAtOrDefault(index)?.Hours ?? 0,
                Number = number
            })
            .ToList();
    }
}