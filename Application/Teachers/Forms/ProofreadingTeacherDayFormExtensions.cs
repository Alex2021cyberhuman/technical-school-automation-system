using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public static class ProofreadingTeacherDayFormExtensions
{
    public static List<ProofreadingTeacherDay> ToProofreadingTeacherDays(
        this IEnumerable<ProofreadingTeacherDayForm> items)
    {
        return items
            .Select(x => new ProofreadingTeacherDay { Hours = x.Hours, Number = x.Number })
            .ToList();
    }

    public static List<ProofreadingTeacherDayForm> ToProofreadingTeacherDayForms(
        this IEnumerable<ProofreadingTeacherDay> items)
    {
        return items
            .Select(x => new ProofreadingTeacherDayForm { Hours = x.Hours, Number = x.Number })
            .ToList();
    }
}