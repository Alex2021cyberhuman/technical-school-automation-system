using System.Text.RegularExpressions;

namespace Application.Schedules.Data;

public static class SortOrdersExtensions
{
    private static readonly Regex CompiledNumberReplacer = new(@"\d+", RegexOptions.Compiled);

    public static string ToNaturalSortString(this string alphaNumeric, int maxNumberLength = 3)
    {
        return CompiledNumberReplacer.Replace(alphaNumeric, m => m.Value.PadLeft(maxNumberLength, '0'));
    }
}