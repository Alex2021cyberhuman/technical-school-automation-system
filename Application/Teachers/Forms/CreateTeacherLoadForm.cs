using System.ComponentModel.DataAnnotations;
using Application.Groups.Data;
using Application.Shared.Input;
using Application.Specialities.Data;
using Application.Teachers.Components;
using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public class CreateTeacherLoadForm
{
    public List<SemesterForm> Semesters { get; set; } = SemesterForm.EightZeroHourSemesters;

    public TeacherLoadKind Kind { get; set; }

    [Required] public Group? Group { get; set; }

    [Required] public Subject? Subject { get; set; }

    public TeacherLoad ToTeacherLoad(long teacherId)
    {
        _ = Group ?? throw new NullReferenceException();
        _ = Subject ?? throw new NullReferenceException();
        return new()
        {
            GroupId = Group.Id,
            TeacherId = teacherId,
            SubjectId = Subject.Id,
            Semesters = Semesters.ToSemesters(),
            Kind = Kind
        };
    }
}

public class CreateProofreadingTeacherLoadForm
{
    [Required] public TeacherLoad? TeacherLoad { get; set; }

    public int Year { get; set; } = DateTime.Today.Year;

    public int Month { get; set; } = DateTime.Today.Month;

    public List<ProofreadingTeacherDayForm> Days { get; set; } =
        ProofreadingTeacherDayForm.GetZeroHourDaysByMonth(DateTime.Today.Month, DateTime.Today.Year);
}

public class ProofreadingTeacherDayForm
{
    public int Number { get; set; }

    [Range(0, 24)] public int Hours { get; set; }

    public static List<ProofreadingTeacherDayForm> GetZeroHourDaysByMonth(int month, int year)
    {
        return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
            .Select(x => new ProofreadingTeacherDayForm { Hours = 0, Number = x })
            .ToList();
    }
}

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