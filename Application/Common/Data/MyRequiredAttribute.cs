using System.ComponentModel.DataAnnotations;

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