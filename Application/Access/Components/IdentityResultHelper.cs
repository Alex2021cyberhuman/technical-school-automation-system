using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Application.Access.Components;

public static class IdentityResultHelper
{
    public static string GetErrorsString(this IdentityResult result, string title = "Не удалось выполнить операцию!")
    {
        if (result.Succeeded)
        {
            return string.Empty;
        }

        var errorMessageSb = new StringBuilder(title);
        foreach (var identityError in result.Errors)
        {
            errorMessageSb.AppendLine(identityError.Description);
        }

        return errorMessageSb.ToString();
    }
}