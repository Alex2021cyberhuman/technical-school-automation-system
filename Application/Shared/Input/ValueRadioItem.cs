namespace Application.Shared.Input;

public class ValueRadioItem<TValue>
{
    public ValueRadioItem(string label, TValue value)
    {
        Label = label;
        Value = value;
    }

    public string Label { get; set; }

    public TValue Value { get; set; }

    public static implicit operator ValueRadioItem<TValue>((string, TValue) tuple)
    {
        return new ValueRadioItem<TValue>(tuple.Item1, tuple.Item2);
    }
}