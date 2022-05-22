using System.Globalization;

namespace Application.Common.Services;

public class MonthsService
{
    private static readonly Dictionary<int, string> RussianMonthNames = new()
    {
        { 1, "Январь" },
        { 2, "Февраль" },
        { 3, "Март" },
        { 4, "Апрель" },
        { 5, "Май" },
        { 6, "Июнь" },
        { 7, "Июль" },
        { 8, "Август" },
        { 9, "Сентябрь" },
        { 10, "Октябрь" },
        { 11, "Ноябрь" },
        { 12, "Декабрь" }
    };

    public string GetName(int month)
    {
        return GetLocalizedName(month, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
    }

    private static string GetLocalizedName(int month, string twoLetterIsoLanguageName)
    {
        return twoLetterIsoLanguageName switch
        {
            "ru" => RussianMonthNames[month],
            _ => throw new ArgumentOutOfRangeException(nameof(twoLetterIsoLanguageName))
        };
    }
}