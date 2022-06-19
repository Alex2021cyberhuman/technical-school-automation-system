using System.Diagnostics.CodeAnalysis;

namespace Application.Common.Helpers;

public static class DateExtensions
{
    private static IEnumerable<DayOfWeek> DayOfWeeks { get; } = new[]
    {
        DayOfWeek.Monday,
        DayOfWeek.Tuesday,
        DayOfWeek.Wednesday,
        DayOfWeek.Thursday,
        DayOfWeek.Friday
    };

    public static DateTime GetWorkDateFrom(this DateTime? dateTime)
    {
        dateTime ??= DateTime.UtcNow.Date;

        return GetWorkDateFrom(dateTime.Value);
    }

    public static DateTime GetWorkDateFrom(this DateTime dateTime)
    {
        if (dateTime.Date < DateTime.UtcNow.Date) dateTime = DateTime.UtcNow.Date;

        while (!DayOfWeeks.Contains(dateTime.DayOfWeek)) dateTime = dateTime.AddDays(1);

        return dateTime;
    }

    public static string GetShortDayOfWeek(this DateTime dateTime)
    {
        return dateTime.DayOfWeek switch
        {
            DayOfWeek.Sunday => "вс",
            DayOfWeek.Monday => "пн",
            DayOfWeek.Tuesday => "вт",
            DayOfWeek.Wednesday => "ср",
            DayOfWeek.Thursday => "чт",
            DayOfWeek.Friday => "пт",
            DayOfWeek.Saturday => "сб",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}