using Application.AdmissionCommittee.Services.StatementDocument;

// ReSharper disable once CheckNamespace
namespace DocumentFormat.OpenXml.Wordprocessing;

public static class TableExtensions
{
    public static void AddSpecialityTableCell(this TableRow row,
        StatementDocumentModel.SpecialityModel? specialityModel)
    {
        var tableCell = new TableCell();

        var tableCellProperties = new TableCellProperties();
        var tableCellWidth = new TableCellWidth { Width = "715", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders = new TableCellBorders();

        tableCellProperties.Append(tableCellWidth);
        tableCellProperties.Append(tableCellBorders);

        var paragraph = new Paragraph();

        var paragraphProperties = new ParagraphProperties();
        var paragraphStyleId = new ParagraphStyleId { Val = "TableBody" };
        var widowControl = new WidowControl { Val = false };
        var spacingBetweenLines = new SpacingBetweenLines { Before = "0", After = "0" };
        var justification = new Justification() { Val = JustificationValues.End };

        var paragraphMarkRunProperties = new ParagraphMarkRunProperties();
        var runFonts = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize = new FontSize { Val = "20" };
        var fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        paragraphMarkRunProperties.Append(runFonts);
        paragraphMarkRunProperties.Append(fontSize);
        paragraphMarkRunProperties.Append(fontSizeComplexScript);

        paragraphProperties.Append(paragraphStyleId);
        paragraphProperties.Append(widowControl);
        paragraphProperties.Append(paragraphMarkRunProperties);
        paragraphProperties.Append(spacingBetweenLines);
        paragraphProperties.Append(justification);

        var run = new Run();

        var runProperties = new RunProperties();
        fontSize = new FontSize { Val = "20" };
        fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        runProperties.Append(fontSize);
        runProperties.Append(fontSizeComplexScript);
        var text = new Text
        {
            Text = specialityModel?.Selection ?? string.Empty
        };

        run.Append(runProperties);
        run.Append(text);

        paragraph.Append(paragraphProperties);
        paragraph.Append(run);

        tableCell.Append(tableCellProperties);
        tableCell.Append(paragraph);
        row.Append(tableCell);

        tableCell = new TableCell();

        tableCellProperties = new TableCellProperties();
        tableCellWidth = new TableCellWidth { Width = "102", Type = TableWidthUnitValues.Dxa };
        tableCellBorders = new TableCellBorders();

        tableCellProperties.Append(tableCellWidth);
        tableCellProperties.Append(tableCellBorders);

        paragraph = new Paragraph();

        paragraphProperties = new ParagraphProperties();
        paragraphStyleId = new ParagraphStyleId { Val = "TableBody" };
        widowControl = new WidowControl { Val = false };
        spacingBetweenLines = new SpacingBetweenLines { Before = "0", After = "0" };

        paragraphMarkRunProperties = new ParagraphMarkRunProperties();
        runFonts = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        fontSize = new FontSize { Val = "20" };
        fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        paragraphMarkRunProperties.Append(runFonts);
        paragraphMarkRunProperties.Append(fontSize);
        paragraphMarkRunProperties.Append(fontSizeComplexScript);

        paragraphProperties.Append(paragraphStyleId);
        paragraphProperties.Append(widowControl);
        paragraphProperties.Append(paragraphMarkRunProperties);
        paragraphProperties.Append(spacingBetweenLines);

        run = new Run();

        runProperties = new RunProperties();
        fontSize = new FontSize { Val = "20" };
        fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        runProperties.Append(fontSize);
        runProperties.Append(fontSizeComplexScript);
        text = new Text
        {
            Text = specialityModel?.Code ?? string.Empty
        };

        run.Append(runProperties);
        run.Append(text);

        paragraph.Append(paragraphProperties);
        paragraph.Append(run);

        tableCell.Append(tableCellProperties);
        tableCell.Append(paragraph);
        row.Append(tableCell);

        tableCell = new TableCell();

        tableCellProperties = new TableCellProperties();
        tableCellWidth = new TableCellWidth { Width = "3371", Type = TableWidthUnitValues.Dxa };
        tableCellBorders = new TableCellBorders();

        tableCellProperties.Append(tableCellWidth);
        tableCellProperties.Append(tableCellBorders);

        paragraph = new Paragraph();

        paragraphProperties = new ParagraphProperties();
        paragraphStyleId = new ParagraphStyleId { Val = "TableBody" };
        widowControl = new WidowControl { Val = false };
        spacingBetweenLines = new SpacingBetweenLines { Before = "0", After = "0" };

        paragraphMarkRunProperties = new ParagraphMarkRunProperties();
        runFonts = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        fontSize = new FontSize { Val = "20" };
        fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        paragraphMarkRunProperties.Append(runFonts);
        paragraphMarkRunProperties.Append(fontSize);
        paragraphMarkRunProperties.Append(fontSizeComplexScript);

        paragraphProperties.Append(paragraphStyleId);
        paragraphProperties.Append(widowControl);
        paragraphProperties.Append(paragraphMarkRunProperties);
        paragraphProperties.Append(spacingBetweenLines);

        run = new Run();

        runProperties = new RunProperties();
        fontSize = new FontSize { Val = "20" };
        fontSizeComplexScript = new FontSizeComplexScript { Val = "20" };

        runProperties.Append(fontSize);
        runProperties.Append(fontSizeComplexScript);
        text = new Text
        {
            Text = specialityModel?.Name ?? string.Empty
        };

        run.Append(runProperties);
        run.Append(text);

        paragraph.Append(paragraphProperties);
        paragraph.Append(run);

        tableCell.Append(tableCellProperties);
        tableCell.Append(paragraph);
        row.Append(tableCell);
    }
}