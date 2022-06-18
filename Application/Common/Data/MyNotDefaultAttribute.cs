namespace Application.Common.Data;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class MyNotDefaultAttribute : MyRequiredAttribute
{
    private static readonly Dictionary<Type, object> CommonTypeDictionary = new()
    {
        { typeof(int), default(int) },
        { typeof(Guid), default(Guid) },
        { typeof(DateOnly), default(DateOnly) },
        { typeof(DateTime), default(DateTime) },
        { typeof(DateTimeOffset), default(DateTimeOffset) },
        { typeof(TimeOnly), default(TimeOnly) },
        { typeof(long), default(long) },
        { typeof(bool), default(bool) },
        { typeof(double), default(double) },
        { typeof(short), default(short) },
        { typeof(float), default(float) },
        { typeof(byte), default(byte) },
        { typeof(char), default(char) },
        { typeof(uint), default(uint) },
        { typeof(ushort), default(ushort) },
        { typeof(ulong), default(ulong) },
        { typeof(sbyte), default(sbyte) }
    };

    public MyNotDefaultAttribute(Type type) : base()
    {
        DefaultValue = GetDefaultValue(type);
    }

    private object? DefaultValue { get; }

    public override bool IsValid(object? value)
    {
        return base.IsValid(value) && value != null && value != DefaultValue;
    }

    private static object? GetDefaultValue(Type type)
    {
        if (!type.IsValueType) return null;

        // A bit of perf code to avoid calling Activator.CreateInstance for common types and
        // to avoid boxing on every call. This is about 50% faster than just calling CreateInstance
        // for all value types.
        return CommonTypeDictionary.TryGetValue(type, out var value)
            ? value
            : Activator.CreateInstance(type);
    }
}