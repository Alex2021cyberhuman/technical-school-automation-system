namespace Application.Shared.Input;

public class OptionItem<TCheck>
{
    public OptionItem(string label, TCheck value, bool optionChecked)
    {
        Label = label;
        Value = value;
        OptionChecked = optionChecked;
    }

    public string Label { get; set; }

    public TCheck Value { get; set; }

    public bool OptionChecked { get; set; }
}