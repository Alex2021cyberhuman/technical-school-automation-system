using System.ComponentModel.DataAnnotations;

namespace Application.Common.Data;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class MyMaxLengthAttribute : MaxLengthAttribute
{
    public MyMaxLengthAttribute(int length) : base(length)
    {
        ErrorMessageResourceName = "MaxLengthAttribute_ValidationError";
        ErrorMessageResourceType = typeof(Resources.Resource);
    }
}