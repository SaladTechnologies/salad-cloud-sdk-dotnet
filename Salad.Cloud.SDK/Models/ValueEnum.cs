namespace Salad.Cloud.SDK.Models;

/// <summary>
/// Emulates an enum for a given type.
/// </summary>
public abstract record ValueEnum<T>
{
    public T Value { get; internal init; }

    internal ValueEnum(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }
}
