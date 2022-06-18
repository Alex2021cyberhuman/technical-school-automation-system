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
}