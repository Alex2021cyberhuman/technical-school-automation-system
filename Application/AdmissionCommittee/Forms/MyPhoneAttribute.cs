using System.ComponentModel.DataAnnotations;

namespace Application.AdmissionCommittee.Forms;

public class MyPhoneAttribute : DataTypeAttribute
{
    private const string AdditionalPhoneNumberCharacters = "-.()";
    private const string ExtensionAbbreviationExtDot = "ext.";
    private const string ExtensionAbbreviationExt = "ext";
    private const string ExtensionAbbreviationX = "x";

    public MyPhoneAttribute()
        : base(DataType.PhoneNumber)
    {
        // Set DefaultErrorMessage not ErrorMessage, allowing user to set
        // ErrorMessageResourceType and ErrorMessageResourceName to use localized messages.
        ErrorMessage = "{0} Не похож на номер телефона";
    }

    public override bool IsValid(object? value)
    {
        if (value is null) return true;

        if (!(value is string valueAsString)) return false;

        if (string.IsNullOrWhiteSpace(valueAsString)) return true;

        valueAsString = valueAsString.Replace("+", string.Empty).TrimEnd();
        valueAsString = RemoveExtension(valueAsString);

        var digitFound = false;
        foreach (var c in valueAsString)
            if (char.IsDigit(c))
            {
                digitFound = true;
                break;
            }

        if (!digitFound) return false;

        foreach (var c in valueAsString)
            if (!(char.IsDigit(c)
                  || char.IsWhiteSpace(c)
                  || AdditionalPhoneNumberCharacters.IndexOf(c) != -1))
                return false;

        return true;
    }

    private static string RemoveExtension(string potentialPhoneNumber)
    {
        var lastIndexOfExtension = potentialPhoneNumber
            .LastIndexOf(ExtensionAbbreviationExtDot, StringComparison.OrdinalIgnoreCase);
        if (lastIndexOfExtension >= 0)
        {
            var extension = potentialPhoneNumber.Substring(
                lastIndexOfExtension + ExtensionAbbreviationExtDot.Length);
            if (MatchesExtension(extension)) return potentialPhoneNumber.Substring(0, lastIndexOfExtension);
        }

        lastIndexOfExtension = potentialPhoneNumber
            .LastIndexOf(ExtensionAbbreviationExt, StringComparison.OrdinalIgnoreCase);
        if (lastIndexOfExtension >= 0)
        {
            var extension = potentialPhoneNumber.Substring(
                lastIndexOfExtension + ExtensionAbbreviationExt.Length);
            if (MatchesExtension(extension)) return potentialPhoneNumber.Substring(0, lastIndexOfExtension);
        }

        lastIndexOfExtension = potentialPhoneNumber
            .LastIndexOf(ExtensionAbbreviationX, StringComparison.OrdinalIgnoreCase);
        if (lastIndexOfExtension >= 0)
        {
            var extension = potentialPhoneNumber.Substring(
                lastIndexOfExtension + ExtensionAbbreviationX.Length);
            if (MatchesExtension(extension)) return potentialPhoneNumber.Substring(0, lastIndexOfExtension);
        }

        return potentialPhoneNumber;
    }

    private static bool MatchesExtension(string potentialExtension)
    {
        potentialExtension = potentialExtension.TrimStart();
        if (potentialExtension.Length == 0) return false;

        foreach (var c in potentialExtension)
            if (!char.IsDigit(c))
                return false;

        return true;
    }
}