using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using A = DocumentFormat.OpenXml.Drawing;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;


namespace Application.Teachers.Services.MonthProofreadingTeacherLoads;

public class GeneratedMonthProofreadingTeacherLoadsTable
{
    private readonly MonthProofreadingTeacherLoadsModel _model;

    // Creates a SpreadsheetDocument.
    public GeneratedMonthProofreadingTeacherLoadsTable(MonthProofreadingTeacherLoadsModel model)
    {
        _model = model;
    }

    public async Task<long> CreateAsync(string filePath)
    {
        await using var fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        using var package = SpreadsheetDocument.Create(fileStream, SpreadsheetDocumentType.Workbook);
        CreateParts(package);
        await fileStream.FlushAsync();
        var length = fileStream.Length;
        return length;
    }

    private void CreateParts(SpreadsheetDocument document)
    {
        var extendedPart1 =
            document.AddExtendedPart(
                "http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties",
                "application/vnd.openxmlformats-package.core-properties+xml", "xml", "rId2");
        GenerateExtendedPart1Content(extendedPart1);

        var workbookPart1 = document.AddWorkbookPart();
        GenerateWorkbookPart1Content(workbookPart1);

        var workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
        GenerateWorkbookStylesPart1Content(workbookStylesPart1);

        var themePart1 = workbookPart1.AddNewPart<ThemePart>("rId2");
        GenerateThemePart1Content(themePart1);

        var worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
        GenerateWorksheetPart1Content(worksheetPart1);

        var spreadsheetPrinterSettingsPart1 = worksheetPart1.AddNewPart<SpreadsheetPrinterSettingsPart>("rId1");
        GenerateSpreadsheetPrinterSettingsPart1Content(spreadsheetPrinterSettingsPart1);

        var calculationChainPart1 = workbookPart1.AddNewPart<CalculationChainPart>("rId5");
        GenerateCalculationChainPart1Content(calculationChainPart1);

        var sharedStringTablePart1 = workbookPart1.AddNewPart<SharedStringTablePart>("rId4");
        GenerateSharedStringTablePart1Content(sharedStringTablePart1);

        var extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId4");
        GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

        SetPackageProperties(document);
    }

    // Generates content of extendedPart1.
    private void GenerateExtendedPart1Content(ExtendedPart extendedPart1)
    {
        var data = GetBinaryDataStream(extendedPart1Data);
        extendedPart1.FeedData(data);
        data.Close();
    }

    // Generates content of workbookPart1.
    private void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
    {
        var workbook1 = new Workbook();
        workbook1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        var fileVersion1 = new FileVersion
            { ApplicationName = "xl", LastEdited = "4", LowestEdited = "4", BuildVersion = "4507" };
        var workbookProperties1 = new WorkbookProperties { DefaultThemeVersion = (UInt32Value)124226U };

        var bookViews1 = new BookViews();
        var workbookView1 = new WorkbookView
            { XWindow = 0, YWindow = 0, WindowWidth = (UInt32Value)16380U, WindowHeight = (UInt32Value)8190U };

        bookViews1.Append(workbookView1);

        var sheets1 = new Sheets();
        var sheet1 = new Sheet { Name = "Данные", SheetId = (UInt32Value)1U, Id = "rId1" };

        sheets1.Append(sheet1);
        var calculationProperties1 = new CalculationProperties { CalculationId = (UInt32Value)125725U };

        var workbookExtensionList1 = new WorkbookExtensionList();

        var workbookExtension1 = new WorkbookExtension { Uri = "{7626C862-2A13-11E5-B345-FEFF819CDC9F}" };
        workbookExtension1.AddNamespaceDeclaration("loext", "http://schemas.libreoffice.org/");

        var openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(
            "<loext:extCalcPr stringRefSyntax=\"CalcA1\" xmlns:loext=\"http://schemas.libreoffice.org/\" />");

        workbookExtension1.Append(openXmlUnknownElement1);

        workbookExtensionList1.Append(workbookExtension1);

        workbook1.Append(fileVersion1);
        workbook1.Append(workbookProperties1);
        workbook1.Append(bookViews1);
        workbook1.Append(sheets1);
        workbook1.Append(calculationProperties1);
        workbook1.Append(workbookExtensionList1);

        workbookPart1.Workbook = workbook1;
    }

    // Generates content of workbookStylesPart1.
    private void GenerateWorkbookStylesPart1Content(WorkbookStylesPart workbookStylesPart1)
    {
        var stylesheet1 = new Stylesheet();

        var fonts1 = new Fonts { Count = (UInt32Value)3U };

        var font1 = new Font();
        var fontSize1 = new FontSize { Val = 10D };
        var fontName1 = new FontName { Val = "Arial" };
        var fontFamilyNumbering1 = new FontFamilyNumbering { Val = 2 };

        font1.Append(fontSize1);
        font1.Append(fontName1);
        font1.Append(fontFamilyNumbering1);

        var font2 = new Font();
        var fontSize2 = new FontSize { Val = 12D };
        var fontName2 = new FontName { Val = "Times New Roman" };
        var fontFamilyNumbering2 = new FontFamilyNumbering { Val = 1 };
        var fontCharSet1 = new FontCharSet { Val = 1 };

        font2.Append(fontSize2);
        font2.Append(fontName2);
        font2.Append(fontFamilyNumbering2);
        font2.Append(fontCharSet1);

        var font3 = new Font();
        var fontSize3 = new FontSize { Val = 14D };
        var fontName3 = new FontName { Val = "Times New Roman" };
        var fontFamilyNumbering3 = new FontFamilyNumbering { Val = 1 };
        var fontCharSet2 = new FontCharSet { Val = 1 };

        font3.Append(fontSize3);
        font3.Append(fontName3);
        font3.Append(fontFamilyNumbering3);
        font3.Append(fontCharSet2);

        fonts1.Append(font1);
        fonts1.Append(font2);
        fonts1.Append(font3);

        var fills1 = new Fills { Count = (UInt32Value)2U };

        var fill1 = new Fill();
        var patternFill1 = new PatternFill { PatternType = PatternValues.None };

        fill1.Append(patternFill1);

        var fill2 = new Fill();
        var patternFill2 = new PatternFill { PatternType = PatternValues.Gray125 };

        fill2.Append(patternFill2);

        fills1.Append(fill1);
        fills1.Append(fill2);

        var borders1 = new Borders { Count = (UInt32Value)2U };

        var border1 = new Border();
        var leftBorder1 = new LeftBorder();
        var rightBorder1 = new RightBorder();
        var topBorder1 = new TopBorder();
        var bottomBorder1 = new BottomBorder();
        var diagonalBorder1 = new DiagonalBorder();

        border1.Append(leftBorder1);
        border1.Append(rightBorder1);
        border1.Append(topBorder1);
        border1.Append(bottomBorder1);
        border1.Append(diagonalBorder1);

        var border2 = new Border();

        var leftBorder2 = new LeftBorder { Style = BorderStyleValues.Thin };
        var color1 = new Color { Auto = true };

        leftBorder2.Append(color1);

        var rightBorder2 = new RightBorder { Style = BorderStyleValues.Thin };
        var color2 = new Color { Auto = true };

        rightBorder2.Append(color2);

        var topBorder2 = new TopBorder { Style = BorderStyleValues.Thin };
        var color3 = new Color { Auto = true };

        topBorder2.Append(color3);

        var bottomBorder2 = new BottomBorder { Style = BorderStyleValues.Thin };
        var color4 = new Color { Auto = true };

        bottomBorder2.Append(color4);
        var diagonalBorder2 = new DiagonalBorder();

        border2.Append(leftBorder2);
        border2.Append(rightBorder2);
        border2.Append(topBorder2);
        border2.Append(bottomBorder2);
        border2.Append(diagonalBorder2);

        borders1.Append(border1);
        borders1.Append(border2);

        var cellStyleFormats1 = new CellStyleFormats { Count = (UInt32Value)1U };
        var cellFormat1 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U
        };

        cellStyleFormats1.Append(cellFormat1);

        var cellFormats1 = new CellFormats { Count = (UInt32Value)10U };
        var cellFormat2 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U
        };

        var cellFormat3 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyAlignment = true
        };
        var alignment1 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true
        };

        cellFormat3.Append(alignment1);

        var cellFormat4 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyAlignment = true
        };
        var alignment2 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true
        };

        cellFormat4.Append(alignment2);
        var cellFormat5 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true
        };

        var cellFormat6 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyAlignment = true
        };
        var alignment3 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true
        };

        cellFormat6.Append(alignment3);

        var cellFormat7 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true
        };
        var alignment4 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true
        };

        cellFormat7.Append(alignment4);

        var cellFormat8 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true
        };
        var alignment5 = new Alignment
            { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

        cellFormat8.Append(alignment5);

        var cellFormat9 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true
        };
        var alignment6 = new Alignment
            { Horizontal = HorizontalAlignmentValues.Left, Vertical = VerticalAlignmentValues.Top, WrapText = true };

        cellFormat9.Append(alignment6);

        var cellFormat10 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true
        };
        var alignment7 = new Alignment { Horizontal = HorizontalAlignmentValues.Right, WrapText = true };

        cellFormat10.Append(alignment7);

        var cellFormat11 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true
        };
        var alignment8 = new Alignment { Horizontal = HorizontalAlignmentValues.Right };

        cellFormat11.Append(alignment8);

        cellFormats1.Append(cellFormat2);
        cellFormats1.Append(cellFormat3);
        cellFormats1.Append(cellFormat4);
        cellFormats1.Append(cellFormat5);
        cellFormats1.Append(cellFormat6);
        cellFormats1.Append(cellFormat7);
        cellFormats1.Append(cellFormat8);
        cellFormats1.Append(cellFormat9);
        cellFormats1.Append(cellFormat10);
        cellFormats1.Append(cellFormat11);

        var cellStyles1 = new CellStyles { Count = (UInt32Value)1U };
        var cellStyle1 = new CellStyle { Name = "Обычный", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

        cellStyles1.Append(cellStyle1);
        var differentialFormats1 = new DifferentialFormats { Count = (UInt32Value)0U };
        var tableStyles1 = new TableStyles
        {
            Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium9", DefaultPivotStyle = "PivotStyleLight16"
        };

        stylesheet1.Append(fonts1);
        stylesheet1.Append(fills1);
        stylesheet1.Append(borders1);
        stylesheet1.Append(cellStyleFormats1);
        stylesheet1.Append(cellFormats1);
        stylesheet1.Append(cellStyles1);
        stylesheet1.Append(differentialFormats1);
        stylesheet1.Append(tableStyles1);

        workbookStylesPart1.Stylesheet = stylesheet1;
    }

    // Generates content of themePart1.
    private void GenerateThemePart1Content(ThemePart themePart1)
    {
        var theme1 = new A.Theme { Name = "Тема Office" };
        theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

        var themeElements1 = new A.ThemeElements();

        var colorScheme1 = new A.ColorScheme { Name = "Стандартная" };

        var dark1Color1 = new A.Dark1Color();
        var systemColor1 = new A.SystemColor { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

        dark1Color1.Append(systemColor1);

        var light1Color1 = new A.Light1Color();
        var systemColor2 = new A.SystemColor { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

        light1Color1.Append(systemColor2);

        var dark2Color1 = new A.Dark2Color();
        var rgbColorModelHex1 = new A.RgbColorModelHex { Val = "1F497D" };

        dark2Color1.Append(rgbColorModelHex1);

        var light2Color1 = new A.Light2Color();
        var rgbColorModelHex2 = new A.RgbColorModelHex { Val = "EEECE1" };

        light2Color1.Append(rgbColorModelHex2);

        var accent1Color1 = new A.Accent1Color();
        var rgbColorModelHex3 = new A.RgbColorModelHex { Val = "4F81BD" };

        accent1Color1.Append(rgbColorModelHex3);

        var accent2Color1 = new A.Accent2Color();
        var rgbColorModelHex4 = new A.RgbColorModelHex { Val = "C0504D" };

        accent2Color1.Append(rgbColorModelHex4);

        var accent3Color1 = new A.Accent3Color();
        var rgbColorModelHex5 = new A.RgbColorModelHex { Val = "9BBB59" };

        accent3Color1.Append(rgbColorModelHex5);

        var accent4Color1 = new A.Accent4Color();
        var rgbColorModelHex6 = new A.RgbColorModelHex { Val = "8064A2" };

        accent4Color1.Append(rgbColorModelHex6);

        var accent5Color1 = new A.Accent5Color();
        var rgbColorModelHex7 = new A.RgbColorModelHex { Val = "4BACC6" };

        accent5Color1.Append(rgbColorModelHex7);

        var accent6Color1 = new A.Accent6Color();
        var rgbColorModelHex8 = new A.RgbColorModelHex { Val = "F79646" };

        accent6Color1.Append(rgbColorModelHex8);

        var hyperlink1 = new A.Hyperlink();
        var rgbColorModelHex9 = new A.RgbColorModelHex { Val = "0000FF" };

        hyperlink1.Append(rgbColorModelHex9);

        var followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
        var rgbColorModelHex10 = new A.RgbColorModelHex { Val = "800080" };

        followedHyperlinkColor1.Append(rgbColorModelHex10);

        colorScheme1.Append(dark1Color1);
        colorScheme1.Append(light1Color1);
        colorScheme1.Append(dark2Color1);
        colorScheme1.Append(light2Color1);
        colorScheme1.Append(accent1Color1);
        colorScheme1.Append(accent2Color1);
        colorScheme1.Append(accent3Color1);
        colorScheme1.Append(accent4Color1);
        colorScheme1.Append(accent5Color1);
        colorScheme1.Append(accent6Color1);
        colorScheme1.Append(hyperlink1);
        colorScheme1.Append(followedHyperlinkColor1);

        var fontScheme1 = new A.FontScheme { Name = "Стандартная" };

        var majorFont1 = new A.MajorFont();
        var latinFont1 = new A.LatinFont { Typeface = "Cambria" };
        var eastAsianFont1 = new A.EastAsianFont { Typeface = "" };
        var complexScriptFont1 = new A.ComplexScriptFont { Typeface = "" };
        var supplementalFont1 = new A.SupplementalFont { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
        var supplementalFont2 = new A.SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" };
        var supplementalFont3 = new A.SupplementalFont { Script = "Hans", Typeface = "宋体" };
        var supplementalFont4 = new A.SupplementalFont { Script = "Hant", Typeface = "新細明體" };
        var supplementalFont5 = new A.SupplementalFont { Script = "Arab", Typeface = "Times New Roman" };
        var supplementalFont6 = new A.SupplementalFont { Script = "Hebr", Typeface = "Times New Roman" };
        var supplementalFont7 = new A.SupplementalFont { Script = "Thai", Typeface = "Tahoma" };
        var supplementalFont8 = new A.SupplementalFont { Script = "Ethi", Typeface = "Nyala" };
        var supplementalFont9 = new A.SupplementalFont { Script = "Beng", Typeface = "Vrinda" };
        var supplementalFont10 = new A.SupplementalFont { Script = "Gujr", Typeface = "Shruti" };
        var supplementalFont11 = new A.SupplementalFont { Script = "Khmr", Typeface = "MoolBoran" };
        var supplementalFont12 = new A.SupplementalFont { Script = "Knda", Typeface = "Tunga" };
        var supplementalFont13 = new A.SupplementalFont { Script = "Guru", Typeface = "Raavi" };
        var supplementalFont14 = new A.SupplementalFont { Script = "Cans", Typeface = "Euphemia" };
        var supplementalFont15 = new A.SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" };
        var supplementalFont16 = new A.SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
        var supplementalFont17 = new A.SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" };
        var supplementalFont18 = new A.SupplementalFont { Script = "Thaa", Typeface = "MV Boli" };
        var supplementalFont19 = new A.SupplementalFont { Script = "Deva", Typeface = "Mangal" };
        var supplementalFont20 = new A.SupplementalFont { Script = "Telu", Typeface = "Gautami" };
        var supplementalFont21 = new A.SupplementalFont { Script = "Taml", Typeface = "Latha" };
        var supplementalFont22 = new A.SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" };
        var supplementalFont23 = new A.SupplementalFont { Script = "Orya", Typeface = "Kalinga" };
        var supplementalFont24 = new A.SupplementalFont { Script = "Mlym", Typeface = "Kartika" };
        var supplementalFont25 = new A.SupplementalFont { Script = "Laoo", Typeface = "DokChampa" };
        var supplementalFont26 = new A.SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" };
        var supplementalFont27 = new A.SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" };
        var supplementalFont28 = new A.SupplementalFont { Script = "Viet", Typeface = "Times New Roman" };
        var supplementalFont29 = new A.SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" };

        majorFont1.Append(latinFont1);
        majorFont1.Append(eastAsianFont1);
        majorFont1.Append(complexScriptFont1);
        majorFont1.Append(supplementalFont1);
        majorFont1.Append(supplementalFont2);
        majorFont1.Append(supplementalFont3);
        majorFont1.Append(supplementalFont4);
        majorFont1.Append(supplementalFont5);
        majorFont1.Append(supplementalFont6);
        majorFont1.Append(supplementalFont7);
        majorFont1.Append(supplementalFont8);
        majorFont1.Append(supplementalFont9);
        majorFont1.Append(supplementalFont10);
        majorFont1.Append(supplementalFont11);
        majorFont1.Append(supplementalFont12);
        majorFont1.Append(supplementalFont13);
        majorFont1.Append(supplementalFont14);
        majorFont1.Append(supplementalFont15);
        majorFont1.Append(supplementalFont16);
        majorFont1.Append(supplementalFont17);
        majorFont1.Append(supplementalFont18);
        majorFont1.Append(supplementalFont19);
        majorFont1.Append(supplementalFont20);
        majorFont1.Append(supplementalFont21);
        majorFont1.Append(supplementalFont22);
        majorFont1.Append(supplementalFont23);
        majorFont1.Append(supplementalFont24);
        majorFont1.Append(supplementalFont25);
        majorFont1.Append(supplementalFont26);
        majorFont1.Append(supplementalFont27);
        majorFont1.Append(supplementalFont28);
        majorFont1.Append(supplementalFont29);

        var minorFont1 = new A.MinorFont();
        var latinFont2 = new A.LatinFont { Typeface = "Calibri" };
        var eastAsianFont2 = new A.EastAsianFont { Typeface = "" };
        var complexScriptFont2 = new A.ComplexScriptFont { Typeface = "" };
        var supplementalFont30 = new A.SupplementalFont { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
        var supplementalFont31 = new A.SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" };
        var supplementalFont32 = new A.SupplementalFont { Script = "Hans", Typeface = "宋体" };
        var supplementalFont33 = new A.SupplementalFont { Script = "Hant", Typeface = "新細明體" };
        var supplementalFont34 = new A.SupplementalFont { Script = "Arab", Typeface = "Arial" };
        var supplementalFont35 = new A.SupplementalFont { Script = "Hebr", Typeface = "Arial" };
        var supplementalFont36 = new A.SupplementalFont { Script = "Thai", Typeface = "Tahoma" };
        var supplementalFont37 = new A.SupplementalFont { Script = "Ethi", Typeface = "Nyala" };
        var supplementalFont38 = new A.SupplementalFont { Script = "Beng", Typeface = "Vrinda" };
        var supplementalFont39 = new A.SupplementalFont { Script = "Gujr", Typeface = "Shruti" };
        var supplementalFont40 = new A.SupplementalFont { Script = "Khmr", Typeface = "DaunPenh" };
        var supplementalFont41 = new A.SupplementalFont { Script = "Knda", Typeface = "Tunga" };
        var supplementalFont42 = new A.SupplementalFont { Script = "Guru", Typeface = "Raavi" };
        var supplementalFont43 = new A.SupplementalFont { Script = "Cans", Typeface = "Euphemia" };
        var supplementalFont44 = new A.SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" };
        var supplementalFont45 = new A.SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
        var supplementalFont46 = new A.SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" };
        var supplementalFont47 = new A.SupplementalFont { Script = "Thaa", Typeface = "MV Boli" };
        var supplementalFont48 = new A.SupplementalFont { Script = "Deva", Typeface = "Mangal" };
        var supplementalFont49 = new A.SupplementalFont { Script = "Telu", Typeface = "Gautami" };
        var supplementalFont50 = new A.SupplementalFont { Script = "Taml", Typeface = "Latha" };
        var supplementalFont51 = new A.SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" };
        var supplementalFont52 = new A.SupplementalFont { Script = "Orya", Typeface = "Kalinga" };
        var supplementalFont53 = new A.SupplementalFont { Script = "Mlym", Typeface = "Kartika" };
        var supplementalFont54 = new A.SupplementalFont { Script = "Laoo", Typeface = "DokChampa" };
        var supplementalFont55 = new A.SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" };
        var supplementalFont56 = new A.SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" };
        var supplementalFont57 = new A.SupplementalFont { Script = "Viet", Typeface = "Arial" };
        var supplementalFont58 = new A.SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" };

        minorFont1.Append(latinFont2);
        minorFont1.Append(eastAsianFont2);
        minorFont1.Append(complexScriptFont2);
        minorFont1.Append(supplementalFont30);
        minorFont1.Append(supplementalFont31);
        minorFont1.Append(supplementalFont32);
        minorFont1.Append(supplementalFont33);
        minorFont1.Append(supplementalFont34);
        minorFont1.Append(supplementalFont35);
        minorFont1.Append(supplementalFont36);
        minorFont1.Append(supplementalFont37);
        minorFont1.Append(supplementalFont38);
        minorFont1.Append(supplementalFont39);
        minorFont1.Append(supplementalFont40);
        minorFont1.Append(supplementalFont41);
        minorFont1.Append(supplementalFont42);
        minorFont1.Append(supplementalFont43);
        minorFont1.Append(supplementalFont44);
        minorFont1.Append(supplementalFont45);
        minorFont1.Append(supplementalFont46);
        minorFont1.Append(supplementalFont47);
        minorFont1.Append(supplementalFont48);
        minorFont1.Append(supplementalFont49);
        minorFont1.Append(supplementalFont50);
        minorFont1.Append(supplementalFont51);
        minorFont1.Append(supplementalFont52);
        minorFont1.Append(supplementalFont53);
        minorFont1.Append(supplementalFont54);
        minorFont1.Append(supplementalFont55);
        minorFont1.Append(supplementalFont56);
        minorFont1.Append(supplementalFont57);
        minorFont1.Append(supplementalFont58);

        fontScheme1.Append(majorFont1);
        fontScheme1.Append(minorFont1);

        var formatScheme1 = new A.FormatScheme { Name = "Стандартная" };

        var fillStyleList1 = new A.FillStyleList();

        var solidFill1 = new A.SolidFill();
        var schemeColor1 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };

        solidFill1.Append(schemeColor1);

        var gradientFill1 = new A.GradientFill { RotateWithShape = true };

        var gradientStopList1 = new A.GradientStopList();

        var gradientStop1 = new A.GradientStop { Position = 0 };

        var schemeColor2 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint1 = new A.Tint { Val = 50000 };
        var saturationModulation1 = new A.SaturationModulation { Val = 300000 };

        schemeColor2.Append(tint1);
        schemeColor2.Append(saturationModulation1);

        gradientStop1.Append(schemeColor2);

        var gradientStop2 = new A.GradientStop { Position = 35000 };

        var schemeColor3 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint2 = new A.Tint { Val = 37000 };
        var saturationModulation2 = new A.SaturationModulation { Val = 300000 };

        schemeColor3.Append(tint2);
        schemeColor3.Append(saturationModulation2);

        gradientStop2.Append(schemeColor3);

        var gradientStop3 = new A.GradientStop { Position = 100000 };

        var schemeColor4 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint3 = new A.Tint { Val = 15000 };
        var saturationModulation3 = new A.SaturationModulation { Val = 350000 };

        schemeColor4.Append(tint3);
        schemeColor4.Append(saturationModulation3);

        gradientStop3.Append(schemeColor4);

        gradientStopList1.Append(gradientStop1);
        gradientStopList1.Append(gradientStop2);
        gradientStopList1.Append(gradientStop3);
        var linearGradientFill1 = new A.LinearGradientFill { Angle = 16200000, Scaled = true };

        gradientFill1.Append(gradientStopList1);
        gradientFill1.Append(linearGradientFill1);

        var gradientFill2 = new A.GradientFill { RotateWithShape = true };

        var gradientStopList2 = new A.GradientStopList();

        var gradientStop4 = new A.GradientStop { Position = 0 };

        var schemeColor5 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade1 = new A.Shade { Val = 51000 };
        var saturationModulation4 = new A.SaturationModulation { Val = 130000 };

        schemeColor5.Append(shade1);
        schemeColor5.Append(saturationModulation4);

        gradientStop4.Append(schemeColor5);

        var gradientStop5 = new A.GradientStop { Position = 80000 };

        var schemeColor6 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade2 = new A.Shade { Val = 93000 };
        var saturationModulation5 = new A.SaturationModulation { Val = 130000 };

        schemeColor6.Append(shade2);
        schemeColor6.Append(saturationModulation5);

        gradientStop5.Append(schemeColor6);

        var gradientStop6 = new A.GradientStop { Position = 100000 };

        var schemeColor7 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade3 = new A.Shade { Val = 94000 };
        var saturationModulation6 = new A.SaturationModulation { Val = 135000 };

        schemeColor7.Append(shade3);
        schemeColor7.Append(saturationModulation6);

        gradientStop6.Append(schemeColor7);

        gradientStopList2.Append(gradientStop4);
        gradientStopList2.Append(gradientStop5);
        gradientStopList2.Append(gradientStop6);
        var linearGradientFill2 = new A.LinearGradientFill { Angle = 16200000, Scaled = false };

        gradientFill2.Append(gradientStopList2);
        gradientFill2.Append(linearGradientFill2);

        fillStyleList1.Append(solidFill1);
        fillStyleList1.Append(gradientFill1);
        fillStyleList1.Append(gradientFill2);

        var lineStyleList1 = new A.LineStyleList();

        var outline1 = new A.Outline
        {
            Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single,
            Alignment = A.PenAlignmentValues.Center
        };

        var solidFill2 = new A.SolidFill();

        var schemeColor8 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade4 = new A.Shade { Val = 95000 };
        var saturationModulation7 = new A.SaturationModulation { Val = 105000 };

        schemeColor8.Append(shade4);
        schemeColor8.Append(saturationModulation7);

        solidFill2.Append(schemeColor8);
        var presetDash1 = new A.PresetDash { Val = A.PresetLineDashValues.Solid };

        outline1.Append(solidFill2);
        outline1.Append(presetDash1);

        var outline2 = new A.Outline
        {
            Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single,
            Alignment = A.PenAlignmentValues.Center
        };

        var solidFill3 = new A.SolidFill();
        var schemeColor9 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };

        solidFill3.Append(schemeColor9);
        var presetDash2 = new A.PresetDash { Val = A.PresetLineDashValues.Solid };

        outline2.Append(solidFill3);
        outline2.Append(presetDash2);

        var outline3 = new A.Outline
        {
            Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single,
            Alignment = A.PenAlignmentValues.Center
        };

        var solidFill4 = new A.SolidFill();
        var schemeColor10 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };

        solidFill4.Append(schemeColor10);
        var presetDash3 = new A.PresetDash { Val = A.PresetLineDashValues.Solid };

        outline3.Append(solidFill4);
        outline3.Append(presetDash3);

        lineStyleList1.Append(outline1);
        lineStyleList1.Append(outline2);
        lineStyleList1.Append(outline3);

        var effectStyleList1 = new A.EffectStyleList();

        var effectStyle1 = new A.EffectStyle();

        var effectList1 = new A.EffectList();

        var outerShadow1 = new A.OuterShadow
            { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex11 = new A.RgbColorModelHex { Val = "000000" };
        var alpha1 = new A.Alpha { Val = 38000 };

        rgbColorModelHex11.Append(alpha1);

        outerShadow1.Append(rgbColorModelHex11);

        effectList1.Append(outerShadow1);

        effectStyle1.Append(effectList1);

        var effectStyle2 = new A.EffectStyle();

        var effectList2 = new A.EffectList();

        var outerShadow2 = new A.OuterShadow
            { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex12 = new A.RgbColorModelHex { Val = "000000" };
        var alpha2 = new A.Alpha { Val = 35000 };

        rgbColorModelHex12.Append(alpha2);

        outerShadow2.Append(rgbColorModelHex12);

        effectList2.Append(outerShadow2);

        effectStyle2.Append(effectList2);

        var effectStyle3 = new A.EffectStyle();

        var effectList3 = new A.EffectList();

        var outerShadow3 = new A.OuterShadow
            { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex13 = new A.RgbColorModelHex { Val = "000000" };
        var alpha3 = new A.Alpha { Val = 35000 };

        rgbColorModelHex13.Append(alpha3);

        outerShadow3.Append(rgbColorModelHex13);

        effectList3.Append(outerShadow3);

        var scene3DType1 = new A.Scene3DType();

        var camera1 = new A.Camera { Preset = A.PresetCameraValues.OrthographicFront };
        var rotation1 = new A.Rotation { Latitude = 0, Longitude = 0, Revolution = 0 };

        camera1.Append(rotation1);

        var lightRig1 = new A.LightRig
            { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
        var rotation2 = new A.Rotation { Latitude = 0, Longitude = 0, Revolution = 1200000 };

        lightRig1.Append(rotation2);

        scene3DType1.Append(camera1);
        scene3DType1.Append(lightRig1);

        var shape3DType1 = new A.Shape3DType();
        var bevelTop1 = new A.BevelTop { Width = 63500L, Height = 25400L };

        shape3DType1.Append(bevelTop1);

        effectStyle3.Append(effectList3);
        effectStyle3.Append(scene3DType1);
        effectStyle3.Append(shape3DType1);

        effectStyleList1.Append(effectStyle1);
        effectStyleList1.Append(effectStyle2);
        effectStyleList1.Append(effectStyle3);

        var backgroundFillStyleList1 = new A.BackgroundFillStyleList();

        var solidFill5 = new A.SolidFill();
        var schemeColor11 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };

        solidFill5.Append(schemeColor11);

        var gradientFill3 = new A.GradientFill { RotateWithShape = true };

        var gradientStopList3 = new A.GradientStopList();

        var gradientStop7 = new A.GradientStop { Position = 0 };

        var schemeColor12 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint4 = new A.Tint { Val = 40000 };
        var saturationModulation8 = new A.SaturationModulation { Val = 350000 };

        schemeColor12.Append(tint4);
        schemeColor12.Append(saturationModulation8);

        gradientStop7.Append(schemeColor12);

        var gradientStop8 = new A.GradientStop { Position = 40000 };

        var schemeColor13 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint5 = new A.Tint { Val = 45000 };
        var shade5 = new A.Shade { Val = 99000 };
        var saturationModulation9 = new A.SaturationModulation { Val = 350000 };

        schemeColor13.Append(tint5);
        schemeColor13.Append(shade5);
        schemeColor13.Append(saturationModulation9);

        gradientStop8.Append(schemeColor13);

        var gradientStop9 = new A.GradientStop { Position = 100000 };

        var schemeColor14 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade6 = new A.Shade { Val = 20000 };
        var saturationModulation10 = new A.SaturationModulation { Val = 255000 };

        schemeColor14.Append(shade6);
        schemeColor14.Append(saturationModulation10);

        gradientStop9.Append(schemeColor14);

        gradientStopList3.Append(gradientStop7);
        gradientStopList3.Append(gradientStop8);
        gradientStopList3.Append(gradientStop9);

        var pathGradientFill1 = new A.PathGradientFill { Path = A.PathShadeValues.Circle };
        var fillToRectangle1 = new A.FillToRectangle { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

        pathGradientFill1.Append(fillToRectangle1);

        gradientFill3.Append(gradientStopList3);
        gradientFill3.Append(pathGradientFill1);

        var gradientFill4 = new A.GradientFill { RotateWithShape = true };

        var gradientStopList4 = new A.GradientStopList();

        var gradientStop10 = new A.GradientStop { Position = 0 };

        var schemeColor15 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var tint6 = new A.Tint { Val = 80000 };
        var saturationModulation11 = new A.SaturationModulation { Val = 300000 };

        schemeColor15.Append(tint6);
        schemeColor15.Append(saturationModulation11);

        gradientStop10.Append(schemeColor15);

        var gradientStop11 = new A.GradientStop { Position = 100000 };

        var schemeColor16 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };
        var shade7 = new A.Shade { Val = 30000 };
        var saturationModulation12 = new A.SaturationModulation { Val = 200000 };

        schemeColor16.Append(shade7);
        schemeColor16.Append(saturationModulation12);

        gradientStop11.Append(schemeColor16);

        gradientStopList4.Append(gradientStop10);
        gradientStopList4.Append(gradientStop11);

        var pathGradientFill2 = new A.PathGradientFill { Path = A.PathShadeValues.Circle };
        var fillToRectangle2 = new A.FillToRectangle { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

        pathGradientFill2.Append(fillToRectangle2);

        gradientFill4.Append(gradientStopList4);
        gradientFill4.Append(pathGradientFill2);

        backgroundFillStyleList1.Append(solidFill5);
        backgroundFillStyleList1.Append(gradientFill3);
        backgroundFillStyleList1.Append(gradientFill4);

        formatScheme1.Append(fillStyleList1);
        formatScheme1.Append(lineStyleList1);
        formatScheme1.Append(effectStyleList1);
        formatScheme1.Append(backgroundFillStyleList1);

        themeElements1.Append(colorScheme1);
        themeElements1.Append(fontScheme1);
        themeElements1.Append(formatScheme1);
        var objectDefaults1 = new A.ObjectDefaults();
        var extraColorSchemeList1 = new A.ExtraColorSchemeList();

        theme1.Append(themeElements1);
        theme1.Append(objectDefaults1);
        theme1.Append(extraColorSchemeList1);

        themePart1.Theme = theme1;
    }

    // Generates content of worksheetPart1.
    private void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
    {
        var worksheet1 = new Worksheet();
        worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        var sheetDimension1 = new SheetDimension { Reference = "A1:AJ8" };

        var sheetViews1 = new SheetViews();

        var sheetView1 = new SheetView
        {
            TabSelected = true, ZoomScaleNormal = (UInt32Value)100U, ZoomScalePageLayoutView = (UInt32Value)60U,
            WorkbookViewId = (UInt32Value)0U
        };

        sheetViews1.Append(sheetView1);
        var sheetFormatProperties1 = new SheetFormatProperties
            { DefaultColumnWidth = 5.140625D, DefaultRowHeight = 15.75D };

        var columns1 = new Columns();
        var column1 = new Column
            { Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 5.140625D, Style = (UInt32Value)3U };
        var column2 = new Column
        {
            Min = (UInt32Value)2U, Max = (UInt32Value)2U, Width = 25.5703125D, Style = (UInt32Value)3U,
            CustomWidth = true
        };
        var column3 = new Column
        {
            Min = (UInt32Value)3U, Max = (UInt32Value)3U, Width = 12.5703125D, Style = (UInt32Value)3U,
            CustomWidth = true
        };
        var column4 = new Column
        {
            Min = (UInt32Value)4U, Max = (UInt32Value)4U, Width = 6.7109375D, Style = (UInt32Value)3U,
            CustomWidth = true
        };
        var column5 = new Column
        {
            Min = (UInt32Value)5U, Max = (UInt32Value)35U, Width = 3.7109375D, Style = (UInt32Value)3U,
            CustomWidth = true
        };
        var column6 = new Column
        {
            Min = (UInt32Value)36U, Max = (UInt32Value)36U, Width = 7.42578125D, Style = (UInt32Value)3U,
            CustomWidth = true
        };

        columns1.Append(column1);
        columns1.Append(column2);
        columns1.Append(column3);
        columns1.Append(column4);
        columns1.Append(column5);
        columns1.Append(column6);

        var sheetData1 = new SheetData();

        var row1 = new Row { RowIndex = (UInt32Value)1U, Spans = new ListValue<StringValue> { InnerText = "1:36" } };
        var cell1 = new Cell { CellReference = "A1", StyleIndex = (UInt32Value)4U };
        var cell2 = new Cell { CellReference = "B1", StyleIndex = (UInt32Value)4U };
        var cell3 = new Cell { CellReference = "C1", StyleIndex = (UInt32Value)4U };
        var cell4 = new Cell { CellReference = "D1", StyleIndex = (UInt32Value)4U };
        var cell5 = new Cell { CellReference = "E1", StyleIndex = (UInt32Value)4U };
        var cell6 = new Cell { CellReference = "F1", StyleIndex = (UInt32Value)4U };
        var cell7 = new Cell { CellReference = "G1", StyleIndex = (UInt32Value)4U };
        var cell8 = new Cell { CellReference = "H1", StyleIndex = (UInt32Value)4U };
        var cell9 = new Cell { CellReference = "I1", StyleIndex = (UInt32Value)4U };
        var cell10 = new Cell { CellReference = "J1", StyleIndex = (UInt32Value)4U };
        var cell11 = new Cell { CellReference = "K1", StyleIndex = (UInt32Value)4U };
        var cell12 = new Cell { CellReference = "L1", StyleIndex = (UInt32Value)4U };
        var cell13 = new Cell { CellReference = "M1", StyleIndex = (UInt32Value)4U };
        var cell14 = new Cell { CellReference = "N1", StyleIndex = (UInt32Value)4U };
        var cell15 = new Cell { CellReference = "O1", StyleIndex = (UInt32Value)4U };

        row1.Append(cell1);
        row1.Append(cell2);
        row1.Append(cell3);
        row1.Append(cell4);
        row1.Append(cell5);
        row1.Append(cell6);
        row1.Append(cell7);
        row1.Append(cell8);
        row1.Append(cell9);
        row1.Append(cell10);
        row1.Append(cell11);
        row1.Append(cell12);
        row1.Append(cell13);
        row1.Append(cell14);
        row1.Append(cell15);

        var row2 = new Row
        {
            RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue> { InnerText = "1:36" }, Height = 17.45D,
            CustomHeight = true
        };
        var cell24 = new Cell { CellReference = "A2", StyleIndex = (UInt32Value)4U };

        var cell25 = new Cell
            { CellReference = "B2", StyleIndex = (UInt32Value)2U, DataType = CellValues.String };
        var cellValue1 = new CellValue
        {
            Text = "Табель учета педагогической нагрузки"
        };

        cell25.Append(cellValue1);
        var cell26 = new Cell { CellReference = "C2", StyleIndex = (UInt32Value)2U };
        var cell27 = new Cell { CellReference = "D2", StyleIndex = (UInt32Value)2U };
        var cell28 = new Cell { CellReference = "E2", StyleIndex = (UInt32Value)2U };
        var cell29 = new Cell { CellReference = "F2", StyleIndex = (UInt32Value)2U };
        var cell30 = new Cell { CellReference = "G2", StyleIndex = (UInt32Value)2U };
        var cell31 = new Cell { CellReference = "H2", StyleIndex = (UInt32Value)2U };
        var cell32 = new Cell { CellReference = "I2", StyleIndex = (UInt32Value)2U };
        var cell33 = new Cell { CellReference = "J2", StyleIndex = (UInt32Value)2U };
        var cell34 = new Cell { CellReference = "K2", StyleIndex = (UInt32Value)2U };
        var cell35 = new Cell { CellReference = "L2", StyleIndex = (UInt32Value)2U };
        var cell36 = new Cell { CellReference = "M2", StyleIndex = (UInt32Value)2U };
        var cell37 = new Cell { CellReference = "N2", StyleIndex = (UInt32Value)2U };
        var cell38 = new Cell { CellReference = "O2", StyleIndex = (UInt32Value)2U };

        row2.Append(cell24);
        row2.Append(cell25);
        row2.Append(cell26);
        row2.Append(cell27);
        row2.Append(cell28);
        row2.Append(cell29);
        row2.Append(cell30);
        row2.Append(cell31);
        row2.Append(cell32);
        row2.Append(cell33);
        row2.Append(cell34);
        row2.Append(cell35);
        row2.Append(cell36);
        row2.Append(cell37);
        row2.Append(cell38);

        var row3 = new Row
        {
            RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue> { InnerText = "1:36" }, Height = 15D,
            CustomHeight = true
        };
        var cell47 = new Cell { CellReference = "A3", StyleIndex = (UInt32Value)4U };

        var cell48 = new Cell
            { CellReference = "B3", StyleIndex = (UInt32Value)4U, DataType = CellValues.String };
        var cellValue2 = new CellValue
        {
            Text = "Преподаватель"
        };

        cell48.Append(cellValue2);

        var cell49 = new Cell { CellReference = "C3", StyleIndex = (UInt32Value)1U, DataType = CellValues.String };
        var cellValue3 = new CellValue
        {
            Text = _model.TeacherFullName
        };

        cell49.Append(cellValue3);
        var cell50 = new Cell { CellReference = "D3", StyleIndex = (UInt32Value)1U };
        var cell51 = new Cell { CellReference = "E3", StyleIndex = (UInt32Value)1U };
        var cell52 = new Cell { CellReference = "F3", StyleIndex = (UInt32Value)1U };
        var cell53 = new Cell { CellReference = "G3", StyleIndex = (UInt32Value)1U };
        var cell54 = new Cell { CellReference = "H3", StyleIndex = (UInt32Value)1U };
        var cell55 = new Cell { CellReference = "I3", StyleIndex = (UInt32Value)1U };
        var cell56 = new Cell { CellReference = "J3", StyleIndex = (UInt32Value)1U };
        var cell57 = new Cell { CellReference = "K3", StyleIndex = (UInt32Value)1U };
        var cell58 = new Cell { CellReference = "L3", StyleIndex = (UInt32Value)1U };
        var cell59 = new Cell { CellReference = "M3", StyleIndex = (UInt32Value)1U };
        var cell60 = new Cell { CellReference = "N3", StyleIndex = (UInt32Value)1U };
        var cell61 = new Cell { CellReference = "O3", StyleIndex = (UInt32Value)1U };

        row3.Append(cell47);
        row3.Append(cell48);
        row3.Append(cell49);
        row3.Append(cell50);
        row3.Append(cell51);
        row3.Append(cell52);
        row3.Append(cell53);
        row3.Append(cell54);
        row3.Append(cell55);
        row3.Append(cell56);
        row3.Append(cell57);
        row3.Append(cell58);
        row3.Append(cell59);
        row3.Append(cell60);
        row3.Append(cell61);

        var row4 = new Row
        {
            RowIndex = (UInt32Value)4U, Spans = new ListValue<StringValue> { InnerText = "1:36" }, Height = 15D,
            CustomHeight = true
        };
        var cell70 = new Cell { CellReference = "A4", StyleIndex = (UInt32Value)4U };

        var cell71 = new Cell
            { CellReference = "B4", StyleIndex = (UInt32Value)4U, DataType = CellValues.String };
        var cellValue4 = new CellValue
        {
            Text = "Год"
        };

        cell71.Append(cellValue4);

        var cell72 = new Cell { CellReference = "C4", StyleIndex = (UInt32Value)1U, DataType = CellValues.String };
        var cellValue5 = new CellValue
        {
            Text = _model.Year.ToString()
        };

        cell72.Append(cellValue5);
        var cell73 = new Cell { CellReference = "D4", StyleIndex = (UInt32Value)1U };
        var cell74 = new Cell { CellReference = "E4", StyleIndex = (UInt32Value)1U };
        var cell75 = new Cell { CellReference = "F4", StyleIndex = (UInt32Value)1U };
        var cell76 = new Cell { CellReference = "G4", StyleIndex = (UInt32Value)1U };
        var cell77 = new Cell { CellReference = "H4", StyleIndex = (UInt32Value)1U };
        var cell78 = new Cell { CellReference = "I4", StyleIndex = (UInt32Value)1U };
        var cell79 = new Cell { CellReference = "J4", StyleIndex = (UInt32Value)1U };
        var cell80 = new Cell { CellReference = "K4", StyleIndex = (UInt32Value)1U };
        var cell81 = new Cell { CellReference = "L4", StyleIndex = (UInt32Value)1U };
        var cell82 = new Cell { CellReference = "M4", StyleIndex = (UInt32Value)1U };
        var cell83 = new Cell { CellReference = "N4", StyleIndex = (UInt32Value)1U };
        var cell84 = new Cell { CellReference = "O4", StyleIndex = (UInt32Value)1U };

        row4.Append(cell70);
        row4.Append(cell71);
        row4.Append(cell72);
        row4.Append(cell73);
        row4.Append(cell74);
        row4.Append(cell75);
        row4.Append(cell76);
        row4.Append(cell77);
        row4.Append(cell78);
        row4.Append(cell79);
        row4.Append(cell80);
        row4.Append(cell81);
        row4.Append(cell82);
        row4.Append(cell83);
        row4.Append(cell84);

        var row5 = new Row
        {
            RowIndex = (UInt32Value)5U, Spans = new ListValue<StringValue> { InnerText = "1:36" }, Height = 15D,
            CustomHeight = true
        };
        var cell93 = new Cell { CellReference = "A5", StyleIndex = (UInt32Value)4U };

        var cell94 = new Cell
            { CellReference = "B5", StyleIndex = (UInt32Value)4U, DataType = CellValues.String };
        var cellValue6 = new CellValue
        {
            Text = "Месяц"
        };

        cell94.Append(cellValue6);

        var cell95 = new Cell { CellReference = "C5", StyleIndex = (UInt32Value)1U, DataType = CellValues.String };
        var cellValue7 = new CellValue
        {
            Text = _model.Month
        };

        cell95.Append(cellValue7);
        var cell96 = new Cell { CellReference = "D5", StyleIndex = (UInt32Value)1U };
        var cell97 = new Cell { CellReference = "E5", StyleIndex = (UInt32Value)1U };
        var cell98 = new Cell { CellReference = "F5", StyleIndex = (UInt32Value)1U };
        var cell99 = new Cell { CellReference = "G5", StyleIndex = (UInt32Value)1U };
        var cell100 = new Cell { CellReference = "H5", StyleIndex = (UInt32Value)1U };
        var cell101 = new Cell { CellReference = "I5", StyleIndex = (UInt32Value)1U };
        var cell102 = new Cell { CellReference = "J5", StyleIndex = (UInt32Value)1U };
        var cell103 = new Cell { CellReference = "K5", StyleIndex = (UInt32Value)1U };
        var cell104 = new Cell { CellReference = "L5", StyleIndex = (UInt32Value)1U };
        var cell105 = new Cell { CellReference = "M5", StyleIndex = (UInt32Value)1U };
        var cell106 = new Cell { CellReference = "N5", StyleIndex = (UInt32Value)1U };
        var cell107 = new Cell { CellReference = "O5", StyleIndex = (UInt32Value)1U };

        row5.Append(cell93);
        row5.Append(cell94);
        row5.Append(cell95);
        row5.Append(cell96);
        row5.Append(cell97);
        row5.Append(cell98);
        row5.Append(cell99);
        row5.Append(cell100);
        row5.Append(cell101);
        row5.Append(cell102);
        row5.Append(cell103);
        row5.Append(cell104);
        row5.Append(cell105);
        row5.Append(cell106);
        row5.Append(cell107);

        var row6 = new Row
            { RowIndex = (UInt32Value)6U, Spans = new ListValue<StringValue> { InnerText = "1:36" }, Height = 31.5D };

        var cell116 = new Cell
            { CellReference = "A6", StyleIndex = (UInt32Value)5U, DataType = CellValues.String };
        var cellValue8 = new CellValue
        {
            Text = "№"
        };

        cell116.Append(cellValue8);

        var cell117 = new Cell
            { CellReference = "B6", StyleIndex = (UInt32Value)5U, DataType = CellValues.String };
        var cellValue9 = new CellValue
        {
            Text = "Наименование дисциплины"
        };

        cell117.Append(cellValue9);

        var cell118 = new Cell
            { CellReference = "C6", StyleIndex = (UInt32Value)5U, DataType = CellValues.String };
        var cellValue10 = new CellValue
        {
            Text = "Группа"
        };

        cell118.Append(cellValue10);

        var cell119 = new Cell
            { CellReference = "D6", StyleIndex = (UInt32Value)5U, DataType = CellValues.String };
        var cellValue11 = new CellValue
        {
            Text = "б или в/б"
        };

        cell119.Append(cellValue11);

        row6.Append(cell116);
        row6.Append(cell117);
        row6.Append(cell118);
        row6.Append(cell119);

        for (var i = 1; i <= _model.DaysInMonthCount; i++)
        {
            var cellDay = new Cell
            {
                CellReference = GetCellReference(6, i + 4), StyleIndex = (UInt32Value)5U, DataType = CellValues.Number
            };
            var cellValueDay = new CellValue
            {
                Text = i.ToString()
            };
            cellDay.Append(cellValueDay);
            row6.Append(cellDay);
        }

        var cellSummary = new Cell
        {
            CellReference = GetCellReference(6, _model.DaysInMonthCount + 5), StyleIndex = (UInt32Value)5U,
            DataType = CellValues.String
        };
        var cellValueSummary = new CellValue
        {
            Text = "Итого"
        };

        cellSummary.Append(cellValueSummary);

        row6.Append(cellSummary);

        sheetData1.Append(row1);
        sheetData1.Append(row2);
        sheetData1.Append(row3);
        sheetData1.Append(row4);
        sheetData1.Append(row5);
        sheetData1.Append(row6);

        AppendTableBody(sheetData1);

        var mergeCells1 = new MergeCells { Count = (UInt32Value)4U };
        var mergeCell1 = new MergeCell { Reference = "B2:O2" };
        var mergeCell2 = new MergeCell { Reference = "C3:O3" };
        var mergeCell3 = new MergeCell { Reference = "C4:O4" };
        var mergeCell4 = new MergeCell { Reference = "C5:O5" };

        mergeCells1.Append(mergeCell1);
        mergeCells1.Append(mergeCell2);
        mergeCells1.Append(mergeCell3);
        mergeCells1.Append(mergeCell4);
        var pageMargins1 = new PageMargins
        {
            Left = 0.78749999999999998D, Right = 0.78749999999999998D, Top = 1.05277777777778D,
            Bottom = 1.05277777777778D, Header = 0.78749999999999998D, Footer = 0.78749999999999998D
        };
        var pageSetup1 = new PageSetup
        {
            PaperSize = (UInt32Value)9U, Orientation = OrientationValues.Portrait, UseFirstPageNumber = true,
            HorizontalDpi = (UInt32Value)300U, VerticalDpi = (UInt32Value)300U, Id = "rId1"
        };

        var headerFooter1 = new HeaderFooter();
        var oddHeader1 = new OddHeader
        {
            Text = "&C&\"Times New Roman,Regular\"&12&A"
        };
        var oddFooter1 = new OddFooter
        {
            Text = "&C&\"Times New Roman,Regular\"&12Page &P"
        };

        headerFooter1.Append(oddHeader1);
        headerFooter1.Append(oddFooter1);

        worksheet1.Append(sheetDimension1);
        worksheet1.Append(sheetViews1);
        worksheet1.Append(sheetFormatProperties1);
        worksheet1.Append(columns1);
        worksheet1.Append(sheetData1);
        worksheet1.Append(mergeCells1);
        worksheet1.Append(pageMargins1);
        worksheet1.Append(pageSetup1);
        worksheet1.Append(headerFooter1);

        worksheetPart1.Worksheet = worksheet1;
    }

    public static string GetCellReference(UInt32Value rowIndex, int columIndex)
    {
        var n = columIndex;
        var s = "";
        while (n > 26)
        {
            s = new string((char)(64 + n % 26), 1) + s;
            n /= 26;
        }

        s = new string((char)(64 + n % 26), 1) + s;
        var cellReference = $"{s}{rowIndex}";
        return cellReference;
    }

    private void AppendTableBody(OpenXmlElement sheetData)
    {
        var rowIndex = (UInt32Value)7U;
        var number = 1;
        var dayInMonth = _model.DaysInMonthCount;

        foreach (var item in _model.Items)
        {
            var row = new Row { RowIndex = rowIndex, Spans = new ListValue<StringValue> { InnerText = "1:36" } };

            var cell = new Cell
            {
                CellReference = GetCellReference(rowIndex, 1), StyleIndex = (UInt32Value)5U,
                DataType = CellValues.Number
            };
            var cellValue = new CellValue
            {
                Text = number.ToString()
            };

            cell.Append(cellValue);
            row.Append(cell);

            cell = new Cell
            {
                CellReference = GetCellReference(rowIndex, 2), StyleIndex = (UInt32Value)7U,
                DataType = CellValues.String
            };
            cellValue = new CellValue
            {
                Text = item.SubjectName
            };

            cell.Append(cellValue);
            row.Append(cell);

            cell = new Cell
            {
                CellReference = GetCellReference(rowIndex, 3), StyleIndex = (UInt32Value)7U,
                DataType = CellValues.String
            };
            cellValue = new CellValue
            {
                Text = item.GroupName
            };

            cell.Append(cellValue);
            row.Append(cell);

            cell = new Cell
            {
                CellReference = GetCellReference(rowIndex, 4), StyleIndex = (UInt32Value)7U,
                DataType = CellValues.String
            };
            cellValue = new CellValue
            {
                Text = item.FinanceEnrollmentType
            };

            cell.Append(cellValue);
            row.Append(cell);

            var columnIndex = 5;
            var daysEnd = 5 + dayInMonth;
            foreach (var day in item.Days)
            {
                cell = new Cell
                {
                    CellReference = GetCellReference(rowIndex, columnIndex), StyleIndex = (UInt32Value)8U,
                    DataType = CellValues.Number
                };
                cellValue = new CellValue
                {
                    Text = day.Hours.ToString()
                };
                cell.Append(cellValue);
                row.Append(cell);
                columnIndex++;
            }
            
            cell = new Cell
            {
                CellReference = GetCellReference(rowIndex, daysEnd), StyleIndex = (UInt32Value)9U,
                DataType = CellValues.Number
            };
            var cellFormula = new CellFormula
            {
                Text = $"SUM({GetCellReference(rowIndex, 5)}:{GetCellReference(rowIndex, daysEnd - 1)})"
            };
            cellValue = new CellValue
            {
                Text = item.TotalHours.ToString()
            };

            cell.Append(cellFormula);
            cell.Append(cellValue);
            row.Append(cell);
            sheetData.Append(row);
            rowIndex++;
            number++;
        }
    }

    // Generates content of spreadsheetPrinterSettingsPart1.
    private void GenerateSpreadsheetPrinterSettingsPart1Content(
        SpreadsheetPrinterSettingsPart spreadsheetPrinterSettingsPart1)
    {
        var data = GetBinaryDataStream(spreadsheetPrinterSettingsPart1Data);
        spreadsheetPrinterSettingsPart1.FeedData(data);
        data.Close();
    }

    // Generates content of calculationChainPart1.
    private void GenerateCalculationChainPart1Content(CalculationChainPart calculationChainPart1)
    {
        var calculationChain1 = new CalculationChain();
        UInt32Value rowIndex = 7;
        var summaryColumn = _model.DaysInMonthCount + 5;
        foreach (var _ in _model.Items)
        {
            var calculationCell = new CalculationCell
                { CellReference = GetCellReference(rowIndex, summaryColumn), SheetId = 1 };
            calculationChain1.Append(calculationCell);
            rowIndex++;
        }

        calculationChainPart1.CalculationChain = calculationChain1;
    }

    // Generates content of sharedStringTablePart1.
    private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
    {
        var sharedStringTable1 = new SharedStringTable { Count = (UInt32Value)0U, UniqueCount = (UInt32Value)0U };

        sharedStringTablePart1.SharedStringTable = sharedStringTable1;
    }

    // Generates content of extendedFilePropertiesPart1.
    private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
    {
        var properties1 = new Ap.Properties();
        properties1.AddNamespaceDeclaration("vt",
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
        var template1 = new Ap.Template
        {
            Text = ""
        };
        var totalTime1 = new Ap.TotalTime
        {
            Text = "2"
        };
        var application1 = new Ap.Application
        {
            Text = "TechnicalSchoolAutomationSystem"
        };
        var documentSecurity1 = new Ap.DocumentSecurity
        {
            Text = "0"
        };
        var scaleCrop1 = new Ap.ScaleCrop
        {
            Text = "false"
        };

        var headingPairs1 = new Ap.HeadingPairs();

        var vTVector1 = new Vt.VTVector { BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

        var variant1 = new Vt.Variant();
        var vTLPSTR1 = new Vt.VTLPSTR
        {
            Text = "Листы"
        };

        variant1.Append(vTLPSTR1);

        var variant2 = new Vt.Variant();
        var vTInt321 = new Vt.VTInt32
        {
            Text = "1"
        };

        variant2.Append(vTInt321);

        vTVector1.Append(variant1);
        vTVector1.Append(variant2);

        headingPairs1.Append(vTVector1);

        var titlesOfParts1 = new Ap.TitlesOfParts();

        var vTVector2 = new Vt.VTVector { BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
        var vTLPSTR2 = new Vt.VTLPSTR
        {
            Text = "Данные"
        };

        vTVector2.Append(vTLPSTR2);

        titlesOfParts1.Append(vTVector2);
        var linksUpToDate1 = new Ap.LinksUpToDate
        {
            Text = "false"
        };
        var sharedDocument1 = new Ap.SharedDocument
        {
            Text = "false"
        };
        var hyperlinksChanged1 = new Ap.HyperlinksChanged
        {
            Text = "false"
        };
        var applicationVersion1 = new Ap.ApplicationVersion
        {
            Text = "0.1"
        };

        properties1.Append(template1);
        properties1.Append(totalTime1);
        properties1.Append(application1);
        properties1.Append(documentSecurity1);
        properties1.Append(scaleCrop1);
        properties1.Append(headingPairs1);
        properties1.Append(titlesOfParts1);
        properties1.Append(linksUpToDate1);
        properties1.Append(sharedDocument1);
        properties1.Append(hyperlinksChanged1);
        properties1.Append(applicationVersion1);

        extendedFilePropertiesPart1.Properties = properties1;
    }

    private void SetPackageProperties(OpenXmlPackage document)
    {
        document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2022-05-22T11:25:42Z",
            System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
        document.PackageProperties.LastModifiedBy = "Admin";
    }

    #region Binary Data

    private string extendedPart1Data =
        "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAyMi0wNS0yMlQxNjowMDo0MVo8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj48L2RjOmNyZWF0b3I+PGRjOmRlc2NyaXB0aW9uPjwvZGM6ZGVzY3JpcHRpb24+PGRjOmxhbmd1YWdlPnJ1LVJVPC9kYzpsYW5ndWFnZT48Y3A6bGFzdE1vZGlmaWVkQnk+PC9jcDpsYXN0TW9kaWZpZWRCeT48ZGN0ZXJtczptb2RpZmllZCB4c2k6dHlwZT0iZGN0ZXJtczpXM0NEVEYiPjIwMjItMDUtMjJUMTY6MTM6MzlaPC9kY3Rlcm1zOm1vZGlmaWVkPjxjcDpyZXZpc2lvbj4xPC9jcDpyZXZpc2lvbj48ZGM6c3ViamVjdD48L2RjOnN1YmplY3Q+PGRjOnRpdGxlPjwvZGM6dGl0bGU+PC9jcDpjb3JlUHJvcGVydGllcz4=";

    private string spreadsheetPrinterSettingsPart1Data =
        "TQBpAGMAcgBvAHMAbwBmAHQAIABQAHIAaQBuAHQAIAB0AG8AIABQAEQARgAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEAwbcAFAUAy8BAAEACQCaCzQIZAABAA8AWAICAAEAWAIDAAEAQQA0AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAAAAAABAAAAAgAAAAEAAAD/////R0lTNAAAAAAAAAAAAAAAAERJTlUiAMgAJAMsET9de34AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABQAAAAAABQABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADIAAAAU01USgAAAAAQALgAewAwADgANABGADAAMQBGAEEALQBFADYAMwA0AC0ANABEADcANwAtADgAMwBFAEUALQAwADcANAA4ADEANwBDADAAMwA1ADgAMQB9AAAAUkVTRExMAFVuaXJlc0RMTABQYXBlclNpemUAQTQAT3JpZW50YXRpb24AUE9SVFJBSVQAUmVzb2x1dGlvbgBSZXNPcHRpb24xAENvbG9yTW9kZQBDb2xvcgAAAAAAAAAAAAAAAAAAAAAAACwRAABWNERNAQAAAAAAAACcCnAiHAAAAOwAAAADAAAA+gFPCDTmd02D7gdIF8A1gdAAAABMAAAAAwAAAAAIAAAAAAAAAAAAAAMAAAAACAAAKgAAAAAIAAADAAAAQAAAAFYAAAAAEAAARABvAGMAdQBtAGUAbgB0AFUAcwBlAHIAUABhAHMAcwB3AG8AcgBkAAAARABvAGMAdQBtAGUAbgB0AE8AdwBuAGUAcgBQAGEAcwBzAHcAbwByAGQAAABEAG8AYwB1AG0AZQBuAHQAQwByAHkAcAB0AFMAZQBjAHUAcgBpAHQAeQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=";

    private Stream GetBinaryDataStream(string base64String)
    {
        return new MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion
}