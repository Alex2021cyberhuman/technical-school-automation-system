namespace Application.Common.Helpers;

public static class NameExtensions
{
    public static string GetFullName(string family, string first, string? sur) =>
        $"{family} {first}{(string.IsNullOrWhiteSpace(sur) ? string.Empty : $" {sur}")}";
}