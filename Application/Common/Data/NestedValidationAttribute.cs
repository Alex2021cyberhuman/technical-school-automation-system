using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Application.Common.Data;

[AttributeUsage(AttributeTargets.Property |
                AttributeTargets.Field |
                AttributeTargets.Parameter)]
public class NestedValidationAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
    {
        if (value is null) return null;

        if (value is IEnumerable values)
            foreach (var item in values)
            {
                var enumerableContext = new ValidationContext(item)
                {
                    DisplayName = validationContext.DisplayName,
                    MemberName = validationContext.MemberName
                };
                var itemResults = new List<ValidationResult>();
                _ = Validator.TryValidateObject(item, enumerableContext, itemResults);
                return itemResults.FirstOrDefault();
            }

        var newContext = new ValidationContext(value)
        {
            DisplayName = validationContext.DisplayName,
            MemberName = validationContext.MemberName
        };
        var results = new List<ValidationResult>();
        _ = Validator.TryValidateObject(value, newContext, results);
        return results.FirstOrDefault();
    }
}