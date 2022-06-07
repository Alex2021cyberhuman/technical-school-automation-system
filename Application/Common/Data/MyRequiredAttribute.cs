using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application.Common.Data;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class MyRequiredAttribute : RequiredAttribute
{
    public MyRequiredAttribute() : base()
    {
        ErrorMessageResourceName = "RequiredAttribute_ValidationError";
        ErrorMessageResourceType = typeof(Resources.Resource);
    }
}