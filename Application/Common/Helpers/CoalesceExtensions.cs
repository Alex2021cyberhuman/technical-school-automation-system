namespace Application.Common.Helpers;

public static class CoalesceExtensions
{
    public static TPrimary OrToDefault<TPrimary>(this TPrimary? primary, TPrimary def)
    {
        return primary ?? def;
    }

    public static string OrToDefault(this string? primary, string def)
    {
        return string.IsNullOrWhiteSpace(primary) ? def : primary;
    }
}