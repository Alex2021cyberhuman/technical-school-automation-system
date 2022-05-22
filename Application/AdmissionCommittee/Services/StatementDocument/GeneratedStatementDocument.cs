using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Op = DocumentFormat.OpenXml.CustomProperties;

namespace Application.AdmissionCommittee.Services.StatementDocument;

public class GeneratedStatementDocument
{
    private readonly StatementDocumentModel _model;

    // Creates a WordprocessingDocument.
    public GeneratedStatementDocument(StatementDocumentModel model)
    {
        this._model = model;
    }

    public async Task<long> CreateAsync(string filePath)
    {
        await using var fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        using var package = WordprocessingDocument.Create(fileStream, WordprocessingDocumentType.Document);
        CreateParts(package);
        await fileStream.FlushAsync();
        var length = fileStream.Length;
        return length;
    }

    // Adds child parts and generates content of the specified part.
    private void CreateParts(WordprocessingDocument document)
    {
        var extendedPart1 =
            document.AddExtendedPart(
                "http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties",
                "application/vnd.openxmlformats-package.core-properties+xml", "xml", "rId1");
        GenerateExtendedPart1Content(extendedPart1);

        var extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId2");
        GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

        var customFilePropertiesPart1 = document.AddNewPart<CustomFilePropertiesPart>("rId3");
        GenerateCustomFilePropertiesPart1Content(customFilePropertiesPart1);

        var mainDocumentPart1 = document.AddMainDocumentPart();
        GenerateMainDocumentPart1Content(mainDocumentPart1);

        var styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId1");
        GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

        var fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId2");
        GenerateFontTablePart1Content(fontTablePart1);

        var documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId3");
        GenerateDocumentSettingsPart1Content(documentSettingsPart1);
    }

    // Generates content of extendedPart1.
    private void GenerateExtendedPart1Content(ExtendedPart extendedPart1)
    {
        var data = GetBinaryDataStream(extendedPart1Data);
        extendedPart1.FeedData(data);
        data.Close();
    }

    // Generates content of extendedFilePropertiesPart1.
    private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
    {
        var properties1 = new Ap.Properties();
        properties1.AddNamespaceDeclaration("vt",
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
        var template1 = new Ap.Template
        {
            Text = "Normal_x005F_x0000_"
        };
        var totalTime1 = new Ap.TotalTime
        {
            Text = "154"
        };
        var application1 = new Ap.Application
        {
            Text = "TechnicalSchoolAutomationSystem"
        };
        var applicationVersion1 = new Ap.ApplicationVersion
        {
            Text = "0.1"
        };
        var pages1 = new Ap.Pages
        {
            Text = "2"
        };
        var words1 = new Ap.Words
        {
            Text = "349"
        };
        var characters1 = new Ap.Characters
        {
            Text = "2741"
        };
        var charactersWithSpaces1 = new Ap.CharactersWithSpaces
        {
            Text = "3038"
        };
        var paragraphs1 = new Ap.Paragraphs
        {
            Text = "78"
        };

        properties1.Append(template1);
        properties1.Append(totalTime1);
        properties1.Append(application1);
        properties1.Append(applicationVersion1);
        properties1.Append(pages1);
        properties1.Append(words1);
        properties1.Append(characters1);
        properties1.Append(charactersWithSpaces1);
        properties1.Append(paragraphs1);

        extendedFilePropertiesPart1.Properties = properties1;
    }

    // Generates content of customFilePropertiesPart1.
    private void GenerateCustomFilePropertiesPart1Content(CustomFilePropertiesPart customFilePropertiesPart1)
    {
        var properties2 = new Op.Properties();
        properties2.AddNamespaceDeclaration("vt",
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");

        customFilePropertiesPart1.Properties = properties2;
    }

    // Generates content of mainDocumentPart1.
    private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
    {
        var document1 = new Document
        { MCAttributes = new MarkupCompatibilityAttributes { Ignorable = "w14 wp14 w15" } };
        document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
        document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
        document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
        document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
        document1.AddNamespaceDeclaration("wp",
            "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
        document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");
        document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
        document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
        document1.AddNamespaceDeclaration("wp14",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
        document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
        document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");

        var body1 = new Body();

        var table1 = new Table();

        var tableProperties1 = new TableProperties();
        var tableWidth1 = new TableWidth { Width = "10031", Type = TableWidthUnitValues.Dxa };
        var tableJustification1 = new TableJustification
        { Val = new EnumValue<TableRowAlignmentValues> { InnerText = "start" } };
        var tableIndentation1 = new TableIndentation { Width = 0, Type = TableWidthUnitValues.Dxa };
        var tableLayout1 = new TableLayout { Type = TableLayoutValues.Fixed };

        var tableCellMarginDefault1 = new TableCellMarginDefault();
        var topMargin1 = new TopMargin { Width = "0", Type = TableWidthUnitValues.Dxa };
        var startMargin1 = new StartMargin { Width = "108", Type = TableWidthUnitValues.Dxa };
        var bottomMargin1 = new BottomMargin { Width = "0", Type = TableWidthUnitValues.Dxa };
        var endMargin1 = new EndMargin { Width = "108", Type = TableWidthUnitValues.Dxa };

        tableCellMarginDefault1.Append(topMargin1);
        tableCellMarginDefault1.Append(startMargin1);
        tableCellMarginDefault1.Append(bottomMargin1);
        tableCellMarginDefault1.Append(endMargin1);

        tableProperties1.Append(tableWidth1);
        tableProperties1.Append(tableJustification1);
        tableProperties1.Append(tableIndentation1);
        tableProperties1.Append(tableLayout1);
        tableProperties1.Append(tableCellMarginDefault1);

        var tableGrid1 = new TableGrid();
        var gridColumn1 = new GridColumn { Width = "4784" };
        var gridColumn2 = new GridColumn { Width = "5246" };

        tableGrid1.Append(gridColumn1);
        tableGrid1.Append(gridColumn2);

        var tableRow1 = new TableRow();
        var tableRowProperties1 = new TableRowProperties();

        var tableCell1 = new TableCell();

        var tableCellProperties1 = new TableCellProperties();
        var tableCellWidth1 = new TableCellWidth { Width = "4784", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders1 = new TableCellBorders();

        tableCellProperties1.Append(tableCellWidth1);
        tableCellProperties1.Append(tableCellBorders1);

        var paragraph1 = new Paragraph();

        var paragraphProperties1 = new ParagraphProperties();
        var paragraphStyleId1 = new ParagraphStyleId { Val = "MainBody" };
        var widowControl1 = new WidowControl { Val = false };

        var paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
        var runFonts1 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize1 = new FontSize { Val = "24" };
        var fontSizeComplexScript1 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties1.Append(runFonts1);
        paragraphMarkRunProperties1.Append(fontSize1);
        paragraphMarkRunProperties1.Append(fontSizeComplexScript1);

        paragraphProperties1.Append(paragraphStyleId1);
        paragraphProperties1.Append(widowControl1);
        paragraphProperties1.Append(paragraphMarkRunProperties1);

        var run1 = new Run();

        var runProperties1 = new RunProperties();
        var fontSize2 = new FontSize { Val = "24" };
        var fontSizeComplexScript2 = new FontSizeComplexScript { Val = "24" };

        runProperties1.Append(fontSize2);
        runProperties1.Append(fontSizeComplexScript2);

        run1.Append(runProperties1);

        paragraph1.Append(paragraphProperties1);
        paragraph1.Append(run1);

        tableCell1.Append(tableCellProperties1);
        tableCell1.Append(paragraph1);

        var tableCell2 = new TableCell();

        var tableCellProperties2 = new TableCellProperties();
        var tableCellWidth2 = new TableCellWidth { Width = "5246", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders2 = new TableCellBorders();

        tableCellProperties2.Append(tableCellWidth2);
        tableCellProperties2.Append(tableCellBorders2);

        var paragraph2 = new Paragraph();

        var paragraphProperties2 = new ParagraphProperties();
        var paragraphStyleId2 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl2 = new WidowControl { Val = false };

        var paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
        var runFonts2 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize3 = new FontSize { Val = "24" };
        var fontSizeComplexScript3 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties2.Append(runFonts2);
        paragraphMarkRunProperties2.Append(fontSize3);
        paragraphMarkRunProperties2.Append(fontSizeComplexScript3);

        paragraphProperties2.Append(paragraphStyleId2);
        paragraphProperties2.Append(widowControl2);
        paragraphProperties2.Append(paragraphMarkRunProperties2);

        var run2 = new Run();

        var runProperties2 = new RunProperties();
        var fontSize4 = new FontSize { Val = "24" };
        var fontSizeComplexScript4 = new FontSizeComplexScript { Val = "24" };

        runProperties2.Append(fontSize4);
        runProperties2.Append(fontSizeComplexScript4);

        run2.Append(runProperties2);

        paragraph2.Append(paragraphProperties2);
        paragraph2.Append(run2);

        tableCell2.Append(tableCellProperties2);
        tableCell2.Append(paragraph2);

        tableRow1.Append(tableRowProperties1);
        tableRow1.Append(tableCell1);
        tableRow1.Append(tableCell2);

        var tableRow2 = new TableRow();
        var tableRowProperties2 = new TableRowProperties();

        var tableCell3 = new TableCell();

        var tableCellProperties3 = new TableCellProperties();
        var tableCellWidth3 = new TableCellWidth { Width = "4784", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders3 = new TableCellBorders();

        tableCellProperties3.Append(tableCellWidth3);
        tableCellProperties3.Append(tableCellBorders3);

        var paragraph3 = new Paragraph();

        var paragraphProperties3 = new ParagraphProperties();
        var paragraphStyleId3 = new ParagraphStyleId { Val = "MainBody" };
        var widowControl3 = new WidowControl { Val = false };

        var paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
        var runFonts3 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize5 = new FontSize { Val = "24" };
        var fontSizeComplexScript5 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties3.Append(runFonts3);
        paragraphMarkRunProperties3.Append(fontSize5);
        paragraphMarkRunProperties3.Append(fontSizeComplexScript5);

        paragraphProperties3.Append(paragraphStyleId3);
        paragraphProperties3.Append(widowControl3);
        paragraphProperties3.Append(paragraphMarkRunProperties3);

        var run3 = new Run();

        var runProperties3 = new RunProperties();
        var fontSize6 = new FontSize { Val = "24" };
        var fontSizeComplexScript6 = new FontSizeComplexScript { Val = "24" };

        runProperties3.Append(fontSize6);
        runProperties3.Append(fontSizeComplexScript6);

        run3.Append(runProperties3);

        paragraph3.Append(paragraphProperties3);
        paragraph3.Append(run3);

        tableCell3.Append(tableCellProperties3);
        tableCell3.Append(paragraph3);

        var tableCell4 = new TableCell();

        var tableCellProperties4 = new TableCellProperties();
        var tableCellWidth4 = new TableCellWidth { Width = "5246", Type = TableWidthUnitValues.Dxa };
        var verticalMerge1 = new VerticalMerge { Val = MergedCellValues.Restart };
        var tableCellBorders4 = new TableCellBorders();

        tableCellProperties4.Append(tableCellWidth4);
        tableCellProperties4.Append(verticalMerge1);
        tableCellProperties4.Append(tableCellBorders4);

        var paragraph4 = new Paragraph();

        var paragraphProperties4 = new ParagraphProperties();
        var paragraphStyleId4 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl4 = new WidowControl { Val = false };

        var paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
        var runFonts4 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize7 = new FontSize { Val = "24" };
        var fontSizeComplexScript7 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties4.Append(runFonts4);
        paragraphMarkRunProperties4.Append(fontSize7);
        paragraphMarkRunProperties4.Append(fontSizeComplexScript7);

        paragraphProperties4.Append(paragraphStyleId4);
        paragraphProperties4.Append(widowControl4);
        paragraphProperties4.Append(paragraphMarkRunProperties4);

        var run4 = new Run();

        var runProperties4 = new RunProperties();
        var fontSize8 = new FontSize { Val = "24" };
        var fontSizeComplexScript8 = new FontSizeComplexScript { Val = "24" };

        runProperties4.Append(fontSize8);
        runProperties4.Append(fontSizeComplexScript8);
        var text1 = new Text
        {
            Text = "В приказ к зачислению"
        };

        run4.Append(runProperties4);
        run4.Append(text1);

        paragraph4.Append(paragraphProperties4);
        paragraph4.Append(run4);

        var paragraph5 = new Paragraph();

        var paragraphProperties5 = new ParagraphProperties();
        var paragraphStyleId5 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl5 = new WidowControl { Val = false };

        var paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
        var runFonts5 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize9 = new FontSize { Val = "24" };
        var fontSizeComplexScript9 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties5.Append(runFonts5);
        paragraphMarkRunProperties5.Append(fontSize9);
        paragraphMarkRunProperties5.Append(fontSizeComplexScript9);

        paragraphProperties5.Append(paragraphStyleId5);
        paragraphProperties5.Append(widowControl5);
        paragraphProperties5.Append(paragraphMarkRunProperties5);

        var run5 = new Run();

        var runProperties5 = new RunProperties();
        var fontSize10 = new FontSize { Val = "24" };
        var fontSizeComplexScript10 = new FontSizeComplexScript { Val = "24" };

        runProperties5.Append(fontSize10);
        runProperties5.Append(fontSizeComplexScript10);
        var text2 = new Text
        {
            Text = "Директор ГАПОУ ОНТ"
        };

        run5.Append(runProperties5);
        run5.Append(text2);

        paragraph5.Append(paragraphProperties5);
        paragraph5.Append(run5);

        var paragraph6 = new Paragraph();

        var paragraphProperties6 = new ParagraphProperties();
        var paragraphStyleId6 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl6 = new WidowControl { Val = false };

        var paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
        var runFonts6 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize11 = new FontSize { Val = "24" };
        var fontSizeComplexScript11 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties6.Append(runFonts6);
        paragraphMarkRunProperties6.Append(fontSize11);
        paragraphMarkRunProperties6.Append(fontSizeComplexScript11);

        paragraphProperties6.Append(paragraphStyleId6);
        paragraphProperties6.Append(widowControl6);
        paragraphProperties6.Append(paragraphMarkRunProperties6);

        var run6 = new Run();

        var runProperties6 = new RunProperties();
        var fontSize12 = new FontSize { Val = "24" };
        var fontSizeComplexScript12 = new FontSizeComplexScript { Val = "24" };

        runProperties6.Append(fontSize12);
        runProperties6.Append(fontSizeComplexScript12);
        var text3 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run6.Append(runProperties6);
        run6.Append(text3);

        var run7 = new Run();

        var runProperties7 = new RunProperties();
        var fontSize13 = new FontSize { Val = "24" };
        var fontSizeComplexScript13 = new FontSizeComplexScript { Val = "24" };

        runProperties7.Append(fontSize13);
        runProperties7.Append(fontSizeComplexScript13);
        var text4 = new Text
        {
            Text = "им. В.А.Сорокина"
        };

        run7.Append(runProperties7);
        run7.Append(text4);

        paragraph6.Append(paragraphProperties6);
        paragraph6.Append(run6);
        paragraph6.Append(run7);

        var paragraph7 = new Paragraph();

        var paragraphProperties7 = new ParagraphProperties();
        var paragraphStyleId7 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl7 = new WidowControl { Val = false };

        var paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
        var runFonts7 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize14 = new FontSize { Val = "24" };
        var fontSizeComplexScript14 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties7.Append(runFonts7);
        paragraphMarkRunProperties7.Append(fontSize14);
        paragraphMarkRunProperties7.Append(fontSizeComplexScript14);

        paragraphProperties7.Append(paragraphStyleId7);
        paragraphProperties7.Append(widowControl7);
        paragraphProperties7.Append(paragraphMarkRunProperties7);

        var run8 = new Run();

        var runProperties8 = new RunProperties();
        var fontSize15 = new FontSize { Val = "24" };
        var fontSizeComplexScript15 = new FontSizeComplexScript { Val = "24" };

        runProperties8.Append(fontSize15);
        runProperties8.Append(fontSizeComplexScript15);
        var text5 = new Text
        {
            Text = "_____________ Т.Б.Кочеткова"
        };

        run8.Append(runProperties8);
        run8.Append(text5);

        paragraph7.Append(paragraphProperties7);
        paragraph7.Append(run8);

        var paragraph8 = new Paragraph();

        var paragraphProperties8 = new ParagraphProperties();
        var paragraphStyleId8 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl8 = new WidowControl { Val = false };

        var paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
        var runFonts8 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize16 = new FontSize { Val = "24" };
        var fontSizeComplexScript16 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties8.Append(runFonts8);
        paragraphMarkRunProperties8.Append(fontSize16);
        paragraphMarkRunProperties8.Append(fontSizeComplexScript16);

        paragraphProperties8.Append(paragraphStyleId8);
        paragraphProperties8.Append(widowControl8);
        paragraphProperties8.Append(paragraphMarkRunProperties8);

        var run9 = new Run();

        var runProperties9 = new RunProperties();
        var fontSize17 = new FontSize { Val = "24" };
        var fontSizeComplexScript17 = new FontSizeComplexScript { Val = "24" };
        var underline1 = new Underline { Val = UnderlineValues.Single };
        var languages1 = new Languages { Val = "en-US" };

        runProperties9.Append(fontSize17);
        runProperties9.Append(fontSizeComplexScript17);
        runProperties9.Append(underline1);
        runProperties9.Append(languages1);
        var text6 = new Text
        {
            Text = _model.NowDay
        };

        run9.Append(runProperties9);
        run9.Append(text6);

        var run10 = new Run();

        var runProperties10 = new RunProperties();
        var fontSize18 = new FontSize { Val = "24" };
        var fontSizeComplexScript18 = new FontSizeComplexScript { Val = "24" };
        var underline2 = new Underline { Val = UnderlineValues.None };
        var languages2 = new Languages { Val = "en-US" };

        runProperties10.Append(fontSize18);
        runProperties10.Append(fontSizeComplexScript18);
        runProperties10.Append(underline2);
        runProperties10.Append(languages2);
        var text7 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run10.Append(runProperties10);
        run10.Append(text7);

        var run11 = new Run();

        var runProperties11 = new RunProperties();
        var strike1 = new Strike { Val = false };
        var doubleStrike1 = new DoubleStrike { Val = false };
        var fontSize19 = new FontSize { Val = "24" };
        var fontSizeComplexScript19 = new FontSizeComplexScript { Val = "24" };
        var underline3 = new Underline { Val = UnderlineValues.Single };
        var languages3 = new Languages { Val = "en-US" };

        runProperties11.Append(strike1);
        runProperties11.Append(doubleStrike1);
        runProperties11.Append(fontSize19);
        runProperties11.Append(fontSizeComplexScript19);
        runProperties11.Append(underline3);
        runProperties11.Append(languages3);
        var text8 = new Text
        {
            Text = _model.NowMonth
        };

        run11.Append(runProperties11);
        run11.Append(text8);

        var run12 = new Run();

        var runProperties12 = new RunProperties();
        var strike2 = new Strike { Val = false };
        var doubleStrike2 = new DoubleStrike { Val = false };
        var fontSize20 = new FontSize { Val = "24" };
        var fontSizeComplexScript20 = new FontSizeComplexScript { Val = "24" };
        var underline4 = new Underline { Val = UnderlineValues.None };
        var languages4 = new Languages { Val = "en-US" };

        runProperties12.Append(strike2);
        runProperties12.Append(doubleStrike2);
        runProperties12.Append(fontSize20);
        runProperties12.Append(fontSizeComplexScript20);
        runProperties12.Append(underline4);
        runProperties12.Append(languages4);
        var text9 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run12.Append(runProperties12);
        run12.Append(text9);

        var run13 = new Run();

        var runProperties13 = new RunProperties();
        var fontSize21 = new FontSize { Val = "24" };
        var fontSizeComplexScript21 = new FontSizeComplexScript { Val = "24" };

        runProperties13.Append(fontSize21);
        runProperties13.Append(fontSizeComplexScript21);
        var text10 = new Text
        {
            Text = _model.NowYear
        };

        run13.Append(runProperties13);
        run13.Append(text10);

        paragraph8.Append(paragraphProperties8);
        paragraph8.Append(run9);
        paragraph8.Append(run10);
        paragraph8.Append(run11);
        paragraph8.Append(run12);
        paragraph8.Append(run13);

        tableCell4.Append(tableCellProperties4);
        tableCell4.Append(paragraph4);
        tableCell4.Append(paragraph5);
        tableCell4.Append(paragraph6);
        tableCell4.Append(paragraph7);
        tableCell4.Append(paragraph8);

        tableRow2.Append(tableRowProperties2);
        tableRow2.Append(tableCell3);
        tableRow2.Append(tableCell4);

        var tableRow3 = new TableRow();
        var tableRowProperties3 = new TableRowProperties();

        var tableCell5 = new TableCell();

        var tableCellProperties5 = new TableCellProperties();
        var tableCellWidth5 = new TableCellWidth { Width = "4784", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders5 = new TableCellBorders();

        tableCellProperties5.Append(tableCellWidth5);
        tableCellProperties5.Append(tableCellBorders5);

        var paragraph9 = new Paragraph();

        var paragraphProperties9 = new ParagraphProperties();
        var paragraphStyleId9 = new ParagraphStyleId { Val = "MainBody" };
        var widowControl9 = new WidowControl { Val = false };

        var paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
        var runFonts9 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize22 = new FontSize { Val = "24" };
        var fontSizeComplexScript22 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties9.Append(runFonts9);
        paragraphMarkRunProperties9.Append(fontSize22);
        paragraphMarkRunProperties9.Append(fontSizeComplexScript22);

        paragraphProperties9.Append(paragraphStyleId9);
        paragraphProperties9.Append(widowControl9);
        paragraphProperties9.Append(paragraphMarkRunProperties9);

        var run14 = new Run();

        var runProperties14 = new RunProperties();
        var fontSize23 = new FontSize { Val = "24" };
        var fontSizeComplexScript23 = new FontSizeComplexScript { Val = "24" };
        var underline5 = new Underline { Val = UnderlineValues.Single };
        var languages5 = new Languages { Val = "en-US" };

        runProperties14.Append(fontSize23);
        runProperties14.Append(fontSizeComplexScript23);
        runProperties14.Append(underline5);
        runProperties14.Append(languages5);
        var text11 = new Text
        {
            Text = _model.NowDay
        };

        run14.Append(runProperties14);
        run14.Append(text11);

        var run15 = new Run();

        var runProperties15 = new RunProperties();
        var fontSize24 = new FontSize { Val = "24" };
        var fontSizeComplexScript24 = new FontSizeComplexScript { Val = "24" };

        runProperties15.Append(fontSize24);
        runProperties15.Append(fontSizeComplexScript24);
        var text12 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run15.Append(runProperties15);
        run15.Append(text12);

        var run16 = new Run();

        var runProperties16 = new RunProperties();
        var strike3 = new Strike { Val = false };
        var doubleStrike3 = new DoubleStrike { Val = false };
        var fontSize25 = new FontSize { Val = "24" };
        var fontSizeComplexScript25 = new FontSizeComplexScript { Val = "24" };
        var underline6 = new Underline { Val = UnderlineValues.Single };
        var languages6 = new Languages { Val = "en-US" };

        runProperties16.Append(strike3);
        runProperties16.Append(doubleStrike3);
        runProperties16.Append(fontSize25);
        runProperties16.Append(fontSizeComplexScript25);
        runProperties16.Append(underline6);
        runProperties16.Append(languages6);
        var text13 = new Text
        {
            Text = _model.NowMonth
        };

        run16.Append(runProperties16);
        run16.Append(text13);

        var run17 = new Run();

        var runProperties17 = new RunProperties();
        var strike4 = new Strike { Val = false };
        var doubleStrike4 = new DoubleStrike { Val = false };
        var fontSize26 = new FontSize { Val = "24" };
        var fontSizeComplexScript26 = new FontSizeComplexScript { Val = "24" };
        var underline7 = new Underline { Val = UnderlineValues.None };
        var languages7 = new Languages { Val = "en-US" };

        runProperties17.Append(strike4);
        runProperties17.Append(doubleStrike4);
        runProperties17.Append(fontSize26);
        runProperties17.Append(fontSizeComplexScript26);
        runProperties17.Append(underline7);
        runProperties17.Append(languages7);
        var text14 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run17.Append(runProperties17);
        run17.Append(text14);

        var run18 = new Run();

        var runProperties18 = new RunProperties();
        var fontSize27 = new FontSize { Val = "24" };
        var fontSizeComplexScript27 = new FontSizeComplexScript { Val = "24" };
        var languages8 = new Languages { Val = "en-US" };

        runProperties18.Append(fontSize27);
        runProperties18.Append(fontSizeComplexScript27);
        runProperties18.Append(languages8);
        var text15 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = _model.NowYear
        };

        run18.Append(runProperties18);
        run18.Append(text15);

        var run19 = new Run();

        var runProperties19 = new RunProperties();
        var fontSize28 = new FontSize { Val = "24" };
        var fontSizeComplexScript28 = new FontSizeComplexScript { Val = "24" };

        runProperties19.Append(fontSize28);
        runProperties19.Append(fontSizeComplexScript28);
        var text16 = new Text
        {
            Text = "г."
        };

        run19.Append(runProperties19);
        run19.Append(text16);

        paragraph9.Append(paragraphProperties9);
        paragraph9.Append(run14);
        paragraph9.Append(run15);
        paragraph9.Append(run16);
        paragraph9.Append(run17);
        paragraph9.Append(run18);
        paragraph9.Append(run19);

        tableCell5.Append(tableCellProperties5);
        tableCell5.Append(paragraph9);

        var tableCell6 = new TableCell();

        var tableCellProperties6 = new TableCellProperties();
        var tableCellWidth6 = new TableCellWidth { Width = "5246", Type = TableWidthUnitValues.Dxa };
        var verticalMerge2 = new VerticalMerge { Val = MergedCellValues.Continue };
        var tableCellBorders6 = new TableCellBorders();

        tableCellProperties6.Append(tableCellWidth6);
        tableCellProperties6.Append(verticalMerge2);
        tableCellProperties6.Append(tableCellBorders6);

        var paragraph10 = new Paragraph();

        var paragraphProperties10 = new ParagraphProperties();
        var paragraphStyleId10 = new ParagraphStyleId { Val = "MainBodyL" };
        var widowControl10 = new WidowControl { Val = false };

        var paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
        var runFonts10 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize29 = new FontSize { Val = "24" };
        var fontSizeComplexScript29 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties10.Append(runFonts10);
        paragraphMarkRunProperties10.Append(fontSize29);
        paragraphMarkRunProperties10.Append(fontSizeComplexScript29);

        paragraphProperties10.Append(paragraphStyleId10);
        paragraphProperties10.Append(widowControl10);
        paragraphProperties10.Append(paragraphMarkRunProperties10);

        var run20 = new Run();

        var runProperties20 = new RunProperties();
        var fontSize30 = new FontSize { Val = "24" };
        var fontSizeComplexScript30 = new FontSizeComplexScript { Val = "24" };

        runProperties20.Append(fontSize30);
        runProperties20.Append(fontSizeComplexScript30);

        run20.Append(runProperties20);

        paragraph10.Append(paragraphProperties10);
        paragraph10.Append(run20);

        tableCell6.Append(tableCellProperties6);
        tableCell6.Append(paragraph10);

        tableRow3.Append(tableRowProperties3);
        tableRow3.Append(tableCell5);
        tableRow3.Append(tableCell6);

        var tableRow4 = new TableRow();

        var tableRowProperties4 = new TableRowProperties();
        var tableRowHeight1 = new TableRowHeight { Val = (UInt32Value)87U, HeightType = HeightRuleValues.AtLeast };

        tableRowProperties4.Append(tableRowHeight1);

        var tableCell7 = new TableCell();

        var tableCellProperties7 = new TableCellProperties();
        var tableCellWidth7 = new TableCellWidth { Width = "4784", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders7 = new TableCellBorders();

        tableCellProperties7.Append(tableCellWidth7);
        tableCellProperties7.Append(tableCellBorders7);

        var paragraph11 = new Paragraph();

        var paragraphProperties11 = new ParagraphProperties();
        var paragraphStyleId11 = new ParagraphStyleId { Val = "Normal" };
        var widowControl11 = new WidowControl { Val = false };
        var snapToGrid1 = new SnapToGrid { Val = false };

        var paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
        var runFonts11 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize31 = new FontSize { Val = "24" };
        var fontSizeComplexScript31 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties11.Append(runFonts11);
        paragraphMarkRunProperties11.Append(fontSize31);
        paragraphMarkRunProperties11.Append(fontSizeComplexScript31);

        paragraphProperties11.Append(paragraphStyleId11);
        paragraphProperties11.Append(widowControl11);
        paragraphProperties11.Append(snapToGrid1);
        paragraphProperties11.Append(paragraphMarkRunProperties11);

        var run21 = new Run();

        var runProperties21 = new RunProperties();
        var fontSize32 = new FontSize { Val = "24" };
        var fontSizeComplexScript32 = new FontSizeComplexScript { Val = "24" };

        runProperties21.Append(fontSize32);
        runProperties21.Append(fontSizeComplexScript32);

        run21.Append(runProperties21);

        paragraph11.Append(paragraphProperties11);
        paragraph11.Append(run21);

        tableCell7.Append(tableCellProperties7);
        tableCell7.Append(paragraph11);

        var tableCell8 = new TableCell();

        var tableCellProperties8 = new TableCellProperties();
        var tableCellWidth8 = new TableCellWidth { Width = "5246", Type = TableWidthUnitValues.Dxa };
        var tableCellBorders8 = new TableCellBorders();

        tableCellProperties8.Append(tableCellWidth8);
        tableCellProperties8.Append(tableCellBorders8);

        var paragraph12 = new Paragraph();

        var paragraphProperties12 = new ParagraphProperties();
        var paragraphStyleId12 = new ParagraphStyleId { Val = "Normal" };
        var widowControl12 = new WidowControl { Val = false };
        var justification1 = new Justification { Val = JustificationValues.End };

        var paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
        var runFonts12 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize33 = new FontSize { Val = "24" };
        var fontSizeComplexScript33 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties12.Append(runFonts12);
        paragraphMarkRunProperties12.Append(fontSize33);
        paragraphMarkRunProperties12.Append(fontSizeComplexScript33);

        paragraphProperties12.Append(paragraphStyleId12);
        paragraphProperties12.Append(widowControl12);
        paragraphProperties12.Append(justification1);
        paragraphProperties12.Append(paragraphMarkRunProperties12);

        var run22 = new Run();

        var runProperties22 = new RunProperties();
        var fontSize34 = new FontSize { Val = "24" };
        var fontSizeComplexScript34 = new FontSizeComplexScript { Val = "24" };

        runProperties22.Append(fontSize34);
        runProperties22.Append(fontSizeComplexScript34);
        var text17 = new Text
        {
            Text = "."
        };

        run22.Append(runProperties22);
        run22.Append(text17);

        paragraph12.Append(paragraphProperties12);
        paragraph12.Append(run22);

        tableCell8.Append(tableCellProperties8);
        tableCell8.Append(paragraph12);

        tableRow4.Append(tableRowProperties4);
        tableRow4.Append(tableCell7);
        tableRow4.Append(tableCell8);

        table1.Append(tableProperties1);
        table1.Append(tableGrid1);
        table1.Append(tableRow1);
        table1.Append(tableRow2);
        table1.Append(tableRow3);
        table1.Append(tableRow4);

        var paragraph13 = new Paragraph();

        var paragraphProperties13 = new ParagraphProperties();
        var paragraphStyleId13 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
        var runFonts13 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize35 = new FontSize { Val = "24" };
        var fontSizeComplexScript35 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties13.Append(runFonts13);
        paragraphMarkRunProperties13.Append(fontSize35);
        paragraphMarkRunProperties13.Append(fontSizeComplexScript35);

        paragraphProperties13.Append(paragraphStyleId13);
        paragraphProperties13.Append(paragraphMarkRunProperties13);

        var run23 = new Run();

        var runProperties23 = new RunProperties();
        var fontSize36 = new FontSize { Val = "24" };
        var fontSizeComplexScript36 = new FontSizeComplexScript { Val = "24" };

        runProperties23.Append(fontSize36);
        runProperties23.Append(fontSizeComplexScript36);
        var text18 = new Text
        {
            Text = "Директору ГАПОУ «Орский нефтяной техникум им. Героя Советского Союза В.А. Сорокина»  Т.Б.Кочетковой"
        };

        run23.Append(runProperties23);
        run23.Append(text18);

        paragraph13.Append(paragraphProperties13);
        paragraph13.Append(run23);

        var paragraph14 = new Paragraph();

        var paragraphProperties14 = new ParagraphProperties();
        var paragraphStyleId14 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
        var runFonts14 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties14.Append(runFonts14);

        paragraphProperties14.Append(paragraphStyleId14);
        paragraphProperties14.Append(paragraphMarkRunProperties14);

        var run24 = new Run();

        var runProperties24 = new RunProperties();
        var languages9 = new Languages { Val = "ru-RU" };

        runProperties24.Append(languages9);
        var text19 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "от "
        };

        run24.Append(runProperties24);
        run24.Append(text19);

        var run25 = new Run();

        var runProperties25 = new RunProperties();
        var underline8 = new Underline { Val = UnderlineValues.Single };
        var languages10 = new Languages { Val = "en-US" };

        runProperties25.Append(underline8);
        runProperties25.Append(languages10);
        var text20 = new Text
        {
            Text = _model.FullName
        };
        var tabChar1 = new TabChar();

        run25.Append(runProperties25);
        run25.Append(text20);
        run25.Append(tabChar1);

        paragraph14.Append(paragraphProperties14);
        paragraph14.Append(run24);
        paragraph14.Append(run25);

        var paragraph15 = new Paragraph();

        var paragraphProperties15 = new ParagraphProperties();
        var paragraphStyleId15 = new ParagraphStyleId { Val = "FieldDescription" };

        var paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
        var runFonts15 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize37 = new FontSize { Val = "24" };
        var fontSizeComplexScript37 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties15.Append(runFonts15);
        paragraphMarkRunProperties15.Append(fontSize37);
        paragraphMarkRunProperties15.Append(fontSizeComplexScript37);

        paragraphProperties15.Append(paragraphStyleId15);
        paragraphProperties15.Append(paragraphMarkRunProperties15);

        var run26 = new Run();

        var runProperties26 = new RunProperties();
        var fontSize38 = new FontSize { Val = "24" };
        var fontSizeComplexScript38 = new FontSizeComplexScript { Val = "24" };

        runProperties26.Append(fontSize38);
        runProperties26.Append(fontSizeComplexScript38);
        var text21 = new Text
        {
            Text = "(фамилия, имя, отчество поступающего)"
        };

        run26.Append(runProperties26);
        run26.Append(text21);

        paragraph15.Append(paragraphProperties15);
        paragraph15.Append(run26);

        var paragraph16 = new Paragraph();

        var paragraphProperties16 = new ParagraphProperties();
        var paragraphStyleId16 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
        var runFonts16 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize39 = new FontSize { Val = "24" };
        var fontSizeComplexScript39 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties16.Append(runFonts16);
        paragraphMarkRunProperties16.Append(fontSize39);
        paragraphMarkRunProperties16.Append(fontSizeComplexScript39);

        paragraphProperties16.Append(paragraphStyleId16);
        paragraphProperties16.Append(paragraphMarkRunProperties16);

        var run27 = new Run();

        var runProperties27 = new RunProperties();
        var fontSize40 = new FontSize { Val = "24" };
        var fontSizeComplexScript40 = new FontSizeComplexScript { Val = "24" };

        runProperties27.Append(fontSize40);
        runProperties27.Append(fontSizeComplexScript40);
        var text22 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Дата "
        };

        run27.Append(runProperties27);
        run27.Append(text22);

        var run28 = new Run();

        var runProperties28 = new RunProperties();
        var fontSize41 = new FontSize { Val = "24" };
        var fontSizeComplexScript41 = new FontSizeComplexScript { Val = "24" };
        var languages11 = new Languages { Val = "en-US" };

        runProperties28.Append(fontSize41);
        runProperties28.Append(fontSizeComplexScript41);
        runProperties28.Append(languages11);
        var text23 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "рождения "
        };

        run28.Append(runProperties28);
        run28.Append(text23);

        var run29 = new Run();

        var runProperties29 = new RunProperties();
        var fontSize42 = new FontSize { Val = "24" };
        var fontSizeComplexScript42 = new FontSizeComplexScript { Val = "24" };
        var underline9 = new Underline { Val = UnderlineValues.Single };
        var languages12 = new Languages { Val = "en-US" };

        runProperties29.Append(fontSize42);
        runProperties29.Append(fontSizeComplexScript42);
        runProperties29.Append(underline9);
        runProperties29.Append(languages12);
        var text24 = new Text
        {
            Text = _model.DateOfBirthText
        };

        run29.Append(runProperties29);
        run29.Append(text24);

        paragraph16.Append(paragraphProperties16);
        paragraph16.Append(run27);
        paragraph16.Append(run28);
        paragraph16.Append(run29);

        var paragraph17 = new Paragraph();

        var paragraphProperties17 = new ParagraphProperties();
        var paragraphStyleId17 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
        var runFonts17 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize43 = new FontSize { Val = "24" };
        var fontSizeComplexScript43 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties17.Append(runFonts17);
        paragraphMarkRunProperties17.Append(fontSize43);
        paragraphMarkRunProperties17.Append(fontSizeComplexScript43);

        paragraphProperties17.Append(paragraphStyleId17);
        paragraphProperties17.Append(paragraphMarkRunProperties17);

        var run30 = new Run();

        var runProperties30 = new RunProperties();
        var fontSize44 = new FontSize { Val = "24" };
        var fontSizeComplexScript44 = new FontSizeComplexScript { Val = "24" };

        runProperties30.Append(fontSize44);
        runProperties30.Append(fontSizeComplexScript44);
        var text25 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Документ, удостоверяющий личность "
        };

        run30.Append(runProperties30);
        run30.Append(text25);

        var run31 = new Run();

        var runProperties31 = new RunProperties();
        var fontSize45 = new FontSize { Val = "24" };
        var fontSizeComplexScript45 = new FontSizeComplexScript { Val = "24" };
        var underline10 = new Underline { Val = UnderlineValues.Single };
        var languages13 = new Languages { Val = "en-US" };

        runProperties31.Append(fontSize45);
        runProperties31.Append(fontSizeComplexScript45);
        runProperties31.Append(underline10);
        runProperties31.Append(languages13);
        var text26 = new Text
        {
            Text = _model.PassportType
        };

        run31.Append(runProperties31);
        run31.Append(text26);

        var run32 = new Run();

        var runProperties32 = new RunProperties();
        var fontSize46 = new FontSize { Val = "24" };
        var fontSizeComplexScript46 = new FontSizeComplexScript { Val = "24" };
        var languages14 = new Languages { Val = "en-US" };

        runProperties32.Append(fontSize46);
        runProperties32.Append(fontSizeComplexScript46);
        runProperties32.Append(languages14);
        var text27 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run32.Append(runProperties32);
        run32.Append(text27);

        var run33 = new Run();

        var runProperties33 = new RunProperties();
        var fontSize47 = new FontSize { Val = "24" };
        var fontSizeComplexScript47 = new FontSizeComplexScript { Val = "24" };

        runProperties33.Append(fontSize47);
        runProperties33.Append(fontSizeComplexScript47);
        var text28 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "серия "
        };

        run33.Append(runProperties33);
        run33.Append(text28);

        var run34 = new Run();

        var runProperties34 = new RunProperties();
        var fontSize48 = new FontSize { Val = "24" };
        var fontSizeComplexScript48 = new FontSizeComplexScript { Val = "24" };
        var underline11 = new Underline { Val = UnderlineValues.Single };
        var languages15 = new Languages { Val = "en-US" };

        runProperties34.Append(fontSize48);
        runProperties34.Append(fontSizeComplexScript48);
        runProperties34.Append(underline11);
        runProperties34.Append(languages15);
        var text29 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = _model.PassportSerial
        };

        run34.Append(runProperties34);
        run34.Append(text29);

        var run35 = new Run();

        var runProperties35 = new RunProperties();
        var fontSize49 = new FontSize { Val = "24" };
        var fontSizeComplexScript49 = new FontSizeComplexScript { Val = "24" };

        runProperties35.Append(fontSize49);
        runProperties35.Append(fontSizeComplexScript49);
        var text30 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "№ "
        };

        run35.Append(runProperties35);
        run35.Append(text30);

        var run36 = new Run();

        var runProperties36 = new RunProperties();
        var fontSize50 = new FontSize { Val = "24" };
        var fontSizeComplexScript50 = new FontSizeComplexScript { Val = "24" };
        var underline12 = new Underline { Val = UnderlineValues.Single };
        var languages16 = new Languages { Val = "en-US" };

        runProperties36.Append(fontSize50);
        runProperties36.Append(fontSizeComplexScript50);
        runProperties36.Append(underline12);
        runProperties36.Append(languages16);
        var text31 = new Text
        {
            Text = _model.PassportNumber
        };

        run36.Append(runProperties36);
        run36.Append(text31);

        paragraph17.Append(paragraphProperties17);
        paragraph17.Append(run30);
        paragraph17.Append(run31);
        paragraph17.Append(run32);
        paragraph17.Append(run33);
        paragraph17.Append(run34);
        paragraph17.Append(run35);
        paragraph17.Append(run36);

        var paragraph18 = new Paragraph();

        var paragraphProperties18 = new ParagraphProperties();
        var paragraphStyleId18 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
        var runFonts18 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize51 = new FontSize { Val = "24" };
        var fontSizeComplexScript51 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties18.Append(runFonts18);
        paragraphMarkRunProperties18.Append(fontSize51);
        paragraphMarkRunProperties18.Append(fontSizeComplexScript51);

        paragraphProperties18.Append(paragraphStyleId18);
        paragraphProperties18.Append(paragraphMarkRunProperties18);

        var run37 = new Run();

        var runProperties37 = new RunProperties();
        var fontSize52 = new FontSize { Val = "24" };
        var fontSizeComplexScript52 = new FontSizeComplexScript { Val = "24" };

        runProperties37.Append(fontSize52);
        runProperties37.Append(fontSizeComplexScript52);
        var text32 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "кем и когда выдан "
        };

        run37.Append(runProperties37);
        run37.Append(text32);

        var run38 = new Run();

        var runProperties38 = new RunProperties();
        var fontSize53 = new FontSize { Val = "24" };
        var fontSizeComplexScript53 = new FontSizeComplexScript { Val = "24" };
        var underline13 = new Underline { Val = UnderlineValues.Single };
        var languages17 = new Languages { Val = "en-US" };

        runProperties38.Append(fontSize53);
        runProperties38.Append(fontSizeComplexScript53);
        runProperties38.Append(underline13);
        runProperties38.Append(languages17);
        var tabChar16 = new TabChar();
        var passportIssuerString =
            _model.PassportIssuer + (string.IsNullOrWhiteSpace(_model.PassportIssuerCode)
                                      ? $" {_model.PassportIssuerCode} "
                                      : " ")
                                  + _model.PassportIssueDate.ToShortDateString();
        var text33 = new Text
        {
            Text = passportIssuerString
        };

        run38.Append(runProperties38);
        run38.Append(text33);
        run38.Append(tabChar16);

        paragraph18.Append(paragraphProperties18);
        paragraph18.Append(run37);
        paragraph18.Append(run38);

        var paragraph19 = new Paragraph();

        var paragraphProperties19 = new ParagraphProperties();
        var paragraphStyleId19 = new ParagraphStyleId { Val = "DocumentTitle" };

        var paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
        var runFonts19 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize55 = new FontSize { Val = "24" };
        var fontSizeComplexScript55 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties19.Append(runFonts19);
        paragraphMarkRunProperties19.Append(fontSize55);
        paragraphMarkRunProperties19.Append(fontSizeComplexScript55);

        paragraphProperties19.Append(paragraphStyleId19);
        paragraphProperties19.Append(paragraphMarkRunProperties19);

        var run40 = new Run();

        var runProperties40 = new RunProperties();
        var fontSize56 = new FontSize { Val = "24" };
        var fontSizeComplexScript56 = new FontSizeComplexScript { Val = "24" };

        runProperties40.Append(fontSize56);
        runProperties40.Append(fontSizeComplexScript56);
        var text35 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run40.Append(runProperties40);
        run40.Append(text35);

        var run41 = new Run();

        var runProperties41 = new RunProperties();
        var fontSize57 = new FontSize { Val = "24" };
        var fontSizeComplexScript57 = new FontSizeComplexScript { Val = "24" };

        runProperties41.Append(fontSize57);
        runProperties41.Append(fontSizeComplexScript57);
        var text36 = new Text
        {
            Text = "ЗАЯВЛЕНИЕ"
        };

        run41.Append(runProperties41);
        run41.Append(text36);

        paragraph19.Append(paragraphProperties19);
        paragraph19.Append(run40);
        paragraph19.Append(run41);

        var paragraph20 = new Paragraph();

        var paragraphProperties20 = new ParagraphProperties();
        var paragraphStyleId20 = new ParagraphStyleId { Val = "TextBody" };
        var justification2 = new Justification { Val = JustificationValues.Center };

        var paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
        var runFonts20 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize58 = new FontSize { Val = "24" };
        var fontSizeComplexScript58 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties20.Append(runFonts20);
        paragraphMarkRunProperties20.Append(fontSize58);
        paragraphMarkRunProperties20.Append(fontSizeComplexScript58);

        paragraphProperties20.Append(paragraphStyleId20);
        paragraphProperties20.Append(justification2);
        paragraphProperties20.Append(paragraphMarkRunProperties20);

        var run42 = new Run();

        var runProperties42 = new RunProperties();
        var fontSize59 = new FontSize { Val = "24" };
        var fontSizeComplexScript59 = new FontSizeComplexScript { Val = "24" };

        runProperties42.Append(fontSize59);
        runProperties42.Append(fontSizeComplexScript59);
        var text37 = new Text
        {
            Text = "Прошу принять меня на обучение  по специальности (отметить знаком"
        };

        run42.Append(runProperties42);
        run42.Append(text37);

        var run43 = new Run();

        var runProperties43 = new RunProperties();
        var runFonts21 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var fontSize60 = new FontSize { Val = "24" };
        var fontSizeComplexScript60 = new FontSizeComplexScript { Val = "24" };

        runProperties43.Append(runFonts21);
        runProperties43.Append(fontSize60);
        runProperties43.Append(fontSizeComplexScript60);
        var text38 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " «"
        };

        run43.Append(runProperties43);
        run43.Append(text38);

        var run44 = new Run();

        var runProperties44 = new RunProperties();
        var runFonts22 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var caps1 = new Caps { Val = false };
        var smallCaps1 = new SmallCaps { Val = false };
        var color1 = new Color { Val = "202122" };
        var spacing1 = new Spacing { Val = 0 };
        var fontSize61 = new FontSize { Val = "24" };
        var fontSizeComplexScript61 = new FontSizeComplexScript { Val = "24" };

        runProperties44.Append(runFonts22);
        runProperties44.Append(caps1);
        runProperties44.Append(smallCaps1);
        runProperties44.Append(color1);
        runProperties44.Append(spacing1);
        runProperties44.Append(fontSize61);
        runProperties44.Append(fontSizeComplexScript61);
        var text39 = new Text
        {
            Text = "✓»"
        };

        run44.Append(runProperties44);
        run44.Append(text39);

        var run45 = new Run();

        var runProperties45 = new RunProperties();
        var runFonts23 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var fontSize62 = new FontSize { Val = "24" };
        var fontSizeComplexScript62 = new FontSizeComplexScript { Val = "24" };

        runProperties45.Append(runFonts23);
        runProperties45.Append(fontSize62);
        runProperties45.Append(fontSizeComplexScript62);
        var text40 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run45.Append(runProperties45);
        run45.Append(text40);

        var run46 = new Run();

        var runProperties46 = new RunProperties();
        var fontSize63 = new FontSize { Val = "24" };
        var fontSizeComplexScript63 = new FontSizeComplexScript { Val = "24" };

        runProperties46.Append(fontSize63);
        runProperties46.Append(fontSizeComplexScript63);
        var text41 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " ):"
        };

        run46.Append(runProperties46);
        run46.Append(text41);

        paragraph20.Append(paragraphProperties20);
        paragraph20.Append(run42);
        paragraph20.Append(run43);
        paragraph20.Append(run44);
        paragraph20.Append(run45);
        paragraph20.Append(run46);

        var table2 = new Table();

        var tableProperties2 = new TableProperties();
        var tableWidth2 = new TableWidth { Width = "5000", Type = TableWidthUnitValues.Pct };
        var tableJustification2 = new TableJustification
        { Val = new EnumValue<TableRowAlignmentValues> { InnerText = "start" } };
        var tableIndentation2 = new TableIndentation { Width = 0, Type = TableWidthUnitValues.Dxa };
        var tableLayout2 = new TableLayout { Type = TableLayoutValues.Fixed };

        var tableCellMarginDefault2 = new TableCellMarginDefault();
        var topMargin2 = new TopMargin { Width = "0", Type = TableWidthUnitValues.Dxa };
        var startMargin2 = new StartMargin { Width = "108", Type = TableWidthUnitValues.Dxa };
        var bottomMargin2 = new BottomMargin { Width = "0", Type = TableWidthUnitValues.Dxa };
        var endMargin2 = new EndMargin { Width = "108", Type = TableWidthUnitValues.Dxa };

        tableCellMarginDefault2.Append(topMargin2);
        tableCellMarginDefault2.Append(startMargin2);
        tableCellMarginDefault2.Append(bottomMargin2);
        tableCellMarginDefault2.Append(endMargin2);

        tableProperties2.Append(tableWidth2);
        tableProperties2.Append(tableJustification2);
        tableProperties2.Append(tableIndentation2);
        tableProperties2.Append(tableLayout2);
        tableProperties2.Append(tableCellMarginDefault2);

        var tableGrid2 = new TableGrid();
        var gridColumn3 = new GridColumn { Width = "715" };
        var gridColumn4 = new GridColumn { Width = "1021" };
        var gridColumn5 = new GridColumn { Width = "3371" };
        var gridColumn6 = new GridColumn { Width = "715" };
        var gridColumn7 = new GridColumn { Width = "1021" };
        var gridColumn8 = new GridColumn { Width = "3371" };

        tableGrid2.Append(gridColumn3);
        tableGrid2.Append(gridColumn4);
        tableGrid2.Append(gridColumn5);
        tableGrid2.Append(gridColumn6);
        tableGrid2.Append(gridColumn7);
        tableGrid2.Append(gridColumn8);

        table2.Append(tableProperties2);
        table2.Append(tableGrid2);

        for (var index = 0; index < _model.Specialities.Count; index += 2)
        {
            var firstSpecialityInRow = _model.Specialities[index];
            var secondIndex = index + 1;
            var tableRow = new TableRow();
            var tableCellProperties = new TableCellProperties();
            var tableCellWidth = new TableCellWidth { Width = "715", Type = TableWidthUnitValues.Dxa };
            var tableCellBorders = new TableCellBorders();
            tableCellProperties.Append(tableCellWidth);
            tableCellProperties.Append(tableCellBorders);
            tableRow.Append(tableCellProperties);
            tableRow.AddSpecialityTableCell(firstSpecialityInRow);
            if (_model.Specialities.Count > secondIndex)
            {
                var secondSpecialityInRow = _model.Specialities[index + 1];
                tableRow.AddSpecialityTableCell(secondSpecialityInRow);
            }
            else
            {
                tableRow.AddSpecialityTableCell(null);
            }

            table2.Append(tableRow);
        }

        var paragraph51 = new Paragraph();

        var paragraphProperties51 = new ParagraphProperties();
        var paragraphStyleId51 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
        var runFonts54 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties51.Append(runFonts54);

        paragraphProperties51.Append(paragraphStyleId51);
        paragraphProperties51.Append(paragraphMarkRunProperties51);

        var run85 = new Run();
        var runProperties85 = new RunProperties();
        var text77 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "на базе среднего общего (11 кл.) "
        };

        run85.Append(runProperties85);
        run85.Append(text77);

        var run86 = new Run();

        var runProperties86 = new RunProperties();
        var runFonts55 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages28 = new Languages { Val = "en-US" };

        runProperties86.Append(runFonts55);
        runProperties86.Append(languages28);
        var text78 = new Text
        {
            Text = _model.MiddleSchoolSelection
        };

        run86.Append(runProperties86);
        run86.Append(text78);

        var run87 = new Run();
        var runProperties87 = new RunProperties();
        var text79 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/ основного общего образования (9 кл.) "
        };

        run87.Append(runProperties87);
        run87.Append(text79);

        var run88 = new Run();

        var runProperties88 = new RunProperties();
        var runFonts56 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages29 = new Languages { Val = "en-US" };

        runProperties88.Append(runFonts56);
        runProperties88.Append(languages29);
        var text80 = new Text
        {
            Text = _model.CommonMiddleSchoolSelection
        };

        run88.Append(runProperties88);
        run88.Append(text80);

        var run89 = new Run();
        var runProperties89 = new RunProperties();
        var text81 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/ среднее профессиональное образование "
        };

        run89.Append(runProperties89);
        run89.Append(text81);

        var run90 = new Run();

        var runProperties90 = new RunProperties();
        var runFonts57 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages30 = new Languages { Val = "en-US" };

        runProperties90.Append(runFonts57);
        runProperties90.Append(languages30);
        var text82 = new Text
        {
            Text = _model.TechnicalSchoolSelection
        };

        run90.Append(runProperties90);
        run90.Append(text82);

        var run91 = new Run();
        var runProperties91 = new RunProperties();
        var text83 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/ высшее "
        };

        run91.Append(runProperties91);
        run91.Append(text83);

        var run92 = new Run();

        var runProperties92 = new RunProperties();
        var languages31 = new Languages { Val = "en-US" };

        runProperties92.Append(languages31);
        var text84 = new Text
        {
            Text = _model.HigherSelection
        };

        run92.Append(runProperties92);
        run92.Append(text84);

        var run93 = new Run();
        var runProperties93 = new RunProperties();
        var text85 = new Text
        {
            Text = "."
        };

        run93.Append(runProperties93);
        run93.Append(text85);

        paragraph51.Append(paragraphProperties51);
        paragraph51.Append(run85);
        paragraph51.Append(run86);
        paragraph51.Append(run87);
        paragraph51.Append(run88);
        paragraph51.Append(run89);
        paragraph51.Append(run90);
        paragraph51.Append(run91);
        paragraph51.Append(run92);
        paragraph51.Append(run93);

        var paragraph52 = new Paragraph();

        var paragraphProperties52 = new ParagraphProperties();
        var paragraphStyleId52 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties52 = new ParagraphMarkRunProperties();
        var runFonts58 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties52.Append(runFonts58);

        paragraphProperties52.Append(paragraphStyleId52);
        paragraphProperties52.Append(paragraphMarkRunProperties52);

        var run94 = new Run();
        var runProperties94 = new RunProperties();
        var text86 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "по  очной "
        };

        run94.Append(runProperties94);
        run94.Append(text86);

        var run95 = new Run();

        var runProperties95 = new RunProperties();
        var runFonts59 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages32 = new Languages { Val = "en-US" };

        runProperties95.Append(runFonts59);
        runProperties95.Append(languages32);
        var text87 = new Text
        {
            Text = _model.FullTimeFormSelection
        };

        run95.Append(runProperties95);
        run95.Append(text87);

        var run96 = new Run();
        var runProperties96 = new RunProperties();
        var text88 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/ заочной "
        };

        run96.Append(runProperties96);
        run96.Append(text88);

        var run97 = new Run();

        var runProperties97 = new RunProperties();
        var runFonts60 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages33 = new Languages { Val = "en-US" };

        runProperties97.Append(runFonts60);
        runProperties97.Append(languages33);
        var text89 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = _model.DistanceFormSelection
        };

        run97.Append(runProperties97);
        run97.Append(text89);

        var run98 = new Run();
        var runProperties98 = new RunProperties();
        var text90 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "на места, финансируемые из областного бюджета "
        };

        run98.Append(runProperties98);
        run98.Append(text90);

        var run99 = new Run();

        var runProperties99 = new RunProperties();
        var languages34 = new Languages { Val = "en-US" };

        runProperties99.Append(languages34);
        var text91 = new Text
        {
            Text = _model.BudgetSelection
        };

        run99.Append(runProperties99);
        run99.Append(text91);

        var run100 = new Run();
        var runProperties100 = new RunProperties();
        var text92 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/по договорам с оплатой стоимости обучения с юридическими "
        };

        run100.Append(runProperties100);
        run100.Append(text92);

        var run101 = new Run();

        var runProperties101 = new RunProperties();
        var runFonts61 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages35 = new Languages { Val = "en-US" };

        runProperties101.Append(runFonts61);
        runProperties101.Append(languages35);
        var text93 = new Text
        {
            Text = _model.LegalEntitiesSelection
        };

        run101.Append(runProperties101);
        run101.Append(text93);

        var run102 = new Run();
        var runProperties102 = new RunProperties();
        var text94 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = ",/ физическими лицами "
        };

        run102.Append(runProperties102);
        run102.Append(text94);

        var run103 = new Run();

        var runProperties103 = new RunProperties();
        var runFonts62 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages36 = new Languages { Val = "en-US" };

        runProperties103.Append(runFonts62);
        runProperties103.Append(languages36);
        var text95 = new Text
        {
            Text = _model.IndividualEntitiesSelection
        };

        run103.Append(runProperties103);
        run103.Append(text95);

        var run104 = new Run();
        var runProperties104 = new RunProperties();
        var text96 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " (отметить знаком «✓»)."
        };
        run104.Append(runProperties104);
        run104.Append(text96);

        paragraph52.Append(paragraphProperties52);
        paragraph52.Append(run94);
        paragraph52.Append(run95);
        paragraph52.Append(run96);
        paragraph52.Append(run97);
        paragraph52.Append(run98);
        paragraph52.Append(run99);
        paragraph52.Append(run100);
        paragraph52.Append(run101);
        paragraph52.Append(run102);
        paragraph52.Append(run103);
        paragraph52.Append(run104);

        var paragraph53 = new Paragraph();

        var paragraphProperties53 = new ParagraphProperties();
        var paragraphStyleId53 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties53 = new ParagraphMarkRunProperties();
        var runFonts65 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties53.Append(runFonts65);

        paragraphProperties53.Append(paragraphStyleId53);
        paragraphProperties53.Append(paragraphMarkRunProperties53);

        var run108 = new Run();

        var runProperties108 = new RunProperties();
        var runFonts66 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages37 = new Languages { Val = "en-US" };

        runProperties108.Append(runFonts66);
        runProperties108.Append(languages37);
        var text100 = new Text
        {
            Text = _model.NeedFirefighterAssignmentSelection
        };

        run108.Append(runProperties108);
        run108.Append(text100);

        var run109 = new Run();
        var runProperties109 = new RunProperties();
        var text101 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text =
                " Прошу допустить меня к вступительному испытанию (заполняется при поступлении на специальность: «Пожарная безопасность»)"
        };

        run109.Append(runProperties109);
        run109.Append(text101);

        paragraph53.Append(paragraphProperties53);
        paragraph53.Append(run108);
        paragraph53.Append(run109);

        var paragraph54 = new Paragraph();

        var paragraphProperties54 = new ParagraphProperties();
        var paragraphStyleId54 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties54 = new ParagraphMarkRunProperties();
        var runFonts67 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties54.Append(runFonts67);

        paragraphProperties54.Append(paragraphStyleId54);
        paragraphProperties54.Append(paragraphMarkRunProperties54);

        var run110 = new Run();
        var runProperties110 = new RunProperties();
        var text102 = new Text
        {
            Text = "О себе сообщаю:"
        };

        run110.Append(runProperties110);
        run110.Append(text102);

        paragraph54.Append(paragraphProperties54);
        paragraph54.Append(run110);

        var paragraph55 = new Paragraph();

        var paragraphProperties55 = new ParagraphProperties();
        var paragraphStyleId55 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties55 = new ParagraphMarkRunProperties();
        var runFonts68 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties55.Append(runFonts68);

        paragraphProperties55.Append(paragraphStyleId55);
        paragraphProperties55.Append(paragraphMarkRunProperties55);

        var run111 = new Run();
        var runProperties111 = new RunProperties();
        var text103 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Получил(а) в"
        };

        run111.Append(runProperties111);
        run111.Append(text103);

        var run113 = new Run();

        var runProperties113 = new RunProperties();
        var underline15 = new Underline { Val = UnderlineValues.Single };
        var languages39 = new Languages { Val = "en-US" };

        runProperties113.Append(underline15);
        runProperties113.Append(languages39);
        var text105 = new Text
        {
            Text = _model.LearnYear.ToString()
        };

        run113.Append(runProperties113);
        run113.Append(text105);

        var run114 = new Run();

        var runProperties114 = new RunProperties();
        var underline16 = new Underline { Val = UnderlineValues.None };
        var languages40 = new Languages { Val = "en-US" };

        runProperties114.Append(underline16);
        runProperties114.Append(languages40);
        var text106 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " году"
        };

        run114.Append(runProperties114);
        run114.Append(text106);

        var run115 = new Run();
        var runProperties115 = new RunProperties();
        var text107 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " следующий уровень образования:"
        };

        run115.Append(runProperties115);
        run115.Append(text107);

        paragraph55.Append(paragraphProperties55);
        paragraph55.Append(run111);
        paragraph55.Append(run113);
        paragraph55.Append(run114);
        paragraph55.Append(run115);

        var paragraph56 = new Paragraph();

        var paragraphProperties56 = new ParagraphProperties();
        var paragraphStyleId56 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties56 = new ParagraphMarkRunProperties();
        var runFonts69 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties56.Append(runFonts69);

        paragraphProperties56.Append(paragraphStyleId56);
        paragraphProperties56.Append(paragraphMarkRunProperties56);

        var run116 = new Run();
        var runProperties116 = new RunProperties();
        var text108 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "основное общее образование  (9 кл.) "
        };

        run116.Append(runProperties116);
        run116.Append(text108);

        var run117 = new Run();

        var runProperties117 = new RunProperties();
        var underline17 = new Underline { Val = UnderlineValues.Single };
        var languages41 = new Languages { Val = "en-US" };

        runProperties117.Append(underline17);
        runProperties117.Append(languages41);
        var text109 = new Text
        {
            Text = _model.CommonMiddleSchoolDescription
        };
        var tabChar2 = new TabChar();

        run117.Append(runProperties117);
        run117.Append(text109);
        run117.Append(tabChar2);

        paragraph56.Append(paragraphProperties56);
        paragraph56.Append(run116);
        paragraph56.Append(run117);

        var paragraph57 = new Paragraph();

        var paragraphProperties57 = new ParagraphProperties();
        var paragraphStyleId57 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties57 = new ParagraphMarkRunProperties();
        var runFonts70 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties57.Append(runFonts70);

        paragraphProperties57.Append(paragraphStyleId57);
        paragraphProperties57.Append(paragraphMarkRunProperties57);

        var run118 = new Run();
        var runProperties118 = new RunProperties();
        var text110 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "среднее общее образование (11 кл.) "
        };

        run118.Append(runProperties118);
        run118.Append(text110);

        var run119 = new Run();

        var runProperties119 = new RunProperties();
        var underline18 = new Underline { Val = UnderlineValues.Single };
        var languages42 = new Languages { Val = "en-US" };

        runProperties119.Append(underline18);
        runProperties119.Append(languages42);
        var text111 = new Text
        {
            Text = _model.MiddleSchoolDescription
        };
        var tabChar3 = new TabChar();

        run119.Append(runProperties119);
        run119.Append(text111);
        run119.Append(tabChar3);

        paragraph57.Append(paragraphProperties57);
        paragraph57.Append(run118);
        paragraph57.Append(run119);

        var paragraph58 = new Paragraph();

        var paragraphProperties58 = new ParagraphProperties();
        var paragraphStyleId58 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties58 = new ParagraphMarkRunProperties();
        var runFonts71 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties58.Append(runFonts71);

        paragraphProperties58.Append(paragraphStyleId58);
        paragraphProperties58.Append(paragraphMarkRunProperties58);

        var run120 = new Run();
        var runProperties120 = new RunProperties();
        var text112 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "среднее профессиональное образование "
        };

        run120.Append(runProperties120);
        run120.Append(text112);

        var run121 = new Run();

        var runProperties121 = new RunProperties();
        var underline19 = new Underline { Val = UnderlineValues.Single };
        var languages43 = new Languages { Val = "en-US" };

        runProperties121.Append(underline19);
        runProperties121.Append(languages43);
        var text113 = new Text
        {
            Text = _model.TechnicalSchoolDescription
        };
        var tabChar4 = new TabChar();

        run121.Append(runProperties121);
        run121.Append(text113);
        run121.Append(tabChar4);

        paragraph58.Append(paragraphProperties58);
        paragraph58.Append(run120);
        paragraph58.Append(run121);

        var paragraph59 = new Paragraph();

        var paragraphProperties59 = new ParagraphProperties();
        var paragraphStyleId59 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties59 = new ParagraphMarkRunProperties();
        var runFonts72 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties59.Append(runFonts72);

        paragraphProperties59.Append(paragraphStyleId59);
        paragraphProperties59.Append(paragraphMarkRunProperties59);

        var run122 = new Run();
        var runProperties122 = new RunProperties();
        var text114 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "высшее "
        };

        run122.Append(runProperties122);
        run122.Append(text114);

        var run123 = new Run();

        var runProperties123 = new RunProperties();
        var underline20 = new Underline { Val = UnderlineValues.Single };
        var languages44 = new Languages { Val = "en-US" };

        runProperties123.Append(underline20);
        runProperties123.Append(languages44);
        var text115 = new Text
        {
            Text = _model.HigherDescription
        };
        var tabChar5 = new TabChar();

        run123.Append(runProperties123);
        run123.Append(text115);
        run123.Append(tabChar5);

        paragraph59.Append(paragraphProperties59);
        paragraph59.Append(run122);
        paragraph59.Append(run123);

        var paragraph60 = new Paragraph();

        var paragraphProperties60 = new ParagraphProperties();
        var paragraphStyleId60 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties60 = new ParagraphMarkRunProperties();
        var runFonts73 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties60.Append(runFonts73);

        paragraphProperties60.Append(paragraphStyleId60);
        paragraphProperties60.Append(paragraphMarkRunProperties60);

        var run124 = new Run();
        var runProperties124 = new RunProperties();
        var text116 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Аттестат "
        };

        run124.Append(runProperties124);
        run124.Append(text116);

        var run125 = new Run();

        var runProperties125 = new RunProperties();
        var languages45 = new Languages { Val = "en-US" };

        runProperties125.Append(languages45);
        var text117 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = _model.AttestSelection
        };

        run125.Append(runProperties125);
        run125.Append(text117);

        var run126 = new Run();
        var runProperties126 = new RunProperties();
        var text118 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "/ диплом  "
        };

        run126.Append(runProperties126);
        run126.Append(text118);

        var run127 = new Run();

        var runProperties127 = new RunProperties();
        var languages46 = new Languages { Val = "en-US" };

        runProperties127.Append(languages46);
        var text119 = new Text
        {
            Text = _model.DiplomaSelection
        };

        run127.Append(runProperties127);
        run127.Append(text119);

        var run128 = new Run();
        var runProperties128 = new RunProperties();
        var text120 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " серия "
        };

        run128.Append(runProperties128);
        run128.Append(text120);

        var run129 = new Run();

        var runProperties129 = new RunProperties();
        var underline21 = new Underline { Val = UnderlineValues.Single };
        var languages47 = new Languages { Val = "en-US" };

        runProperties129.Append(underline21);
        runProperties129.Append(languages47);
        var text121 = new Text
        {
            Text = _model.EducationDocumentSerial
        };

        run129.Append(runProperties129);
        run129.Append(text121);

        var run130 = new Run();

        var runProperties130 = new RunProperties();
        var languages48 = new Languages { Val = "en-US" };

        runProperties130.Append(languages48);
        var text122 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run130.Append(runProperties130);
        run130.Append(text122);

        var run131 = new Run();
        var runProperties131 = new RunProperties();
        var text123 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "№ "
        };

        run131.Append(runProperties131);
        run131.Append(text123);

        var run132 = new Run();

        var runProperties132 = new RunProperties();
        var italic1 = new Italic { Val = false };
        var italicComplexScript1 = new ItalicComplexScript { Val = false };
        var underline22 = new Underline { Val = UnderlineValues.Single };
        var languages49 = new Languages { Val = "en-US" };

        runProperties132.Append(italic1);
        runProperties132.Append(italicComplexScript1);
        runProperties132.Append(underline22);
        runProperties132.Append(languages49);
        var text124 = new Text
        {
            Text = _model.EducationDocumentNumber
        };

        run132.Append(runProperties132);
        run132.Append(text124);

        var run133 = new Run();

        var runProperties133 = new RunProperties();
        var languages50 = new Languages { Val = "en-US" };

        runProperties133.Append(languages50);
        var text125 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " дата выдачи "
        };

        run133.Append(runProperties133);
        run133.Append(text125);

        var run135 = new Run();

        var runProperties135 = new RunProperties();
        var underline23 = new Underline { Val = UnderlineValues.Single };
        var languages51 = new Languages { Val = "en-US" };

        runProperties135.Append(underline23);
        runProperties135.Append(languages51);
        var text127 = new Text
        {
            Text = _model.EducationDocumentIssuedText
        };

        run135.Append(runProperties135);
        run135.Append(text127);

        paragraph60.Append(paragraphProperties60);
        paragraph60.Append(run124);
        paragraph60.Append(run125);
        paragraph60.Append(run126);
        paragraph60.Append(run127);
        paragraph60.Append(run128);
        paragraph60.Append(run129);
        paragraph60.Append(run130);
        paragraph60.Append(run131);
        paragraph60.Append(run132);
        paragraph60.Append(run133);
        paragraph60.Append(run135);

        var paragraph61 = new Paragraph();

        var paragraphProperties61 = new ParagraphProperties();
        var paragraphStyleId61 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties61 = new ParagraphMarkRunProperties();
        var runFonts74 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties61.Append(runFonts74);

        paragraphProperties61.Append(paragraphStyleId61);
        paragraphProperties61.Append(paragraphMarkRunProperties61);

        var run136 = new Run();

        var runProperties136 = new RunProperties();
        var runFonts75 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties136.Append(runFonts75);
        var text128 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "В общежитии нуждаюсь "
        };

        run136.Append(runProperties136);
        run136.Append(text128);

        var run137 = new Run();

        var runProperties137 = new RunProperties();
        var runFonts76 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages52 = new Languages { Val = "en-US" };

        runProperties137.Append(runFonts76);
        runProperties137.Append(languages52);
        var text129 = new Text
        {
            Text = _model.NeedDormitorySelection
        };

        run137.Append(runProperties137);
        run137.Append(text129);

        paragraph61.Append(paragraphProperties61);
        paragraph61.Append(run136);
        paragraph61.Append(run137);

        var paragraph62 = new Paragraph();

        var paragraphProperties62 = new ParagraphProperties();
        var paragraphStyleId62 = new ParagraphStyleId { Val = "MainBody" };

        var paragraphMarkRunProperties62 = new ParagraphMarkRunProperties();
        var runFonts77 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties62.Append(runFonts77);

        paragraphProperties62.Append(paragraphStyleId62);
        paragraphProperties62.Append(paragraphMarkRunProperties62);

        var run138 = new Run();

        var runProperties138 = new RunProperties();
        var runFonts78 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties138.Append(runFonts78);
        var text130 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Среднее профессиональное образование получаю впервые "
        };

        run138.Append(runProperties138);
        run138.Append(text130);

        var run139 = new Run();

        var runProperties139 = new RunProperties();
        var runFonts79 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages53 = new Languages { Val = "en-US" };

        runProperties139.Append(runFonts79);
        runProperties139.Append(languages53);
        var text131 = new Text
        {
            Text = _model.FirstTimeInTechnicalSchoolSelection
        };

        run139.Append(runProperties139);
        run139.Append(text131);

        var run140 = new Run();

        var runProperties140 = new RunProperties();
        var runFonts80 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties140.Append(runFonts80);
        var text132 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = ", не впервые "
        };

        run140.Append(runProperties140);
        run140.Append(text132);

        var run141 = new Run();

        var runProperties141 = new RunProperties();
        var runFonts81 = new RunFonts { EastAsia = "Symbol", ComplexScript = "Symbol" };
        var languages54 = new Languages { Val = "en-US" };

        runProperties141.Append(runFonts81);
        runProperties141.Append(languages54);
        var text133 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = _model.NotFirstTimeInTechnicalSchoolSelection
        };

        run141.Append(runProperties141);
        run141.Append(text133);

        var run142 = new Run();

        var runProperties142 = new RunProperties();
        var runFonts82 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties142.Append(runFonts82);
        var text134 = new Text
        {
            Text = "_________________"
        };

        run142.Append(runProperties142);
        run142.Append(text134);

        paragraph62.Append(paragraphProperties62);
        paragraph62.Append(run138);
        paragraph62.Append(run139);
        paragraph62.Append(run140);
        paragraph62.Append(run141);
        paragraph62.Append(run142);

        var paragraph63 = new Paragraph();

        var paragraphProperties63 = new ParagraphProperties();
        var paragraphStyleId63 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties63 = new ParagraphMarkRunProperties();
        var runFonts83 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize132 = new FontSize { Val = "24" };
        var fontSizeComplexScript132 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties63.Append(runFonts83);
        paragraphMarkRunProperties63.Append(fontSize132);
        paragraphMarkRunProperties63.Append(fontSizeComplexScript132);

        paragraphProperties63.Append(paragraphStyleId63);
        paragraphProperties63.Append(paragraphMarkRunProperties63);

        var run143 = new Run();

        var runProperties143 = new RunProperties();
        var fontSize133 = new FontSize { Val = "24" };
        var fontSizeComplexScript133 = new FontSizeComplexScript { Val = "24" };

        runProperties143.Append(fontSize133);
        runProperties143.Append(fontSizeComplexScript133);
        var text135 = new Text
        {
            Text = "(Подпись поступающего)"
        };

        run143.Append(runProperties143);
        run143.Append(text135);

        paragraph63.Append(paragraphProperties63);
        paragraph63.Append(run143);

        var paragraph64 = new Paragraph();

        var paragraphProperties64 = new ParagraphProperties();
        var paragraphStyleId64 = new ParagraphStyleId { Val = "MainBody" };

        var tabs1 = new Tabs();
        var tabStop1 = new TabStop { Val = TabStopValues.Clear, Position = 10080 };
        var tabStop2 = new TabStop { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 7560 };
        var tabStop3 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10173 };

        tabs1.Append(tabStop1);
        tabs1.Append(tabStop2);
        tabs1.Append(tabStop3);

        var paragraphMarkRunProperties64 = new ParagraphMarkRunProperties();
        var runFonts84 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties64.Append(runFonts84);

        paragraphProperties64.Append(paragraphStyleId64);
        paragraphProperties64.Append(tabs1);
        paragraphProperties64.Append(paragraphMarkRunProperties64);

        var run144 = new Run();
        var runProperties144 = new RunProperties();
        var text136 = new Text
        {
            Text =
                "С Уставом, лицензией на осуществления образовательной деятельности, свидетельством о государственной аккредитации, с образовательными программами, Правилами приема и Правила внутреннего распорядка ознакомлен(а): "
        };

        run144.Append(runProperties144);
        run144.Append(text136);

        var run145 = new Run();

        var runProperties145 = new RunProperties();
        var languages55 = new Languages { Val = "en-US" };

        runProperties145.Append(languages55);
        var tabChar6 = new TabChar();
        var text138 = new Text
        {
            Text = "_____________________"
        };

        run145.Append(runProperties145);
        run145.Append(tabChar6);
        run145.Append(text138);

        paragraph64.Append(paragraphProperties64);
        paragraph64.Append(run144);
        paragraph64.Append(run145);

        var paragraph65 = new Paragraph();

        var paragraphProperties65 = new ParagraphProperties();
        var paragraphStyleId65 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties65 = new ParagraphMarkRunProperties();
        var runFonts85 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize134 = new FontSize { Val = "24" };
        var fontSizeComplexScript134 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties65.Append(runFonts85);
        paragraphMarkRunProperties65.Append(fontSize134);
        paragraphMarkRunProperties65.Append(fontSizeComplexScript134);

        paragraphProperties65.Append(paragraphStyleId65);
        paragraphProperties65.Append(paragraphMarkRunProperties65);

        var run146 = new Run();

        var runProperties146 = new RunProperties();
        var fontSize135 = new FontSize { Val = "24" };
        var fontSizeComplexScript135 = new FontSizeComplexScript { Val = "24" };

        runProperties146.Append(fontSize135);
        runProperties146.Append(fontSizeComplexScript135);
        var text139 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "(Подпись поступающего)"
        };

        run146.Append(runProperties146);
        run146.Append(text139);

        paragraph65.Append(paragraphProperties65);
        paragraph65.Append(run146);

        var paragraph66 = new Paragraph();

        var paragraphProperties66 = new ParagraphProperties();
        var paragraphStyleId66 = new ParagraphStyleId { Val = "MainBody" };

        var tabs2 = new Tabs();
        var tabStop4 = new TabStop { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 7560 };
        var tabStop5 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10080 };
        var tabStop6 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10173 };

        tabs2.Append(tabStop4);
        tabs2.Append(tabStop5);
        tabs2.Append(tabStop6);

        var paragraphMarkRunProperties66 = new ParagraphMarkRunProperties();
        var runFonts86 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties66.Append(runFonts86);

        paragraphProperties66.Append(paragraphStyleId66);
        paragraphProperties66.Append(tabs2);
        paragraphProperties66.Append(paragraphMarkRunProperties66);

        var run147 = new Run();
        var runProperties147 = new RunProperties();
        var text140 = new Text
        {
            Text = "С датой предоставления оригинала документа об образовании и (или)  о квалификации ознакомлен(а):"
        };
        var tabChar7 = new TabChar();
        var text141 = new Text
        {
            Text = "____________________"
        };

        run147.Append(runProperties147);
        run147.Append(text140);
        run147.Append(tabChar7);
        run147.Append(text141);

        paragraph66.Append(paragraphProperties66);
        paragraph66.Append(run147);

        var paragraph67 = new Paragraph();

        var paragraphProperties67 = new ParagraphProperties();
        var paragraphStyleId67 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties67 = new ParagraphMarkRunProperties();
        var runFonts87 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize136 = new FontSize { Val = "24" };
        var fontSizeComplexScript136 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties67.Append(runFonts87);
        paragraphMarkRunProperties67.Append(fontSize136);
        paragraphMarkRunProperties67.Append(fontSizeComplexScript136);

        paragraphProperties67.Append(paragraphStyleId67);
        paragraphProperties67.Append(paragraphMarkRunProperties67);

        var run148 = new Run();

        var runProperties148 = new RunProperties();
        var fontSize137 = new FontSize { Val = "24" };
        var fontSizeComplexScript137 = new FontSizeComplexScript { Val = "24" };

        runProperties148.Append(fontSize137);
        runProperties148.Append(fontSizeComplexScript137);
        var text142 = new Text
        {
            Text = "(Подпись поступающего)"
        };

        run148.Append(runProperties148);
        run148.Append(text142);

        paragraph67.Append(paragraphProperties67);
        paragraph67.Append(run148);

        var paragraph68 = new Paragraph();

        var paragraphProperties68 = new ParagraphProperties();
        var paragraphStyleId68 = new ParagraphStyleId { Val = "Normal" };
        var widowControl43 = new WidowControl();
        var justification3 = new Justification { Val = JustificationValues.Start };

        var paragraphMarkRunProperties68 = new ParagraphMarkRunProperties();
        var runFonts88 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize138 = new FontSize { Val = "24" };
        var fontSizeComplexScript138 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties68.Append(runFonts88);
        paragraphMarkRunProperties68.Append(fontSize138);
        paragraphMarkRunProperties68.Append(fontSizeComplexScript138);

        paragraphProperties68.Append(paragraphStyleId68);
        paragraphProperties68.Append(widowControl43);
        paragraphProperties68.Append(justification3);
        paragraphProperties68.Append(paragraphMarkRunProperties68);

        var run149 = new Run();

        var runProperties149 = new RunProperties();
        var runFonts89 = new RunFonts { ComplexScript = "Times New Roman" };
        var fontSize139 = new FontSize { Val = "24" };
        var fontSizeComplexScript139 = new FontSizeComplexScript { Val = "24" };

        runProperties149.Append(runFonts89);
        runProperties149.Append(fontSize139);
        runProperties149.Append(fontSizeComplexScript139);
        var text143 = new Text
        {
            Text =
                "На обработку  и хранение своих персональных данных в порядке, установленном Федеральным законом от 27 июля 2006 г. N 152-ФЗ \"О персональных данных» согласен (а): __________________"
        };

        run149.Append(runProperties149);
        run149.Append(text143);

        paragraph68.Append(paragraphProperties68);
        paragraph68.Append(run149);

        var paragraph69 = new Paragraph();

        var paragraphProperties69 = new ParagraphProperties();
        var paragraphStyleId69 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties69 = new ParagraphMarkRunProperties();
        var runFonts90 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties69.Append(runFonts90);

        paragraphProperties69.Append(paragraphStyleId69);
        paragraphProperties69.Append(paragraphMarkRunProperties69);

        var run150 = new Run();
        var runProperties150 = new RunProperties();
        var text144 = new Text
        {
            Text = "(Подпись поступающего)"
        };

        run150.Append(runProperties150);
        run150.Append(text144);

        paragraph69.Append(paragraphProperties69);
        paragraph69.Append(run150);

        var paragraph70 = new Paragraph();

        var paragraphProperties70 = new ParagraphProperties();
        var paragraphStyleId70 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties70 = new ParagraphMarkRunProperties();
        var runFonts91 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize140 = new FontSize { Val = "24" };
        var fontSizeComplexScript140 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties70.Append(runFonts91);
        paragraphMarkRunProperties70.Append(fontSize140);
        paragraphMarkRunProperties70.Append(fontSizeComplexScript140);

        paragraphProperties70.Append(paragraphStyleId70);
        paragraphProperties70.Append(paragraphMarkRunProperties70);

        var run151 = new Run();

        var runProperties151 = new RunProperties();
        var bold1 = new Bold();
        var fontSize141 = new FontSize { Val = "24" };
        var fontSizeComplexScript141 = new FontSizeComplexScript { Val = "24" };

        runProperties151.Append(bold1);
        runProperties151.Append(fontSize141);
        runProperties151.Append(fontSizeComplexScript141);
        var text145 = new Text
        {
            Text = "_________________________________________________________"
        };

        run151.Append(runProperties151);
        run151.Append(text145);

        paragraph70.Append(paragraphProperties70);
        paragraph70.Append(run151);

        var paragraph71 = new Paragraph();

        var paragraphProperties71 = new ParagraphProperties();
        var paragraphStyleId71 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties71 = new ParagraphMarkRunProperties();
        var runFonts92 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize142 = new FontSize { Val = "24" };
        var fontSizeComplexScript142 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties71.Append(runFonts92);
        paragraphMarkRunProperties71.Append(fontSize142);
        paragraphMarkRunProperties71.Append(fontSizeComplexScript142);

        paragraphProperties71.Append(paragraphStyleId71);
        paragraphProperties71.Append(paragraphMarkRunProperties71);

        var run152 = new Run();

        var runProperties152 = new RunProperties();
        var fontSize143 = new FontSize { Val = "24" };
        var fontSizeComplexScript143 = new FontSizeComplexScript { Val = "24" };

        runProperties152.Append(fontSize143);
        runProperties152.Append(fontSizeComplexScript143);
        var text146 = new Text
        {
            Text = "(Подпись родителя или законного представителей поступающего)"
        };

        run152.Append(runProperties152);
        run152.Append(text146);

        paragraph71.Append(paragraphProperties71);
        paragraph71.Append(run152);

        var paragraph72 = new Paragraph();

        var paragraphProperties72 = new ParagraphProperties();
        var paragraphStyleId72 = new ParagraphStyleId { Val = "Normal" };
        var widowControl44 = new WidowControl();

        var paragraphMarkRunProperties72 = new ParagraphMarkRunProperties();
        var runFonts93 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize144 = new FontSize { Val = "24" };
        var fontSizeComplexScript144 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties72.Append(runFonts93);
        paragraphMarkRunProperties72.Append(fontSize144);
        paragraphMarkRunProperties72.Append(fontSizeComplexScript144);

        paragraphProperties72.Append(paragraphStyleId72);
        paragraphProperties72.Append(widowControl44);
        paragraphProperties72.Append(paragraphMarkRunProperties72);

        var run153 = new Run();

        var runProperties153 = new RunProperties();
        var runFonts94 = new RunFonts { ComplexScript = "Times New Roman" };
        var fontSize145 = new FontSize { Val = "24" };
        var fontSizeComplexScript145 = new FontSizeComplexScript { Val = "24" };

        runProperties153.Append(runFonts94);
        runProperties153.Append(fontSize145);
        runProperties153.Append(fontSizeComplexScript145);
        var text147 = new Text
        {
            Text = "Подпись ответственного лица приемной комиссии ___________________________________ (ФИО)"
        };

        run153.Append(runProperties153);
        run153.Append(text147);

        paragraph72.Append(paragraphProperties72);
        paragraph72.Append(run153);

        var paragraph73 = new Paragraph();

        var paragraphProperties73 = new ParagraphProperties();
        var paragraphStyleId73 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties73 = new ParagraphMarkRunProperties();
        var runFonts95 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties73.Append(runFonts95);

        paragraphProperties73.Append(paragraphStyleId73);
        paragraphProperties73.Append(paragraphMarkRunProperties73);

        var run154 = new Run();

        var runProperties154 = new RunProperties();
        var runFonts96 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties154.Append(runFonts96);
        var text148 = new Text
        {
            Text = "\""
        };

        run154.Append(runProperties154);
        run154.Append(text148);

        var run155 = new Run();

        var runProperties155 = new RunProperties();
        var runFonts97 = new RunFonts { ComplexScript = "Times New Roman" };
        var underline24 = new Underline { Val = UnderlineValues.Single };
        var languages56 = new Languages { Val = "en-US" };

        runProperties155.Append(runFonts97);
        runProperties155.Append(underline24);
        runProperties155.Append(languages56);
        var text149 = new Text
        {
            Text = _model.NowDay
        };

        run155.Append(runProperties155);
        run155.Append(text149);

        var run156 = new Run();

        var runProperties156 = new RunProperties();
        var runFonts98 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties156.Append(runFonts98);
        var text150 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "\" "
        };

        run156.Append(runProperties156);
        run156.Append(text150);

        var run157 = new Run();

        var runProperties157 = new RunProperties();
        var runFonts99 = new RunFonts { ComplexScript = "Times New Roman" };
        var underline25 = new Underline { Val = UnderlineValues.Single };
        var languages57 = new Languages { Val = "en-US" };

        runProperties157.Append(runFonts99);
        runProperties157.Append(underline25);
        runProperties157.Append(languages57);
        var text151 = new Text
        {
            Text = _model.NowMonth
        };

        run157.Append(runProperties157);
        run157.Append(text151);

        var run158 = new Run();

        var runProperties158 = new RunProperties();
        var runFonts100 = new RunFonts { ComplexScript = "Times New Roman" };
        var languages58 = new Languages { Val = "en-US" };

        runProperties158.Append(runFonts100);
        runProperties158.Append(languages58);
        var text152 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run158.Append(runProperties158);
        run158.Append(text152);

        var run159 = new Run();

        var runProperties159 = new RunProperties();
        var runFonts101 = new RunFonts { ComplexScript = "Times New Roman" };
        var underline26 = new Underline { Val = UnderlineValues.Single };
        var languages59 = new Languages { Val = "en-US" };

        runProperties159.Append(runFonts101);
        runProperties159.Append(underline26);
        runProperties159.Append(languages59);
        var text153 = new Text
        {
            Text = _model.NowYear
        };

        run159.Append(runProperties159);
        run159.Append(text153);

        var run160 = new Run();

        var runProperties160 = new RunProperties();
        var runFonts102 = new RunFonts { ComplexScript = "Times New Roman" };

        runProperties160.Append(runFonts102);
        var text154 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " г."
        };

        run160.Append(runProperties160);
        run160.Append(text154);

        paragraph73.Append(paragraphProperties73);
        paragraph73.Append(run154);
        paragraph73.Append(run155);
        paragraph73.Append(run156);
        paragraph73.Append(run157);
        paragraph73.Append(run158);
        paragraph73.Append(run159);
        paragraph73.Append(run160);

        var paragraph74 = new Paragraph();

        var paragraphProperties74 = new ParagraphProperties();
        var paragraphStyleId74 = new ParagraphStyleId { Val = "FieldDescriptionR" };

        var paragraphMarkRunProperties74 = new ParagraphMarkRunProperties();
        var runFonts103 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

        paragraphMarkRunProperties74.Append(runFonts103);

        paragraphProperties74.Append(paragraphStyleId74);
        paragraphProperties74.Append(paragraphMarkRunProperties74);

        var run161 = new Run();
        var runProperties161 = new RunProperties();

        run161.Append(runProperties161);

        var run162 = new Run();
        var break1 = new Break { Type = BreakValues.Page };

        run162.Append(break1);

        paragraph74.Append(paragraphProperties74);
        paragraph74.Append(run161);
        paragraph74.Append(run162);

        var paragraph75 = new Paragraph();

        var paragraphProperties75 = new ParagraphProperties();
        var paragraphStyleId75 = new ParagraphStyleId { Val = "AdditionalInfo" };
        var justification4 = new Justification { Val = JustificationValues.Center };

        var paragraphMarkRunProperties75 = new ParagraphMarkRunProperties();
        var runFonts104 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize146 = new FontSize { Val = "24" };
        var fontSizeComplexScript146 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties75.Append(runFonts104);
        paragraphMarkRunProperties75.Append(fontSize146);
        paragraphMarkRunProperties75.Append(fontSizeComplexScript146);

        paragraphProperties75.Append(paragraphStyleId75);
        paragraphProperties75.Append(justification4);
        paragraphProperties75.Append(paragraphMarkRunProperties75);

        var run163 = new Run();
        var runProperties162 = new RunProperties();
        var text155 = new Text
        {
            Text = "Дополнительно сообщаю следующее:"
        };

        run163.Append(runProperties162);
        run163.Append(text155);

        paragraph75.Append(paragraphProperties75);
        paragraph75.Append(run163);

        var paragraph76 = new Paragraph();

        var paragraphProperties76 = new ParagraphProperties();
        var paragraphStyleId76 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties76 = new ParagraphMarkRunProperties();
        var runFonts105 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var bold2 = new Bold();
        var bold3 = new Bold();
        var fontSize147 = new FontSize { Val = "24" };
        var fontSizeComplexScript147 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties76.Append(runFonts105);
        paragraphMarkRunProperties76.Append(bold2);
        paragraphMarkRunProperties76.Append(bold3);
        paragraphMarkRunProperties76.Append(fontSize147);
        paragraphMarkRunProperties76.Append(fontSizeComplexScript147);

        paragraphProperties76.Append(paragraphStyleId76);
        paragraphProperties76.Append(paragraphMarkRunProperties76);

        var run164 = new Run();
        var runProperties163 = new RunProperties();

        run164.Append(runProperties163);

        paragraph76.Append(paragraphProperties76);
        paragraph76.Append(run164);

        var paragraph77 = new Paragraph();

        var paragraphProperties77 = new ParagraphProperties();
        var paragraphStyleId77 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties77 = new ParagraphMarkRunProperties();
        var runFonts106 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize148 = new FontSize { Val = "24" };
        var fontSizeComplexScript148 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties77.Append(runFonts106);
        paragraphMarkRunProperties77.Append(fontSize148);
        paragraphMarkRunProperties77.Append(fontSizeComplexScript148);

        paragraphProperties77.Append(paragraphStyleId77);
        paragraphProperties77.Append(paragraphMarkRunProperties77);

        var run165 = new Run();

        var runProperties164 = new RunProperties();
        var bold4 = new Bold();
        var fontSize149 = new FontSize { Val = "24" };
        var fontSizeComplexScript149 = new FontSizeComplexScript { Val = "24" };

        runProperties164.Append(bold4);
        runProperties164.Append(fontSize149);
        runProperties164.Append(fontSizeComplexScript149);
        var text156 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "ФИО поступающего "
        };

        run165.Append(runProperties164);
        run165.Append(text156);

        var run166 = new Run();

        var runProperties165 = new RunProperties();
        var bold5 = new Bold();
        var fontSize150 = new FontSize { Val = "24" };
        var fontSizeComplexScript150 = new FontSizeComplexScript { Val = "24" };
        var underline27 = new Underline { Val = UnderlineValues.Single };
        var languages60 = new Languages { Val = "en-US" };

        runProperties165.Append(bold5);
        runProperties165.Append(fontSize150);
        runProperties165.Append(fontSizeComplexScript150);
        runProperties165.Append(underline27);
        runProperties165.Append(languages60);
        var text157 = new Text
        {
            Text = _model.FullName
        };
        var tabChar8 = new TabChar();

        run166.Append(runProperties165);
        run166.Append(text157);
        run166.Append(tabChar8);

        paragraph77.Append(paragraphProperties77);
        paragraph77.Append(run165);
        paragraph77.Append(run166);

        var paragraph78 = new Paragraph();

        var paragraphProperties78 = new ParagraphProperties();
        var paragraphStyleId78 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties78 = new ParagraphMarkRunProperties();
        var runFonts107 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize151 = new FontSize { Val = "24" };
        var fontSizeComplexScript151 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties78.Append(runFonts107);
        paragraphMarkRunProperties78.Append(fontSize151);
        paragraphMarkRunProperties78.Append(fontSizeComplexScript151);

        paragraphProperties78.Append(paragraphStyleId78);
        paragraphProperties78.Append(paragraphMarkRunProperties78);

        var run167 = new Run();
        var runProperties166 = new RunProperties();

        run167.Append(runProperties166);

        paragraph78.Append(paragraphProperties78);
        paragraph78.Append(run167);

        var paragraph79 = new Paragraph();

        var paragraphProperties79 = new ParagraphProperties();
        var paragraphStyleId79 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties79 = new ParagraphMarkRunProperties();
        var runFonts108 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize152 = new FontSize { Val = "24" };
        var fontSizeComplexScript152 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties79.Append(runFonts108);
        paragraphMarkRunProperties79.Append(fontSize152);
        paragraphMarkRunProperties79.Append(fontSizeComplexScript152);

        paragraphProperties79.Append(paragraphStyleId79);
        paragraphProperties79.Append(paragraphMarkRunProperties79);

        var run168 = new Run();

        var runProperties167 = new RunProperties();
        var bold6 = new Bold();
        var fontSize153 = new FontSize { Val = "24" };
        var fontSizeComplexScript153 = new FontSizeComplexScript { Val = "24" };

        runProperties167.Append(bold6);
        runProperties167.Append(fontSize153);
        runProperties167.Append(fontSizeComplexScript153);
        var text158 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Адрес, индекс "
        };

        run168.Append(runProperties167);
        run168.Append(text158);

        var run169 = new Run();

        var runProperties168 = new RunProperties();
        var bold7 = new Bold();
        var fontSize154 = new FontSize { Val = "24" };
        var fontSizeComplexScript154 = new FontSizeComplexScript { Val = "24" };
        var underline28 = new Underline { Val = UnderlineValues.Single };
        var languages61 = new Languages { Val = "en-US" };

        runProperties168.Append(bold7);
        runProperties168.Append(fontSize154);
        runProperties168.Append(fontSizeComplexScript154);
        runProperties168.Append(underline28);
        runProperties168.Append(languages61);
        var text159 = new Text
        {
            Text = $"{_model.Address}, {_model.PostalCode}"
        };
        var tabChar9 = new TabChar();

        run169.Append(runProperties168);
        run169.Append(text159);
        run169.Append(tabChar9);

        paragraph79.Append(paragraphProperties79);
        paragraph79.Append(run168);
        paragraph79.Append(run169);

        var paragraph80 = new Paragraph();

        var paragraphProperties80 = new ParagraphProperties();
        var paragraphStyleId80 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties80 = new ParagraphMarkRunProperties();
        var runFonts109 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var bold8 = new Bold();
        var bold9 = new Bold();
        var fontSize155 = new FontSize { Val = "24" };
        var fontSizeComplexScript155 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties80.Append(runFonts109);
        paragraphMarkRunProperties80.Append(bold8);
        paragraphMarkRunProperties80.Append(bold9);
        paragraphMarkRunProperties80.Append(fontSize155);
        paragraphMarkRunProperties80.Append(fontSizeComplexScript155);

        paragraphProperties80.Append(paragraphStyleId80);
        paragraphProperties80.Append(paragraphMarkRunProperties80);

        var run170 = new Run();
        var runProperties169 = new RunProperties();

        run170.Append(runProperties169);

        paragraph80.Append(paragraphProperties80);
        paragraph80.Append(run170);

        var paragraph81 = new Paragraph();

        var paragraphProperties81 = new ParagraphProperties();
        var paragraphStyleId81 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties81 = new ParagraphMarkRunProperties();
        var runFonts110 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize156 = new FontSize { Val = "24" };
        var fontSizeComplexScript156 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties81.Append(runFonts110);
        paragraphMarkRunProperties81.Append(fontSize156);
        paragraphMarkRunProperties81.Append(fontSizeComplexScript156);

        paragraphProperties81.Append(paragraphStyleId81);
        paragraphProperties81.Append(paragraphMarkRunProperties81);

        var run171 = new Run();

        var runProperties170 = new RunProperties();
        var bold10 = new Bold();
        var fontSize157 = new FontSize { Val = "24" };
        var fontSizeComplexScript157 = new FontSizeComplexScript { Val = "24" };

        runProperties170.Append(bold10);
        runProperties170.Append(fontSize157);
        runProperties170.Append(fontSizeComplexScript157);
        var text160 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Телефон "
        };

        run171.Append(runProperties170);
        run171.Append(text160);

        var run172 = new Run();

        var runProperties171 = new RunProperties();
        var bold11 = new Bold();
        var fontSize158 = new FontSize { Val = "24" };
        var fontSizeComplexScript158 = new FontSizeComplexScript { Val = "24" };
        var underline29 = new Underline { Val = UnderlineValues.Single };
        var languages62 = new Languages { Val = "en-US" };

        runProperties171.Append(bold11);
        runProperties171.Append(fontSize158);
        runProperties171.Append(fontSizeComplexScript158);
        runProperties171.Append(underline29);
        runProperties171.Append(languages62);
        var text161 = new Text
        {
            Text = _model.Phone
        };
        var tabChar10 = new TabChar();

        run172.Append(runProperties171);
        run172.Append(text161);
        run172.Append(tabChar10);

        paragraph81.Append(paragraphProperties81);
        paragraph81.Append(run171);
        paragraph81.Append(run172);

        var paragraph82 = new Paragraph();

        var paragraphProperties82 = new ParagraphProperties();
        var paragraphStyleId82 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties82 = new ParagraphMarkRunProperties();
        var runFonts111 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var bold12 = new Bold();
        var bold13 = new Bold();
        var fontSize159 = new FontSize { Val = "24" };
        var fontSizeComplexScript159 = new FontSizeComplexScript { Val = "24" };
        var underline30 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties82.Append(runFonts111);
        paragraphMarkRunProperties82.Append(bold12);
        paragraphMarkRunProperties82.Append(bold13);
        paragraphMarkRunProperties82.Append(fontSize159);
        paragraphMarkRunProperties82.Append(fontSizeComplexScript159);
        paragraphMarkRunProperties82.Append(underline30);

        paragraphProperties82.Append(paragraphStyleId82);
        paragraphProperties82.Append(paragraphMarkRunProperties82);

        var run173 = new Run();
        var runProperties172 = new RunProperties();

        run173.Append(runProperties172);

        paragraph82.Append(paragraphProperties82);
        paragraph82.Append(run173);

        var paragraph83 = new Paragraph();

        var paragraphProperties83 = new ParagraphProperties();
        var paragraphStyleId83 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties83 = new ParagraphMarkRunProperties();
        var bold14 = new Bold();
        var bold15 = new Bold();
        var boldComplexScript1 = new BoldComplexScript();
        var underline31 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties83.Append(bold14);
        paragraphMarkRunProperties83.Append(bold15);
        paragraphMarkRunProperties83.Append(boldComplexScript1);
        paragraphMarkRunProperties83.Append(underline31);

        paragraphProperties83.Append(paragraphStyleId83);
        paragraphProperties83.Append(paragraphMarkRunProperties83);

        var run174 = new Run();

        var runProperties173 = new RunProperties();
        var bold16 = new Bold();
        var boldComplexScript2 = new BoldComplexScript();
        var underline32 = new Underline { Val = UnderlineValues.Single };

        runProperties173.Append(bold16);
        runProperties173.Append(boldComplexScript2);
        runProperties173.Append(underline32);
        var text162 = new Text
        {
            Text = "Для поступающих на очную форму обучения"
        };

        run174.Append(runProperties173);
        run174.Append(text162);

        paragraph83.Append(paragraphProperties83);
        paragraph83.Append(run174);

        var paragraph84 = new Paragraph();

        var paragraphProperties84 = new ParagraphProperties();
        var paragraphStyleId84 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties84 = new ParagraphMarkRunProperties();
        var runFonts112 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var bold17 = new Bold();
        var bold18 = new Bold();
        var fontSize160 = new FontSize { Val = "24" };
        var fontSizeComplexScript160 = new FontSizeComplexScript { Val = "24" };
        var underline33 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties84.Append(runFonts112);
        paragraphMarkRunProperties84.Append(bold17);
        paragraphMarkRunProperties84.Append(bold18);
        paragraphMarkRunProperties84.Append(fontSize160);
        paragraphMarkRunProperties84.Append(fontSizeComplexScript160);
        paragraphMarkRunProperties84.Append(underline33);

        paragraphProperties84.Append(paragraphStyleId84);
        paragraphProperties84.Append(paragraphMarkRunProperties84);

        var run175 = new Run();
        var runProperties174 = new RunProperties();

        run175.Append(runProperties174);

        paragraph84.Append(paragraphProperties84);
        paragraph84.Append(run175);

        var paragraph85 = new Paragraph();

        var paragraphProperties85 = new ParagraphProperties();
        var paragraphStyleId85 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties85 = new ParagraphMarkRunProperties();
        var runFonts113 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize161 = new FontSize { Val = "24" };
        var fontSizeComplexScript161 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties85.Append(runFonts113);
        paragraphMarkRunProperties85.Append(fontSize161);
        paragraphMarkRunProperties85.Append(fontSizeComplexScript161);

        paragraphProperties85.Append(paragraphStyleId85);
        paragraphProperties85.Append(paragraphMarkRunProperties85);

        var run176 = new Run();

        var runProperties175 = new RunProperties();
        var fontSize162 = new FontSize { Val = "24" };
        var fontSizeComplexScript162 = new FontSizeComplexScript { Val = "24" };

        runProperties175.Append(fontSize162);
        runProperties175.Append(fontSizeComplexScript162);
        var text163 = new Text
        {
            Text = "Мать"
        };

        run176.Append(runProperties175);
        run176.Append(text163);

        var run177 = new Run();

        var runProperties176 = new RunProperties();
        var fontSize163 = new FontSize { Val = "24" };
        var fontSizeComplexScript163 = new FontSizeComplexScript { Val = "24" };
        var languages63 = new Languages { Val = "en-US" };

        runProperties176.Append(fontSize163);
        runProperties176.Append(fontSizeComplexScript163);
        runProperties176.Append(languages63);
        var text164 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " "
        };

        run177.Append(runProperties176);
        run177.Append(text164);

        var run178 = new Run();

        var runProperties177 = new RunProperties();
        var fontSize164 = new FontSize { Val = "24" };
        var fontSizeComplexScript164 = new FontSizeComplexScript { Val = "24" };
        var underline34 = new Underline { Val = UnderlineValues.Single };
        var languages64 = new Languages { Val = "en-US" };

        runProperties177.Append(fontSize164);
        runProperties177.Append(fontSizeComplexScript164);
        runProperties177.Append(underline34);
        runProperties177.Append(languages64);
        var text165 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = $" {_model.Mother?.FullName ?? string.Empty} "
        };
        var tabChar11 = new TabChar();

        run178.Append(runProperties177);
        run178.Append(text165);
        run178.Append(tabChar11);

        paragraph85.Append(paragraphProperties85);
        paragraph85.Append(run176);
        paragraph85.Append(run177);
        paragraph85.Append(run178);

        var paragraph86 = new Paragraph();

        var paragraphProperties86 = new ParagraphProperties();
        var paragraphStyleId86 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties86 = new ParagraphMarkRunProperties();
        var runFonts114 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize165 = new FontSize { Val = "24" };
        var fontSizeComplexScript165 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties86.Append(runFonts114);
        paragraphMarkRunProperties86.Append(fontSize165);
        paragraphMarkRunProperties86.Append(fontSizeComplexScript165);

        paragraphProperties86.Append(paragraphStyleId86);
        paragraphProperties86.Append(paragraphMarkRunProperties86);

        var run179 = new Run();
        var runProperties178 = new RunProperties();

        run179.Append(runProperties178);

        paragraph86.Append(paragraphProperties86);
        paragraph86.Append(run179);

        var paragraph87 = new Paragraph();

        var paragraphProperties87 = new ParagraphProperties();
        var paragraphStyleId87 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties87 = new ParagraphMarkRunProperties();
        var runFonts115 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize166 = new FontSize { Val = "24" };
        var fontSizeComplexScript166 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties87.Append(runFonts115);
        paragraphMarkRunProperties87.Append(fontSize166);
        paragraphMarkRunProperties87.Append(fontSizeComplexScript166);

        paragraphProperties87.Append(paragraphStyleId87);
        paragraphProperties87.Append(paragraphMarkRunProperties87);

        var run180 = new Run();

        var runProperties179 = new RunProperties();
        var fontSize167 = new FontSize { Val = "24" };
        var fontSizeComplexScript167 = new FontSizeComplexScript { Val = "24" };

        runProperties179.Append(fontSize167);
        runProperties179.Append(fontSizeComplexScript167);
        var text166 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Место работы/занимаемая должность "
        };

        run180.Append(runProperties179);
        run180.Append(text166);

        var run181 = new Run();

        var runProperties180 = new RunProperties();
        var fontSize168 = new FontSize { Val = "24" };
        var fontSizeComplexScript168 = new FontSizeComplexScript { Val = "24" };
        var underline35 = new Underline { Val = UnderlineValues.Single };
        var languages65 = new Languages { Val = "en-US" };

        runProperties180.Append(fontSize168);
        runProperties180.Append(fontSizeComplexScript168);
        runProperties180.Append(underline35);
        runProperties180.Append(languages65);
        var text167 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = $" {_model.Mother?.WorkDescription ?? string.Empty} "
        };
        var tabChar12 = new TabChar();

        run181.Append(runProperties180);
        run181.Append(text167);
        run181.Append(tabChar12);

        paragraph87.Append(paragraphProperties87);
        paragraph87.Append(run180);
        paragraph87.Append(run181);

        var paragraph88 = new Paragraph();

        var paragraphProperties88 = new ParagraphProperties();
        var paragraphStyleId88 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties88 = new ParagraphMarkRunProperties();
        var runFonts116 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize169 = new FontSize { Val = "24" };
        var fontSizeComplexScript169 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties88.Append(runFonts116);
        paragraphMarkRunProperties88.Append(fontSize169);
        paragraphMarkRunProperties88.Append(fontSizeComplexScript169);

        paragraphProperties88.Append(paragraphStyleId88);
        paragraphProperties88.Append(paragraphMarkRunProperties88);

        var run182 = new Run();
        var runProperties181 = new RunProperties();

        run182.Append(runProperties181);

        paragraph88.Append(paragraphProperties88);
        paragraph88.Append(run182);

        var paragraph89 = new Paragraph();

        var paragraphProperties89 = new ParagraphProperties();
        var paragraphStyleId89 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties89 = new ParagraphMarkRunProperties();
        var runFonts117 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize170 = new FontSize { Val = "24" };
        var fontSizeComplexScript170 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties89.Append(runFonts117);
        paragraphMarkRunProperties89.Append(fontSize170);
        paragraphMarkRunProperties89.Append(fontSizeComplexScript170);

        paragraphProperties89.Append(paragraphStyleId89);
        paragraphProperties89.Append(paragraphMarkRunProperties89);

        var run183 = new Run();

        var runProperties182 = new RunProperties();
        var fontSize171 = new FontSize { Val = "24" };
        var fontSizeComplexScript171 = new FontSizeComplexScript { Val = "24" };

        runProperties182.Append(fontSize171);
        runProperties182.Append(fontSizeComplexScript171);
        var text168 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Телефон домашний "
        };

        run183.Append(runProperties182);
        run183.Append(text168);

        var run187 = new Run();

        var runProperties186 = new RunProperties();
        var fontSize175 = new FontSize { Val = "24" };
        var fontSizeComplexScript175 = new FontSizeComplexScript { Val = "24" };

        runProperties186.Append(fontSize175);
        runProperties186.Append(fontSizeComplexScript175);
        var text172 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " рабочий "
        };

        run187.Append(runProperties186);
        run187.Append(text172);

        var run189 = new Run();

        var runProperties188 = new RunProperties();
        var fontSize177 = new FontSize { Val = "24" };
        var fontSizeComplexScript177 = new FontSizeComplexScript { Val = "24" };

        runProperties188.Append(fontSize177);
        runProperties188.Append(fontSizeComplexScript177);
        var text174 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " сотовый "
        };

        run189.Append(runProperties188);
        run189.Append(text174);

        paragraph89.Append(paragraphProperties89);
        paragraph89.Append(run183);
        paragraph89.Append((_model.Mother?.HomePhone ?? null).MakePhoneRun());
        paragraph89.Append(run187);
        paragraph89.Append((_model.Mother?.WorkPhone ?? null).MakePhoneRun());
        paragraph89.Append(run189);
        paragraph89.Append((_model.Mother?.MobilePhone ?? null).MakePhoneRun());

        var paragraph90 = new Paragraph();

        var paragraphProperties90 = new ParagraphProperties();
        var paragraphStyleId90 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties90 = new ParagraphMarkRunProperties();
        var runFonts118 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize179 = new FontSize { Val = "24" };
        var fontSizeComplexScript179 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties90.Append(runFonts118);
        paragraphMarkRunProperties90.Append(fontSize179);
        paragraphMarkRunProperties90.Append(fontSizeComplexScript179);

        paragraphProperties90.Append(paragraphStyleId90);
        paragraphProperties90.Append(paragraphMarkRunProperties90);

        var run191 = new Run();
        var runProperties190 = new RunProperties();

        run191.Append(runProperties190);

        paragraph90.Append(paragraphProperties90);
        paragraph90.Append(run191);

        var paragraph91 = new Paragraph();

        var paragraphProperties91 = new ParagraphProperties();
        var paragraphStyleId91 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties91 = new ParagraphMarkRunProperties();
        var runFonts119 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize180 = new FontSize { Val = "24" };
        var fontSizeComplexScript180 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties91.Append(runFonts119);
        paragraphMarkRunProperties91.Append(fontSize180);
        paragraphMarkRunProperties91.Append(fontSizeComplexScript180);

        paragraphProperties91.Append(paragraphStyleId91);
        paragraphProperties91.Append(paragraphMarkRunProperties91);

        var run192 = new Run();

        var runProperties191 = new RunProperties();
        var fontSize181 = new FontSize { Val = "24" };
        var fontSizeComplexScript181 = new FontSizeComplexScript { Val = "24" };

        runProperties191.Append(fontSize181);
        runProperties191.Append(fontSizeComplexScript181);
        var text176 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Отец "
        };

        run192.Append(runProperties191);
        run192.Append(text176);

        var run193 = new Run();

        var runProperties192 = new RunProperties();
        var fontSize182 = new FontSize { Val = "24" };
        var fontSizeComplexScript182 = new FontSizeComplexScript { Val = "24" };
        var underline41 = new Underline { Val = UnderlineValues.Single };
        var languages71 = new Languages { Val = "en-US" };

        runProperties192.Append(fontSize182);
        runProperties192.Append(fontSizeComplexScript182);
        runProperties192.Append(underline41);
        runProperties192.Append(languages71);
        var text177 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = $" {_model.Father?.FullName ?? string.Empty} "
        };
        var tabChar13 = new TabChar();

        run193.Append(runProperties192);
        run193.Append(text177);
        run193.Append(tabChar13);

        paragraph91.Append(paragraphProperties91);
        paragraph91.Append(run192);
        paragraph91.Append(run193);

        var paragraph92 = new Paragraph();

        var paragraphProperties92 = new ParagraphProperties();
        var paragraphStyleId92 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties92 = new ParagraphMarkRunProperties();
        var runFonts120 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize183 = new FontSize { Val = "24" };
        var fontSizeComplexScript183 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties92.Append(runFonts120);
        paragraphMarkRunProperties92.Append(fontSize183);
        paragraphMarkRunProperties92.Append(fontSizeComplexScript183);

        paragraphProperties92.Append(paragraphStyleId92);
        paragraphProperties92.Append(paragraphMarkRunProperties92);

        var run194 = new Run();
        var runProperties193 = new RunProperties();

        run194.Append(runProperties193);

        paragraph92.Append(paragraphProperties92);
        paragraph92.Append(run194);

        var paragraph93 = new Paragraph();

        var paragraphProperties93 = new ParagraphProperties();
        var paragraphStyleId93 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties93 = new ParagraphMarkRunProperties();
        var runFonts121 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize184 = new FontSize { Val = "24" };
        var fontSizeComplexScript184 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties93.Append(runFonts121);
        paragraphMarkRunProperties93.Append(fontSize184);
        paragraphMarkRunProperties93.Append(fontSizeComplexScript184);

        paragraphProperties93.Append(paragraphStyleId93);
        paragraphProperties93.Append(paragraphMarkRunProperties93);

        var run195 = new Run();

        var runProperties194 = new RunProperties();
        var fontSize185 = new FontSize { Val = "24" };
        var fontSizeComplexScript185 = new FontSizeComplexScript { Val = "24" };

        runProperties194.Append(fontSize185);
        runProperties194.Append(fontSizeComplexScript185);
        var text178 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Место работы/занимаемая должность "
        };

        run195.Append(runProperties194);
        run195.Append(text178);

        var run196 = new Run();

        var runProperties195 = new RunProperties();
        var fontSize186 = new FontSize { Val = "24" };
        var fontSizeComplexScript186 = new FontSizeComplexScript { Val = "24" };
        var underline42 = new Underline { Val = UnderlineValues.Single };
        var languages72 = new Languages { Val = "en-US" };

        runProperties195.Append(fontSize186);
        runProperties195.Append(fontSizeComplexScript186);
        runProperties195.Append(underline42);
        runProperties195.Append(languages72);
        var text179 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = $" {_model.Father?.WorkDescription ?? string.Empty} "
        };
        var tabChar14 = new TabChar();

        run196.Append(runProperties195);
        run196.Append(text179);
        run196.Append(tabChar14);

        paragraph93.Append(paragraphProperties93);
        paragraph93.Append(run195);
        paragraph93.Append(run196);

        var paragraph94 = new Paragraph();

        var paragraphProperties94 = new ParagraphProperties();
        var paragraphStyleId94 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties94 = new ParagraphMarkRunProperties();
        var runFonts122 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize187 = new FontSize { Val = "24" };
        var fontSizeComplexScript187 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties94.Append(runFonts122);
        paragraphMarkRunProperties94.Append(fontSize187);
        paragraphMarkRunProperties94.Append(fontSizeComplexScript187);

        paragraphProperties94.Append(paragraphStyleId94);
        paragraphProperties94.Append(paragraphMarkRunProperties94);

        var run197 = new Run();
        var runProperties196 = new RunProperties();

        run197.Append(runProperties196);

        paragraph94.Append(paragraphProperties94);
        paragraph94.Append(run197);

        var paragraph95 = new Paragraph();

        var paragraphProperties95 = new ParagraphProperties();
        var paragraphStyleId95 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties95 = new ParagraphMarkRunProperties();
        var runFonts123 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize188 = new FontSize { Val = "24" };
        var fontSizeComplexScript188 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties95.Append(runFonts123);
        paragraphMarkRunProperties95.Append(fontSize188);
        paragraphMarkRunProperties95.Append(fontSizeComplexScript188);

        paragraphProperties95.Append(paragraphStyleId95);
        paragraphProperties95.Append(paragraphMarkRunProperties95);

        var run198 = new Run();

        var runProperties197 = new RunProperties();
        var fontSize189 = new FontSize { Val = "24" };
        var fontSizeComplexScript189 = new FontSizeComplexScript { Val = "24" };

        runProperties197.Append(fontSize189);
        runProperties197.Append(fontSizeComplexScript189);
        var text180 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Телефон домашний "
        };

        run198.Append(runProperties197);
        run198.Append(text180);

        var run201 = new Run();

        var runProperties200 = new RunProperties();
        var fontSize192 = new FontSize { Val = "24" };
        var fontSizeComplexScript192 = new FontSizeComplexScript { Val = "24" };
        var underline45 = new Underline { Val = UnderlineValues.None };

        runProperties200.Append(fontSize192);
        runProperties200.Append(fontSizeComplexScript192);
        runProperties200.Append(underline45);
        var text183 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " рабочий "
        };

        run201.Append(runProperties200);
        run201.Append(text183);

        var run204 = new Run();

        var runProperties203 = new RunProperties();
        var fontSize195 = new FontSize { Val = "24" };
        var fontSizeComplexScript195 = new FontSizeComplexScript { Val = "24" };

        runProperties203.Append(fontSize195);
        runProperties203.Append(fontSizeComplexScript195);
        var text186 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = " сотовый "
        };

        run204.Append(runProperties203);
        run204.Append(text186);

        paragraph95.Append(paragraphProperties95);
        paragraph95.Append(run198);
        paragraph95.Append((_model.Father?.HomePhone ?? null).MakePhoneRun());
        paragraph95.Append(run201);
        paragraph95.Append((_model.Father?.WorkPhone ?? null).MakePhoneRun());
        paragraph95.Append(run204);
        paragraph95.Append((_model.Father?.MobilePhone ?? null).MakePhoneRun());

        var paragraph96 = new Paragraph();

        var paragraphProperties96 = new ParagraphProperties();
        var paragraphStyleId96 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties96 = new ParagraphMarkRunProperties();
        var runFonts124 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize197 = new FontSize { Val = "24" };
        var fontSizeComplexScript197 = new FontSizeComplexScript { Val = "24" };
        var underline48 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties96.Append(runFonts124);
        paragraphMarkRunProperties96.Append(fontSize197);
        paragraphMarkRunProperties96.Append(fontSizeComplexScript197);
        paragraphMarkRunProperties96.Append(underline48);

        paragraphProperties96.Append(paragraphStyleId96);
        paragraphProperties96.Append(paragraphMarkRunProperties96);

        var run206 = new Run();
        var runProperties205 = new RunProperties();

        run206.Append(runProperties205);

        paragraph96.Append(paragraphProperties96);
        paragraph96.Append(run206);

        var paragraph97 = new Paragraph();

        var paragraphProperties97 = new ParagraphProperties();
        var paragraphStyleId97 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties97 = new ParagraphMarkRunProperties();
        var bold19 = new Bold();
        var bold20 = new Bold();
        var boldComplexScript3 = new BoldComplexScript();
        var underline49 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties97.Append(bold19);
        paragraphMarkRunProperties97.Append(bold20);
        paragraphMarkRunProperties97.Append(boldComplexScript3);
        paragraphMarkRunProperties97.Append(underline49);

        paragraphProperties97.Append(paragraphStyleId97);
        paragraphProperties97.Append(paragraphMarkRunProperties97);

        var run207 = new Run();

        var runProperties206 = new RunProperties();
        var bold21 = new Bold();
        var boldComplexScript4 = new BoldComplexScript();
        var underline50 = new Underline { Val = UnderlineValues.Single };

        runProperties206.Append(bold21);
        runProperties206.Append(boldComplexScript4);
        runProperties206.Append(underline50);
        var text188 = new Text
        {
            Text = "Для поступающих на заочную форму обучения"
        };

        run207.Append(runProperties206);
        run207.Append(text188);

        paragraph97.Append(paragraphProperties97);
        paragraph97.Append(run207);

        var paragraph98 = new Paragraph();

        var paragraphProperties98 = new ParagraphProperties();
        var paragraphStyleId98 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties98 = new ParagraphMarkRunProperties();
        var runFonts125 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var bold22 = new Bold();
        var bold23 = new Bold();
        var fontSize198 = new FontSize { Val = "24" };
        var fontSizeComplexScript198 = new FontSizeComplexScript { Val = "24" };
        var underline51 = new Underline { Val = UnderlineValues.Single };

        paragraphMarkRunProperties98.Append(runFonts125);
        paragraphMarkRunProperties98.Append(bold22);
        paragraphMarkRunProperties98.Append(bold23);
        paragraphMarkRunProperties98.Append(fontSize198);
        paragraphMarkRunProperties98.Append(fontSizeComplexScript198);
        paragraphMarkRunProperties98.Append(underline51);

        paragraphProperties98.Append(paragraphStyleId98);
        paragraphProperties98.Append(paragraphMarkRunProperties98);

        var run208 = new Run();
        var runProperties207 = new RunProperties();

        run208.Append(runProperties207);

        paragraph98.Append(paragraphProperties98);
        paragraph98.Append(run208);

        var paragraph99 = new Paragraph();

        var paragraphProperties99 = new ParagraphProperties();
        var paragraphStyleId99 = new ParagraphStyleId { Val = "AdditionalInfo" };

        var paragraphMarkRunProperties99 = new ParagraphMarkRunProperties();
        var runFonts126 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize199 = new FontSize { Val = "24" };
        var fontSizeComplexScript199 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties99.Append(runFonts126);
        paragraphMarkRunProperties99.Append(fontSize199);
        paragraphMarkRunProperties99.Append(fontSizeComplexScript199);

        paragraphProperties99.Append(paragraphStyleId99);
        paragraphProperties99.Append(paragraphMarkRunProperties99);

        var run209 = new Run();

        var runProperties208 = new RunProperties();
        var fontSize200 = new FontSize { Val = "24" };
        var fontSizeComplexScript200 = new FontSizeComplexScript { Val = "24" };

        runProperties208.Append(fontSize200);
        runProperties208.Append(fontSizeComplexScript200);
        var text189 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Место работы и занимаемая должность "
        };

        run209.Append(runProperties208);
        run209.Append(text189);

        var run210 = new Run();

        var runProperties209 = new RunProperties();
        var fontSize201 = new FontSize { Val = "24" };
        var fontSizeComplexScript201 = new FontSizeComplexScript { Val = "24" };
        var underline52 = new Underline { Val = UnderlineValues.Single };
        var languages77 = new Languages { Val = "en-US" };

        runProperties209.Append(fontSize201);
        runProperties209.Append(fontSizeComplexScript201);
        runProperties209.Append(underline52);
        runProperties209.Append(languages77);
        var text190 = new Text
        {
            Text = _model.DistanceApplicantWorkDescription ?? string.Empty
        };
        var tabChar15 = new TabChar();

        run210.Append(runProperties209);
        run210.Append(text190);
        run210.Append(tabChar15);

        paragraph99.Append(paragraphProperties99);
        paragraph99.Append(run209);
        paragraph99.Append(run210);

        var paragraph100 = new Paragraph();

        var paragraphProperties100 = new ParagraphProperties();
        var paragraphStyleId100 = new ParagraphStyleId { Val = "Normal" };
        var widowControl45 = new WidowControl();

        var paragraphMarkRunProperties100 = new ParagraphMarkRunProperties();
        var runFonts127 = new RunFonts { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
        var fontSize202 = new FontSize { Val = "24" };
        var fontSizeComplexScript202 = new FontSizeComplexScript { Val = "24" };

        paragraphMarkRunProperties100.Append(runFonts127);
        paragraphMarkRunProperties100.Append(fontSize202);
        paragraphMarkRunProperties100.Append(fontSizeComplexScript202);

        paragraphProperties100.Append(paragraphStyleId100);
        paragraphProperties100.Append(widowControl45);
        paragraphProperties100.Append(paragraphMarkRunProperties100);

        var run211 = new Run();
        var runProperties210 = new RunProperties();

        run211.Append(runProperties210);

        paragraph100.Append(paragraphProperties100);
        paragraph100.Append(run211);

        var sectionProperties1 = new SectionProperties();
        var sectionType1 = new SectionType { Val = SectionMarkValues.NextPage };
        var pageSize1 = new PageSize { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
        var pageMargin1 = new PageMargin
        {
            Top = 568,
            Right = (UInt32Value)850U,
            Bottom = 142,
            Left = (UInt32Value)840U,
            Header = (UInt32Value)0U,
            Footer = (UInt32Value)0U,
            Gutter = (UInt32Value)0U
        };
        var pageNumberType1 = new PageNumberType { Format = NumberFormatValues.Decimal };
        var formProtection1 = new FormProtection { Val = false };
        var textDirection1 = new TextDirection { Val = TextDirectionValues.LefToRightTopToBottom };
        var docGrid1 = new DocGrid { Type = DocGridValues.Default, LinePitch = 360, CharacterSpace = 0 };

        sectionProperties1.Append(sectionType1);
        sectionProperties1.Append(pageSize1);
        sectionProperties1.Append(pageMargin1);
        sectionProperties1.Append(pageNumberType1);
        sectionProperties1.Append(formProtection1);
        sectionProperties1.Append(textDirection1);
        sectionProperties1.Append(docGrid1);

        body1.Append(table1);
        body1.Append(paragraph13);
        body1.Append(paragraph14);
        body1.Append(paragraph15);
        body1.Append(paragraph16);
        body1.Append(paragraph17);
        body1.Append(paragraph18);
        body1.Append(paragraph19);
        body1.Append(paragraph20);
        body1.Append(table2);
        body1.Append(paragraph51);
        body1.Append(paragraph52);
        body1.Append(paragraph53);
        body1.Append(paragraph54);
        body1.Append(paragraph55);
        body1.Append(paragraph56);
        body1.Append(paragraph57);
        body1.Append(paragraph58);
        body1.Append(paragraph59);
        body1.Append(paragraph60);
        body1.Append(paragraph61);
        body1.Append(paragraph62);
        body1.Append(paragraph63);
        body1.Append(paragraph64);
        body1.Append(paragraph65);
        body1.Append(paragraph66);
        body1.Append(paragraph67);
        body1.Append(paragraph68);
        body1.Append(paragraph69);
        body1.Append(paragraph70);
        body1.Append(paragraph71);
        body1.Append(paragraph72);
        body1.Append(paragraph73);
        body1.Append(paragraph74);
        body1.Append(paragraph75);
        body1.Append(paragraph76);
        body1.Append(paragraph77);
        body1.Append(paragraph78);
        body1.Append(paragraph79);
        body1.Append(paragraph80);
        body1.Append(paragraph81);
        body1.Append(paragraph82);
        body1.Append(paragraph83);
        body1.Append(paragraph84);
        body1.Append(paragraph85);
        body1.Append(paragraph86);
        body1.Append(paragraph87);
        body1.Append(paragraph88);
        body1.Append(paragraph89);
        body1.Append(paragraph90);
        body1.Append(paragraph91);
        body1.Append(paragraph92);
        body1.Append(paragraph93);
        body1.Append(paragraph94);
        body1.Append(paragraph95);
        body1.Append(paragraph96);
        body1.Append(paragraph97);
        body1.Append(paragraph98);
        body1.Append(paragraph99);
        body1.Append(paragraph100);
        body1.Append(sectionProperties1);

        document1.Append(body1);

        mainDocumentPart1.Document = document1;
    }

    // Generates content of styleDefinitionsPart1.
    private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
    {
        var styles1 = new Styles { MCAttributes = new MarkupCompatibilityAttributes { Ignorable = "w14" } };
        styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
        styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
        styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

        var docDefaults1 = new DocDefaults();

        var runPropertiesDefault1 = new RunPropertiesDefault();

        var runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
        var runFonts128 = new RunFonts
        {
            Ascii = "Liberation Serif",
            HighAnsi = "Liberation Serif",
            EastAsia = "NSimSun",
            ComplexScript = "Arial"
        };
        var fontSize203 = new FontSize { Val = "24" };
        var fontSizeComplexScript203 = new FontSizeComplexScript { Val = "24" };
        var languages78 = new Languages { Val = "en-US", EastAsia = "zh-CN", Bidi = "hi-IN" };

        runPropertiesBaseStyle1.Append(runFonts128);
        runPropertiesBaseStyle1.Append(fontSize203);
        runPropertiesBaseStyle1.Append(fontSizeComplexScript203);
        runPropertiesBaseStyle1.Append(languages78);

        runPropertiesDefault1.Append(runPropertiesBaseStyle1);

        var paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

        var paragraphPropertiesBaseStyle1 = new ParagraphPropertiesBaseStyle();
        var suppressAutoHyphens1 = new SuppressAutoHyphens { Val = true };

        paragraphPropertiesBaseStyle1.Append(suppressAutoHyphens1);

        paragraphPropertiesDefault1.Append(paragraphPropertiesBaseStyle1);

        docDefaults1.Append(runPropertiesDefault1);
        docDefaults1.Append(paragraphPropertiesDefault1);

        var style1 = new Style { Type = StyleValues.Paragraph, StyleId = "Normal" };
        var styleName1 = new StyleName { Val = "Normal" };
        var primaryStyle1 = new PrimaryStyle();

        var styleParagraphProperties1 = new StyleParagraphProperties();
        var widowControl46 = new WidowControl();
        var suppressAutoHyphens2 = new SuppressAutoHyphens { Val = true };
        var biDi1 = new BiDi { Val = false };
        var spacingBetweenLines31 = new SpacingBetweenLines { Before = "0", After = "0" };
        var justification5 = new Justification { Val = JustificationValues.Both };

        styleParagraphProperties1.Append(widowControl46);
        styleParagraphProperties1.Append(suppressAutoHyphens2);
        styleParagraphProperties1.Append(biDi1);
        styleParagraphProperties1.Append(spacingBetweenLines31);
        styleParagraphProperties1.Append(justification5);

        var styleRunProperties1 = new StyleRunProperties();
        var runFonts129 = new RunFonts
        {
            Ascii = "Times New Roman",
            HighAnsi = "Times New Roman",
            EastAsia = "Times New Roman",
            ComplexScript = "Times New Roman"
        };
        var color3 = new Color { Val = "auto" };
        var kern1 = new Kern { Val = (UInt32Value)0U };
        var fontSize204 = new FontSize { Val = "28" };
        var fontSizeComplexScript204 = new FontSizeComplexScript { Val = "20" };
        var languages79 = new Languages { Val = "ru-RU", EastAsia = "zh-CN", Bidi = "ar-SA" };

        styleRunProperties1.Append(runFonts129);
        styleRunProperties1.Append(color3);
        styleRunProperties1.Append(kern1);
        styleRunProperties1.Append(fontSize204);
        styleRunProperties1.Append(fontSizeComplexScript204);
        styleRunProperties1.Append(languages79);

        style1.Append(styleName1);
        style1.Append(primaryStyle1);
        style1.Append(styleParagraphProperties1);
        style1.Append(styleRunProperties1);

        var style2 = new Style { Type = StyleValues.Character, StyleId = "Style14" };
        var styleName2 = new StyleName { Val = "Основной шрифт абзаца" };
        var primaryStyle2 = new PrimaryStyle();
        var styleRunProperties2 = new StyleRunProperties();

        style2.Append(styleName2);
        style2.Append(primaryStyle2);
        style2.Append(styleRunProperties2);

        var style3 = new Style { Type = StyleValues.Paragraph, StyleId = "Heading" };
        var styleName3 = new StyleName { Val = "Heading" };
        var basedOn1 = new BasedOn { Val = "Normal" };
        var nextParagraphStyle1 = new NextParagraphStyle { Val = "TextBody" };
        var primaryStyle3 = new PrimaryStyle();

        var styleParagraphProperties2 = new StyleParagraphProperties();
        var keepNext1 = new KeepNext { Val = true };
        var spacingBetweenLines32 = new SpacingBetweenLines { Before = "240", After = "120" };

        styleParagraphProperties2.Append(keepNext1);
        styleParagraphProperties2.Append(spacingBetweenLines32);

        var styleRunProperties3 = new StyleRunProperties();
        var runFonts130 = new RunFonts
        {
            Ascii = "Liberation Sans",
            HighAnsi = "Liberation Sans",
            EastAsia = "Microsoft YaHei",
            ComplexScript = "Arial"
        };
        var fontSize205 = new FontSize { Val = "28" };
        var fontSizeComplexScript205 = new FontSizeComplexScript { Val = "28" };

        styleRunProperties3.Append(runFonts130);
        styleRunProperties3.Append(fontSize205);
        styleRunProperties3.Append(fontSizeComplexScript205);

        style3.Append(styleName3);
        style3.Append(basedOn1);
        style3.Append(nextParagraphStyle1);
        style3.Append(primaryStyle3);
        style3.Append(styleParagraphProperties2);
        style3.Append(styleRunProperties3);

        var style4 = new Style { Type = StyleValues.Paragraph, StyleId = "TextBody" };
        var styleName4 = new StyleName { Val = "Body Text" };
        var basedOn2 = new BasedOn { Val = "Normal" };

        var styleParagraphProperties3 = new StyleParagraphProperties();
        var spacingBetweenLines33 = new SpacingBetweenLines
        { Before = "0", After = "140", Line = "276", LineRule = LineSpacingRuleValues.Auto };

        styleParagraphProperties3.Append(spacingBetweenLines33);
        var styleRunProperties4 = new StyleRunProperties();

        style4.Append(styleName4);
        style4.Append(basedOn2);
        style4.Append(styleParagraphProperties3);
        style4.Append(styleRunProperties4);

        var style5 = new Style { Type = StyleValues.Paragraph, StyleId = "List" };
        var styleName5 = new StyleName { Val = "List" };
        var basedOn3 = new BasedOn { Val = "TextBody" };
        var styleParagraphProperties4 = new StyleParagraphProperties();

        var styleRunProperties5 = new StyleRunProperties();
        var runFonts131 = new RunFonts { ComplexScript = "Arial" };

        styleRunProperties5.Append(runFonts131);

        style5.Append(styleName5);
        style5.Append(basedOn3);
        style5.Append(styleParagraphProperties4);
        style5.Append(styleRunProperties5);

        var style6 = new Style { Type = StyleValues.Paragraph, StyleId = "Caption" };
        var styleName6 = new StyleName { Val = "Caption" };
        var basedOn4 = new BasedOn { Val = "Normal" };
        var primaryStyle4 = new PrimaryStyle();

        var styleParagraphProperties5 = new StyleParagraphProperties();
        var suppressLineNumbers1 = new SuppressLineNumbers();
        var spacingBetweenLines34 = new SpacingBetweenLines { Before = "120", After = "120" };

        styleParagraphProperties5.Append(suppressLineNumbers1);
        styleParagraphProperties5.Append(spacingBetweenLines34);

        var styleRunProperties6 = new StyleRunProperties();
        var runFonts132 = new RunFonts { ComplexScript = "Arial" };
        var italic2 = new Italic();
        var italicComplexScript2 = new ItalicComplexScript();
        var fontSize206 = new FontSize { Val = "24" };
        var fontSizeComplexScript206 = new FontSizeComplexScript { Val = "24" };

        styleRunProperties6.Append(runFonts132);
        styleRunProperties6.Append(italic2);
        styleRunProperties6.Append(italicComplexScript2);
        styleRunProperties6.Append(fontSize206);
        styleRunProperties6.Append(fontSizeComplexScript206);

        style6.Append(styleName6);
        style6.Append(basedOn4);
        style6.Append(primaryStyle4);
        style6.Append(styleParagraphProperties5);
        style6.Append(styleRunProperties6);

        var style7 = new Style { Type = StyleValues.Paragraph, StyleId = "Index" };
        var styleName7 = new StyleName { Val = "Index" };
        var basedOn5 = new BasedOn { Val = "Normal" };
        var primaryStyle5 = new PrimaryStyle();

        var styleParagraphProperties6 = new StyleParagraphProperties();
        var suppressLineNumbers2 = new SuppressLineNumbers();

        styleParagraphProperties6.Append(suppressLineNumbers2);

        var styleRunProperties7 = new StyleRunProperties();
        var runFonts133 = new RunFonts { ComplexScript = "Arial" };
        var languages80 = new Languages { Val = "zxx", EastAsia = "zxx", Bidi = "zxx" };

        styleRunProperties7.Append(runFonts133);
        styleRunProperties7.Append(languages80);

        style7.Append(styleName7);
        style7.Append(basedOn5);
        style7.Append(primaryStyle5);
        style7.Append(styleParagraphProperties6);
        style7.Append(styleRunProperties7);

        var style8 = new Style { Type = StyleValues.Paragraph, StyleId = "TableContents" };
        var styleName8 = new StyleName { Val = "Table Contents" };
        var basedOn6 = new BasedOn { Val = "Normal" };
        var primaryStyle6 = new PrimaryStyle();

        var styleParagraphProperties7 = new StyleParagraphProperties();
        var widowControl47 = new WidowControl { Val = false };
        var suppressLineNumbers3 = new SuppressLineNumbers();

        styleParagraphProperties7.Append(widowControl47);
        styleParagraphProperties7.Append(suppressLineNumbers3);
        var styleRunProperties8 = new StyleRunProperties();

        style8.Append(styleName8);
        style8.Append(basedOn6);
        style8.Append(primaryStyle6);
        style8.Append(styleParagraphProperties7);
        style8.Append(styleRunProperties8);

        var style9 = new Style { Type = StyleValues.Paragraph, StyleId = "TableHeading" };
        var styleName9 = new StyleName { Val = "Table Heading" };
        var basedOn7 = new BasedOn { Val = "TableContents" };
        var primaryStyle7 = new PrimaryStyle();

        var styleParagraphProperties8 = new StyleParagraphProperties();
        var suppressLineNumbers4 = new SuppressLineNumbers();
        var justification6 = new Justification { Val = JustificationValues.Center };

        styleParagraphProperties8.Append(suppressLineNumbers4);
        styleParagraphProperties8.Append(justification6);

        var styleRunProperties9 = new StyleRunProperties();
        var bold24 = new Bold();
        var boldComplexScript5 = new BoldComplexScript();

        styleRunProperties9.Append(bold24);
        styleRunProperties9.Append(boldComplexScript5);

        style9.Append(styleName9);
        style9.Append(basedOn7);
        style9.Append(primaryStyle7);
        style9.Append(styleParagraphProperties8);
        style9.Append(styleRunProperties9);

        var style10 = new Style { Type = StyleValues.Paragraph, StyleId = "TableBody" };
        var styleName10 = new StyleName { Val = "Table Body" };
        var basedOn8 = new BasedOn { Val = "TextBody" };
        var primaryStyle8 = new PrimaryStyle();

        var styleParagraphProperties9 = new StyleParagraphProperties();
        var widowControl48 = new WidowControl { Val = false };
        var spacingBetweenLines35 = new SpacingBetweenLines { Before = "0", After = "140" };

        styleParagraphProperties9.Append(widowControl48);
        styleParagraphProperties9.Append(spacingBetweenLines35);

        var styleRunProperties10 = new StyleRunProperties();
        var fontSize207 = new FontSize { Val = "24" };
        var fontSizeComplexScript207 = new FontSizeComplexScript { Val = "24" };

        styleRunProperties10.Append(fontSize207);
        styleRunProperties10.Append(fontSizeComplexScript207);

        style10.Append(styleName10);
        style10.Append(basedOn8);
        style10.Append(primaryStyle8);
        style10.Append(styleParagraphProperties9);
        style10.Append(styleRunProperties10);

        var style11 = new Style { Type = StyleValues.Paragraph, StyleId = "DocumentTitle" };
        var styleName11 = new StyleName { Val = "Document Title" };
        var basedOn9 = new BasedOn { Val = "Normal" };
        var primaryStyle9 = new PrimaryStyle();

        var styleParagraphProperties10 = new StyleParagraphProperties();
        var justification7 = new Justification { Val = JustificationValues.Center };

        styleParagraphProperties10.Append(justification7);
        var styleRunProperties11 = new StyleRunProperties();

        style11.Append(styleName11);
        style11.Append(basedOn9);
        style11.Append(primaryStyle9);
        style11.Append(styleParagraphProperties10);
        style11.Append(styleRunProperties11);

        var style12 = new Style { Type = StyleValues.Paragraph, StyleId = "MainBody" };
        var styleName12 = new StyleName { Val = "Main Body" };
        var basedOn10 = new BasedOn { Val = "Normal" };
        var primaryStyle10 = new PrimaryStyle();

        var styleParagraphProperties11 = new StyleParagraphProperties();
        var widowControl49 = new WidowControl();

        var tabs3 = new Tabs();
        var tabStop7 = new TabStop { Val = TabStopValues.Clear, Position = 708 };
        var tabStop8 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10080 };
        var tabStop9 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10173 };

        tabs3.Append(tabStop7);
        tabs3.Append(tabStop8);
        tabs3.Append(tabStop9);
        var suppressAutoHyphens3 = new SuppressAutoHyphens { Val = true };
        var biDi2 = new BiDi { Val = false };
        var spacingBetweenLines36 = new SpacingBetweenLines { Before = "0", After = "0" };
        var indentation1 = new Indentation { Hanging = "0" };
        var justification8 = new Justification { Val = JustificationValues.Both };

        styleParagraphProperties11.Append(widowControl49);
        styleParagraphProperties11.Append(tabs3);
        styleParagraphProperties11.Append(suppressAutoHyphens3);
        styleParagraphProperties11.Append(biDi2);
        styleParagraphProperties11.Append(spacingBetweenLines36);
        styleParagraphProperties11.Append(indentation1);
        styleParagraphProperties11.Append(justification8);

        var styleRunProperties12 = new StyleRunProperties();
        var fontSize208 = new FontSize { Val = "24" };

        styleRunProperties12.Append(fontSize208);

        style12.Append(styleName12);
        style12.Append(basedOn10);
        style12.Append(primaryStyle10);
        style12.Append(styleParagraphProperties11);
        style12.Append(styleRunProperties12);

        var style13 = new Style { Type = StyleValues.Paragraph, StyleId = "FieldDescription" };
        var styleName13 = new StyleName { Val = "Field Description" };
        var basedOn11 = new BasedOn { Val = "Normal" };
        var primaryStyle11 = new PrimaryStyle();

        var styleParagraphProperties12 = new StyleParagraphProperties();
        var justification9 = new Justification { Val = JustificationValues.Center };

        styleParagraphProperties12.Append(justification9);
        var styleRunProperties13 = new StyleRunProperties();

        style13.Append(styleName13);
        style13.Append(basedOn11);
        style13.Append(primaryStyle11);
        style13.Append(styleParagraphProperties12);
        style13.Append(styleRunProperties13);

        var style14 = new Style { Type = StyleValues.Paragraph, StyleId = "FieldDescriptionR" };
        var styleName14 = new StyleName { Val = "Field Description R" };
        var primaryStyle12 = new PrimaryStyle();

        var styleParagraphProperties13 = new StyleParagraphProperties();
        var widowControl50 = new WidowControl();
        var suppressAutoHyphens4 = new SuppressAutoHyphens { Val = true };
        var biDi3 = new BiDi { Val = false };
        var spacingBetweenLines37 = new SpacingBetweenLines { Before = "0", After = "0" };
        var justification10 = new Justification { Val = JustificationValues.End };

        styleParagraphProperties13.Append(widowControl50);
        styleParagraphProperties13.Append(suppressAutoHyphens4);
        styleParagraphProperties13.Append(biDi3);
        styleParagraphProperties13.Append(spacingBetweenLines37);
        styleParagraphProperties13.Append(justification10);

        var styleRunProperties14 = new StyleRunProperties();
        var runFonts134 = new RunFonts
        { Ascii = "Times New Roman", HighAnsi = "Times New Roman", EastAsia = "NSimSun", ComplexScript = "Arial" };
        var color4 = new Color { Val = "auto" };
        var kern2 = new Kern { Val = (UInt32Value)0U };
        var fontSize209 = new FontSize { Val = "24" };
        var fontSizeComplexScript208 = new FontSizeComplexScript { Val = "24" };
        var languages81 = new Languages { Val = "en-US", EastAsia = "zh-CN", Bidi = "hi-IN" };

        styleRunProperties14.Append(runFonts134);
        styleRunProperties14.Append(color4);
        styleRunProperties14.Append(kern2);
        styleRunProperties14.Append(fontSize209);
        styleRunProperties14.Append(fontSizeComplexScript208);
        styleRunProperties14.Append(languages81);

        style14.Append(styleName14);
        style14.Append(primaryStyle12);
        style14.Append(styleParagraphProperties13);
        style14.Append(styleRunProperties14);

        var style15 = new Style { Type = StyleValues.Paragraph, StyleId = "MainBodyL" };
        var styleName15 = new StyleName { Val = "Main Body L" };
        var basedOn12 = new BasedOn { Val = "MainBody" };
        var primaryStyle13 = new PrimaryStyle();

        var styleParagraphProperties14 = new StyleParagraphProperties();
        var justification11 = new Justification { Val = JustificationValues.End };

        styleParagraphProperties14.Append(justification11);

        var styleRunProperties15 = new StyleRunProperties();
        var fontSize210 = new FontSize { Val = "28" };
        var fontSizeComplexScript209 = new FontSizeComplexScript { Val = "28" };

        styleRunProperties15.Append(fontSize210);
        styleRunProperties15.Append(fontSizeComplexScript209);

        style15.Append(styleName15);
        style15.Append(basedOn12);
        style15.Append(primaryStyle13);
        style15.Append(styleParagraphProperties14);
        style15.Append(styleRunProperties15);

        var style16 = new Style { Type = StyleValues.Paragraph, StyleId = "AdditionalInfo" };
        var styleName16 = new StyleName { Val = "Additional Info" };
        var basedOn13 = new BasedOn { Val = "Normal" };
        var primaryStyle14 = new PrimaryStyle();

        var styleParagraphProperties15 = new StyleParagraphProperties();

        var tabs4 = new Tabs();
        var tabStop10 = new TabStop { Val = TabStopValues.Clear, Position = 708 };
        var tabStop11 = new TabStop
        { Val = TabStopValues.Left, Leader = TabStopLeaderCharValues.None, Position = 10080 };

        tabs4.Append(tabStop10);
        tabs4.Append(tabStop11);
        var indentation2 = new Indentation { End = "-2", Hanging = "0" };
        var justification12 = new Justification { Val = JustificationValues.Start };

        styleParagraphProperties15.Append(tabs4);
        styleParagraphProperties15.Append(indentation2);
        styleParagraphProperties15.Append(justification12);
        var styleRunProperties16 = new StyleRunProperties();

        style16.Append(styleName16);
        style16.Append(basedOn13);
        style16.Append(primaryStyle14);
        style16.Append(styleParagraphProperties15);
        style16.Append(styleRunProperties16);

        styles1.Append(docDefaults1);
        styles1.Append(style1);
        styles1.Append(style2);
        styles1.Append(style3);
        styles1.Append(style4);
        styles1.Append(style5);
        styles1.Append(style6);
        styles1.Append(style7);
        styles1.Append(style8);
        styles1.Append(style9);
        styles1.Append(style10);
        styles1.Append(style11);
        styles1.Append(style12);
        styles1.Append(style13);
        styles1.Append(style14);
        styles1.Append(style15);
        styles1.Append(style16);

        styleDefinitionsPart1.Styles = styles1;
    }

    // Generates content of fontTablePart1.
    private void GenerateFontTablePart1Content(FontTablePart fontTablePart1)
    {
        var fonts1 = new Fonts();
        fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
        fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

        var font1 = new Font { Name = "Times New Roman" };
        var fontCharSet1 = new FontCharSet
        { Val = "00", StrictCharacterSet = new EnumValue<StrictCharacterSet> { InnerText = "windows-1252" } };
        var fontFamily1 = new FontFamily { Val = FontFamilyValues.Roman };
        var pitch1 = new Pitch { Val = FontPitchValues.Variable };

        font1.Append(fontCharSet1);
        font1.Append(fontFamily1);
        font1.Append(pitch1);

        var font2 = new Font { Name = "Symbol" };
        var fontCharSet2 = new FontCharSet { Val = "02" };
        var fontFamily2 = new FontFamily { Val = FontFamilyValues.Roman };
        var pitch2 = new Pitch { Val = FontPitchValues.Variable };

        font2.Append(fontCharSet2);
        font2.Append(fontFamily2);
        font2.Append(pitch2);

        var font3 = new Font { Name = "Arial" };
        var fontCharSet3 = new FontCharSet
        { Val = "00", StrictCharacterSet = new EnumValue<StrictCharacterSet> { InnerText = "windows-1252" } };
        var fontFamily3 = new FontFamily { Val = FontFamilyValues.Swiss };
        var pitch3 = new Pitch { Val = FontPitchValues.Variable };

        font3.Append(fontCharSet3);
        font3.Append(fontFamily3);
        font3.Append(pitch3);

        var font4 = new Font { Name = "Liberation Serif" };
        var altName1 = new AltName { Val = "Times New Roman" };
        var fontCharSet4 = new FontCharSet
        { Val = "00", StrictCharacterSet = new EnumValue<StrictCharacterSet> { InnerText = "windows-1252" } };
        var fontFamily4 = new FontFamily { Val = FontFamilyValues.Roman };
        var pitch4 = new Pitch { Val = FontPitchValues.Variable };

        font4.Append(altName1);
        font4.Append(fontCharSet4);
        font4.Append(fontFamily4);
        font4.Append(pitch4);

        var font5 = new Font { Name = "Liberation Sans" };
        var altName2 = new AltName { Val = "Arial" };
        var fontCharSet5 = new FontCharSet
        { Val = "00", StrictCharacterSet = new EnumValue<StrictCharacterSet> { InnerText = "windows-1252" } };
        var fontFamily5 = new FontFamily { Val = FontFamilyValues.Roman };
        var pitch5 = new Pitch { Val = FontPitchValues.Variable };

        font5.Append(altName2);
        font5.Append(fontCharSet5);
        font5.Append(fontFamily5);
        font5.Append(pitch5);

        fonts1.Append(font1);
        fonts1.Append(font2);
        fonts1.Append(font3);
        fonts1.Append(font4);
        fonts1.Append(font5);

        fontTablePart1.Fonts = fonts1;
    }

    // Generates content of documentSettingsPart1.
    private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
    {
        var settings1 = new Settings();
        settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
        var zoom1 = new Zoom { Percent = "100" };
        var defaultTabStop1 = new DefaultTabStop { Val = 708 };
        var autoHyphenation1 = new AutoHyphenation { Val = true };

        var compatibility1 = new Compatibility();
        var compatibilitySetting1 = new CompatibilitySetting
        {
            Name = CompatSettingNameValues.CompatibilityMode,
            Uri = "http://schemas.microsoft.com/office/word",
            Val = "15"
        };

        compatibility1.Append(compatibilitySetting1);
        var themeFontLanguages1 = new ThemeFontLanguages { Val = "", EastAsia = "", Bidi = "" };

        settings1.Append(zoom1);
        settings1.Append(defaultTabStop1);
        settings1.Append(autoHyphenation1);
        settings1.Append(compatibility1);
        settings1.Append(themeFontLanguages1);

        documentSettingsPart1.Settings = settings1;
    }

    #region Binary Data

    private string extendedPart1Data =
        "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAyMi0wMi0yNlQxNDo0MTowMFo8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj7QntCa0KHQkNCd0JA8L2RjOmNyZWF0b3I+PGRjOmRlc2NyaXB0aW9uPjwvZGM6ZGVzY3JpcHRpb24+PGRjOmxhbmd1YWdlPmVuLVVTPC9kYzpsYW5ndWFnZT48Y3A6bGFzdE1vZGlmaWVkQnk+PC9jcDpsYXN0TW9kaWZpZWRCeT48ZGN0ZXJtczptb2RpZmllZCB4c2k6dHlwZT0iZGN0ZXJtczpXM0NEVEYiPjIwMjItMDQtMzBUMTE6MzA6MzVaPC9kY3Rlcm1zOm1vZGlmaWVkPjxjcDpyZXZpc2lvbj4xNzwvY3A6cmV2aXNpb24+PGRjOnN1YmplY3Q+PC9kYzpzdWJqZWN0PjxkYzp0aXRsZT48L2RjOnRpdGxlPjwvY3A6Y29yZVByb3BlcnRpZXM+";

    private Stream GetBinaryDataStream(string base64String)
    {
        return new MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion
}