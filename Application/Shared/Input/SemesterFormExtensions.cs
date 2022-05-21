using Application.Specialities.Data;

namespace Application.Shared.Input;

public static class SemesterFormExtensions
{
    public static List<Semester> ToSemesters(this IEnumerable<SemesterForm> semesterForms)
    {
        return semesterForms.Select(x => new Semester { Number = x.Number, Hours = x.Hours }).ToList();
    }

    public static List<SemesterForm> ToSemesterForms(this IEnumerable<Semester> semesterForms)
    {
        return semesterForms.Select(x => new SemesterForm { Number = x.Number, Hours = x.Hours }).ToList();
    }
}