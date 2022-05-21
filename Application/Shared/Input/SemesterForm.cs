namespace Application.Shared.Input;

public class SemesterForm
{
    public int Number { get; set; }

    public int Hours { get; set; }

    public static List<SemesterForm> EightZeroHourSemesters =>
        Enumerable.Range(1, 8).Select(x => new SemesterForm { Number = x, Hours = 0 }).ToList();
}