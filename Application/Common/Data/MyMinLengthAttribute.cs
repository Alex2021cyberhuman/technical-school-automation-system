using System.ComponentModel.DataAnnotations;

namespace Application.Common.Data;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class MyMinLengthAttribute : MinLengthAttribute
{
    public MyMinLengthAttribute(int length): base(length)
    {
        ErrorMessageResourceName = "MinLengthAttribute_ValidationError";
        ErrorMessageResourceType = typeof(Resources.Resource);
    }
}