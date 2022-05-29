namespace Application.Common.Helpers;

public static class NameExtensions
{
    public static string GetFullName(string family, string first, string? sur)
    {
        return
            $"{family}{(string.IsNullOrWhiteSpace(first) ? string.Empty : $" {first}")}{(string.IsNullOrWhiteSpace(sur) ? string.Empty : $" {sur}")}";
    }

    public static string GetInitials(string family, string first, string? sur)
    {
        return
            $"{(string.IsNullOrWhiteSpace(first) ? string.Empty : $"{first.First()}.")}{(string.IsNullOrWhiteSpace(sur) ? string.Empty : $"{sur.First()}.")} {family}";
    }
}