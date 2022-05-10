// ReSharper disable once CheckNamespace

namespace DocumentFormat.OpenXml.Wordprocessing;

public static class RunExtensions
{
    public static Run MakePhoneRun(this string? phoneString)
    {
        const string spaces = "                              ";
        var run = new Run();

        var runProperties = new RunProperties();
        var fontSize = new FontSize { Val = "24" };
        var fontSizeComplexScript = new FontSizeComplexScript { Val = "24" };
        var underline = new Underline { Val = UnderlineValues.Single };
        var languages = new Languages { Val = "en-US" };

        runProperties.Append(fontSize);
        runProperties.Append(fontSizeComplexScript);
        runProperties.Append(underline);
        runProperties.Append(languages);
        var point = string.IsNullOrWhiteSpace(phoneString) ? spaces : phoneString;
        var text = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = point
        };

        run.Append(runProperties);
        run.Append(text);
        return run;
    }
}