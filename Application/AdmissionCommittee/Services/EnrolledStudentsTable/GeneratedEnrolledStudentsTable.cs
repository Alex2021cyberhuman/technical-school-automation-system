using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Application.AdmissionCommittee.Services.EnrolledStudentsTable;

public class GeneratedEnrolledStudentsTable
{
    private readonly EnrolledStudentsTableModel _model;

    // Creates a SpreadsheetDocument.
    public GeneratedEnrolledStudentsTable(EnrolledStudentsTableModel model)
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
        var extendedPart1 = document.AddExtendedPart("http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties", "application/vnd.openxmlformats-package.core-properties+xml", "xml", "rId2");
        GenerateExtendedPart1Content(extendedPart1);

        var workbookPart1 = document.AddWorkbookPart();
        GenerateWorkbookPart1Content(workbookPart1);

        var workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
        GenerateWorkbookStylesPart1Content(workbookStylesPart1);

        var themePart1 = workbookPart1.AddNewPart<ThemePart>("rId2");
        GenerateThemePart1Content(themePart1);

        var worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
        GenerateWorksheetPart1Content(worksheetPart1);

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
        var fileVersion1 = new FileVersion { ApplicationName = "xl", LastEdited = "4", LowestEdited = "4", BuildVersion = "4506" };
        var workbookProperties1 = new WorkbookProperties { DefaultThemeVersion = (UInt32Value)124226U };

        var bookViews1 = new BookViews();
        var workbookView1 = new WorkbookView { XWindow = 0, YWindow = 0, WindowWidth = (UInt32Value)16380U, WindowHeight = (UInt32Value)8196U, TabRatio = (UInt32Value)500U };

        bookViews1.Append(workbookView1);

        var sheets1 = new Sheets();
        var sheet1 = new Sheet { Name = "Лист1", SheetId = (UInt32Value)1U, Id = "rId1" };

        sheets1.Append(sheet1);
        var calculationProperties1 = new CalculationProperties { CalculationId = (UInt32Value)125725U };

        var workbookExtensionList1 = new WorkbookExtensionList();

        var workbookExtension1 = new WorkbookExtension { Uri = "{7626C862-2A13-11E5-B345-FEFF819CDC9F}" };
        workbookExtension1.AddNamespaceDeclaration("loext", "http://schemas.libreoffice.org/");

        var openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<loext:extCalcPr stringRefSyntax=\"CalcA1\" xmlns:loext=\"http://schemas.libreoffice.org/\" />");

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

        var fonts1 = new Fonts { Count = (UInt32Value)1U };

        var font1 = new Font();
        var fontSize1 = new FontSize { Val = 11D };
        var color1 = new Color { Rgb = "FF000000" };
        var fontName1 = new FontName { Val = "Calibri" };
        var fontFamilyNumbering1 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet1 = new FontCharSet { Val = 204 };

        font1.Append(fontSize1);
        font1.Append(color1);
        font1.Append(fontName1);
        font1.Append(fontFamilyNumbering1);
        font1.Append(fontCharSet1);

        fonts1.Append(font1);

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
        var color2 = new Color { Auto = true };

        leftBorder2.Append(color2);

        var rightBorder2 = new RightBorder { Style = BorderStyleValues.Thin };
        var color3 = new Color { Auto = true };

        rightBorder2.Append(color3);

        var topBorder2 = new TopBorder { Style = BorderStyleValues.Thin };
        var color4 = new Color { Auto = true };

        topBorder2.Append(color4);

        var bottomBorder2 = new BottomBorder { Style = BorderStyleValues.Thin };
        var color5 = new Color { Auto = true };

        bottomBorder2.Append(color5);
        var diagonalBorder2 = new DiagonalBorder();

        border2.Append(leftBorder2);
        border2.Append(rightBorder2);
        border2.Append(topBorder2);
        border2.Append(bottomBorder2);
        border2.Append(diagonalBorder2);

        borders1.Append(border1);
        borders1.Append(border2);

        var cellStyleFormats1 = new CellStyleFormats { Count = (UInt32Value)1U };
        var cellFormat1 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

        cellStyleFormats1.Append(cellFormat1);

        var cellFormats1 = new CellFormats { Count = (UInt32Value)7U };
        var cellFormat2 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };

        var cellFormat3 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyAlignment = true };
        var alignment1 = new Alignment { Horizontal = HorizontalAlignmentValues.Center };

        cellFormat3.Append(alignment1);
        var cellFormat4 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyAlignment = true };

        var cellFormat5 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyAlignment = true };
        var alignment2 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top };

        cellFormat5.Append(alignment2);

        var cellFormat6 = new CellFormat { NumberFormatId = (UInt32Value)49U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment3 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top, WrapText = true };

        cellFormat6.Append(alignment3);

        var cellFormat7 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment4 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

        cellFormat7.Append(alignment4);
        var cellFormat8 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyAlignment = true };

        cellFormats1.Append(cellFormat2);
        cellFormats1.Append(cellFormat3);
        cellFormats1.Append(cellFormat4);
        cellFormats1.Append(cellFormat5);
        cellFormats1.Append(cellFormat6);
        cellFormats1.Append(cellFormat7);
        cellFormats1.Append(cellFormat8);

        var cellStyles1 = new CellStyles { Count = (UInt32Value)1U };
        var cellStyle1 = new CellStyle { Name = "Обычный", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

        cellStyles1.Append(cellStyle1);
        var differentialFormats1 = new DifferentialFormats { Count = (UInt32Value)0U };
        var tableStyles1 = new TableStyles { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium9", DefaultPivotStyle = "PivotStyleLight16" };

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
        var theme1 = new DocumentFormat.OpenXml.Drawing.Theme { Name = "Тема Office" };
        theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

        var themeElements1 = new DocumentFormat.OpenXml.Drawing.ThemeElements();

        var colorScheme1 = new DocumentFormat.OpenXml.Drawing.ColorScheme { Name = "Стандартная" };

        var dark1Color1 = new DocumentFormat.OpenXml.Drawing.Dark1Color();
        var systemColor1 = new DocumentFormat.OpenXml.Drawing.SystemColor { Val = DocumentFormat.OpenXml.Drawing.SystemColorValues.WindowText, LastColor = "000000" };

        dark1Color1.Append(systemColor1);

        var light1Color1 = new DocumentFormat.OpenXml.Drawing.Light1Color();
        var systemColor2 = new DocumentFormat.OpenXml.Drawing.SystemColor { Val = DocumentFormat.OpenXml.Drawing.SystemColorValues.Window, LastColor = "FFFFFF" };

        light1Color1.Append(systemColor2);

        var dark2Color1 = new DocumentFormat.OpenXml.Drawing.Dark2Color();
        var rgbColorModelHex1 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "1F497D" };

        dark2Color1.Append(rgbColorModelHex1);

        var light2Color1 = new DocumentFormat.OpenXml.Drawing.Light2Color();
        var rgbColorModelHex2 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "EEECE1" };

        light2Color1.Append(rgbColorModelHex2);

        var accent1Color1 = new DocumentFormat.OpenXml.Drawing.Accent1Color();
        var rgbColorModelHex3 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "4F81BD" };

        accent1Color1.Append(rgbColorModelHex3);

        var accent2Color1 = new DocumentFormat.OpenXml.Drawing.Accent2Color();
        var rgbColorModelHex4 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "C0504D" };

        accent2Color1.Append(rgbColorModelHex4);

        var accent3Color1 = new DocumentFormat.OpenXml.Drawing.Accent3Color();
        var rgbColorModelHex5 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "9BBB59" };

        accent3Color1.Append(rgbColorModelHex5);

        var accent4Color1 = new DocumentFormat.OpenXml.Drawing.Accent4Color();
        var rgbColorModelHex6 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "8064A2" };

        accent4Color1.Append(rgbColorModelHex6);

        var accent5Color1 = new DocumentFormat.OpenXml.Drawing.Accent5Color();
        var rgbColorModelHex7 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "4BACC6" };

        accent5Color1.Append(rgbColorModelHex7);

        var accent6Color1 = new DocumentFormat.OpenXml.Drawing.Accent6Color();
        var rgbColorModelHex8 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "F79646" };

        accent6Color1.Append(rgbColorModelHex8);

        var hyperlink1 = new DocumentFormat.OpenXml.Drawing.Hyperlink();
        var rgbColorModelHex9 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "0000FF" };

        hyperlink1.Append(rgbColorModelHex9);

        var followedHyperlinkColor1 = new DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor();
        var rgbColorModelHex10 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "800080" };

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

        var fontScheme1 = new DocumentFormat.OpenXml.Drawing.FontScheme { Name = "Стандартная" };

        var majorFont1 = new DocumentFormat.OpenXml.Drawing.MajorFont();
        var latinFont1 = new DocumentFormat.OpenXml.Drawing.LatinFont { Typeface = "Cambria" };
        var eastAsianFont1 = new DocumentFormat.OpenXml.Drawing.EastAsianFont { Typeface = "" };
        var complexScriptFont1 = new DocumentFormat.OpenXml.Drawing.ComplexScriptFont { Typeface = "" };
        var supplementalFont1 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
        var supplementalFont2 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" };
        var supplementalFont3 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hans", Typeface = "宋体" };
        var supplementalFont4 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hant", Typeface = "新細明體" };
        var supplementalFont5 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Arab", Typeface = "Times New Roman" };
        var supplementalFont6 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hebr", Typeface = "Times New Roman" };
        var supplementalFont7 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Thai", Typeface = "Tahoma" };
        var supplementalFont8 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Ethi", Typeface = "Nyala" };
        var supplementalFont9 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Beng", Typeface = "Vrinda" };
        var supplementalFont10 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Gujr", Typeface = "Shruti" };
        var supplementalFont11 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Khmr", Typeface = "MoolBoran" };
        var supplementalFont12 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Knda", Typeface = "Tunga" };
        var supplementalFont13 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Guru", Typeface = "Raavi" };
        var supplementalFont14 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Cans", Typeface = "Euphemia" };
        var supplementalFont15 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" };
        var supplementalFont16 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
        var supplementalFont17 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" };
        var supplementalFont18 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Thaa", Typeface = "MV Boli" };
        var supplementalFont19 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Deva", Typeface = "Mangal" };
        var supplementalFont20 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Telu", Typeface = "Gautami" };
        var supplementalFont21 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Taml", Typeface = "Latha" };
        var supplementalFont22 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" };
        var supplementalFont23 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Orya", Typeface = "Kalinga" };
        var supplementalFont24 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Mlym", Typeface = "Kartika" };
        var supplementalFont25 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Laoo", Typeface = "DokChampa" };
        var supplementalFont26 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" };
        var supplementalFont27 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" };
        var supplementalFont28 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Viet", Typeface = "Times New Roman" };
        var supplementalFont29 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" };

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

        var minorFont1 = new DocumentFormat.OpenXml.Drawing.MinorFont();
        var latinFont2 = new DocumentFormat.OpenXml.Drawing.LatinFont { Typeface = "Calibri" };
        var eastAsianFont2 = new DocumentFormat.OpenXml.Drawing.EastAsianFont { Typeface = "" };
        var complexScriptFont2 = new DocumentFormat.OpenXml.Drawing.ComplexScriptFont { Typeface = "" };
        var supplementalFont30 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
        var supplementalFont31 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" };
        var supplementalFont32 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hans", Typeface = "宋体" };
        var supplementalFont33 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hant", Typeface = "新細明體" };
        var supplementalFont34 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Arab", Typeface = "Arial" };
        var supplementalFont35 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Hebr", Typeface = "Arial" };
        var supplementalFont36 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Thai", Typeface = "Tahoma" };
        var supplementalFont37 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Ethi", Typeface = "Nyala" };
        var supplementalFont38 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Beng", Typeface = "Vrinda" };
        var supplementalFont39 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Gujr", Typeface = "Shruti" };
        var supplementalFont40 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Khmr", Typeface = "DaunPenh" };
        var supplementalFont41 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Knda", Typeface = "Tunga" };
        var supplementalFont42 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Guru", Typeface = "Raavi" };
        var supplementalFont43 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Cans", Typeface = "Euphemia" };
        var supplementalFont44 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" };
        var supplementalFont45 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
        var supplementalFont46 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" };
        var supplementalFont47 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Thaa", Typeface = "MV Boli" };
        var supplementalFont48 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Deva", Typeface = "Mangal" };
        var supplementalFont49 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Telu", Typeface = "Gautami" };
        var supplementalFont50 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Taml", Typeface = "Latha" };
        var supplementalFont51 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" };
        var supplementalFont52 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Orya", Typeface = "Kalinga" };
        var supplementalFont53 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Mlym", Typeface = "Kartika" };
        var supplementalFont54 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Laoo", Typeface = "DokChampa" };
        var supplementalFont55 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" };
        var supplementalFont56 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" };
        var supplementalFont57 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Viet", Typeface = "Arial" };
        var supplementalFont58 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" };

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

        var formatScheme1 = new DocumentFormat.OpenXml.Drawing.FormatScheme { Name = "Стандартная" };

        var fillStyleList1 = new DocumentFormat.OpenXml.Drawing.FillStyleList();

        var solidFill1 = new DocumentFormat.OpenXml.Drawing.SolidFill();
        var schemeColor1 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

        solidFill1.Append(schemeColor1);

        var gradientFill1 = new DocumentFormat.OpenXml.Drawing.GradientFill { RotateWithShape = true };

        var gradientStopList1 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

        var gradientStop1 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 0 };

        var schemeColor2 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint1 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 50000 };
        var saturationModulation1 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 300000 };

        schemeColor2.Append(tint1);
        schemeColor2.Append(saturationModulation1);

        gradientStop1.Append(schemeColor2);

        var gradientStop2 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 35000 };

        var schemeColor3 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint2 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 37000 };
        var saturationModulation2 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 300000 };

        schemeColor3.Append(tint2);
        schemeColor3.Append(saturationModulation2);

        gradientStop2.Append(schemeColor3);

        var gradientStop3 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 100000 };

        var schemeColor4 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint3 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 15000 };
        var saturationModulation3 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 350000 };

        schemeColor4.Append(tint3);
        schemeColor4.Append(saturationModulation3);

        gradientStop3.Append(schemeColor4);

        gradientStopList1.Append(gradientStop1);
        gradientStopList1.Append(gradientStop2);
        gradientStopList1.Append(gradientStop3);
        var linearGradientFill1 = new DocumentFormat.OpenXml.Drawing.LinearGradientFill { Angle = 16200000, Scaled = true };

        gradientFill1.Append(gradientStopList1);
        gradientFill1.Append(linearGradientFill1);

        var gradientFill2 = new DocumentFormat.OpenXml.Drawing.GradientFill { RotateWithShape = true };

        var gradientStopList2 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

        var gradientStop4 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 0 };

        var schemeColor5 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade1 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 51000 };
        var saturationModulation4 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 130000 };

        schemeColor5.Append(shade1);
        schemeColor5.Append(saturationModulation4);

        gradientStop4.Append(schemeColor5);

        var gradientStop5 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 80000 };

        var schemeColor6 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade2 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 93000 };
        var saturationModulation5 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 130000 };

        schemeColor6.Append(shade2);
        schemeColor6.Append(saturationModulation5);

        gradientStop5.Append(schemeColor6);

        var gradientStop6 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 100000 };

        var schemeColor7 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade3 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 94000 };
        var saturationModulation6 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 135000 };

        schemeColor7.Append(shade3);
        schemeColor7.Append(saturationModulation6);

        gradientStop6.Append(schemeColor7);

        gradientStopList2.Append(gradientStop4);
        gradientStopList2.Append(gradientStop5);
        gradientStopList2.Append(gradientStop6);
        var linearGradientFill2 = new DocumentFormat.OpenXml.Drawing.LinearGradientFill { Angle = 16200000, Scaled = false };

        gradientFill2.Append(gradientStopList2);
        gradientFill2.Append(linearGradientFill2);

        fillStyleList1.Append(solidFill1);
        fillStyleList1.Append(gradientFill1);
        fillStyleList1.Append(gradientFill2);

        var lineStyleList1 = new DocumentFormat.OpenXml.Drawing.LineStyleList();

        var outline1 = new DocumentFormat.OpenXml.Drawing.Outline { Width = 9525, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

        var solidFill2 = new DocumentFormat.OpenXml.Drawing.SolidFill();

        var schemeColor8 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade4 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 95000 };
        var saturationModulation7 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 105000 };

        schemeColor8.Append(shade4);
        schemeColor8.Append(saturationModulation7);

        solidFill2.Append(schemeColor8);
        var presetDash1 = new DocumentFormat.OpenXml.Drawing.PresetDash { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

        outline1.Append(solidFill2);
        outline1.Append(presetDash1);

        var outline2 = new DocumentFormat.OpenXml.Drawing.Outline { Width = 25400, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

        var solidFill3 = new DocumentFormat.OpenXml.Drawing.SolidFill();
        var schemeColor9 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

        solidFill3.Append(schemeColor9);
        var presetDash2 = new DocumentFormat.OpenXml.Drawing.PresetDash { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

        outline2.Append(solidFill3);
        outline2.Append(presetDash2);

        var outline3 = new DocumentFormat.OpenXml.Drawing.Outline { Width = 38100, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

        var solidFill4 = new DocumentFormat.OpenXml.Drawing.SolidFill();
        var schemeColor10 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

        solidFill4.Append(schemeColor10);
        var presetDash3 = new DocumentFormat.OpenXml.Drawing.PresetDash { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

        outline3.Append(solidFill4);
        outline3.Append(presetDash3);

        lineStyleList1.Append(outline1);
        lineStyleList1.Append(outline2);
        lineStyleList1.Append(outline3);

        var effectStyleList1 = new DocumentFormat.OpenXml.Drawing.EffectStyleList();

        var effectStyle1 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

        var effectList1 = new DocumentFormat.OpenXml.Drawing.EffectList();

        var outerShadow1 = new DocumentFormat.OpenXml.Drawing.OuterShadow { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex11 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "000000" };
        var alpha1 = new DocumentFormat.OpenXml.Drawing.Alpha { Val = 38000 };

        rgbColorModelHex11.Append(alpha1);

        outerShadow1.Append(rgbColorModelHex11);

        effectList1.Append(outerShadow1);

        effectStyle1.Append(effectList1);

        var effectStyle2 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

        var effectList2 = new DocumentFormat.OpenXml.Drawing.EffectList();

        var outerShadow2 = new DocumentFormat.OpenXml.Drawing.OuterShadow { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex12 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "000000" };
        var alpha2 = new DocumentFormat.OpenXml.Drawing.Alpha { Val = 35000 };

        rgbColorModelHex12.Append(alpha2);

        outerShadow2.Append(rgbColorModelHex12);

        effectList2.Append(outerShadow2);

        effectStyle2.Append(effectList2);

        var effectStyle3 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

        var effectList3 = new DocumentFormat.OpenXml.Drawing.EffectList();

        var outerShadow3 = new DocumentFormat.OpenXml.Drawing.OuterShadow { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex13 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "000000" };
        var alpha3 = new DocumentFormat.OpenXml.Drawing.Alpha { Val = 35000 };

        rgbColorModelHex13.Append(alpha3);

        outerShadow3.Append(rgbColorModelHex13);

        effectList3.Append(outerShadow3);

        var scene3DType1 = new DocumentFormat.OpenXml.Drawing.Scene3DType();

        var camera1 = new DocumentFormat.OpenXml.Drawing.Camera { Preset = DocumentFormat.OpenXml.Drawing.PresetCameraValues.OrthographicFront };
        var rotation1 = new DocumentFormat.OpenXml.Drawing.Rotation { Latitude = 0, Longitude = 0, Revolution = 0 };

        camera1.Append(rotation1);

        var lightRig1 = new DocumentFormat.OpenXml.Drawing.LightRig { Rig = DocumentFormat.OpenXml.Drawing.LightRigValues.ThreePoints, Direction = DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Top };
        var rotation2 = new DocumentFormat.OpenXml.Drawing.Rotation { Latitude = 0, Longitude = 0, Revolution = 1200000 };

        lightRig1.Append(rotation2);

        scene3DType1.Append(camera1);
        scene3DType1.Append(lightRig1);

        var shape3DType1 = new DocumentFormat.OpenXml.Drawing.Shape3DType();
        var bevelTop1 = new DocumentFormat.OpenXml.Drawing.BevelTop { Width = 63500L, Height = 25400L };

        shape3DType1.Append(bevelTop1);

        effectStyle3.Append(effectList3);
        effectStyle3.Append(scene3DType1);
        effectStyle3.Append(shape3DType1);

        effectStyleList1.Append(effectStyle1);
        effectStyleList1.Append(effectStyle2);
        effectStyleList1.Append(effectStyle3);

        var backgroundFillStyleList1 = new DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList();

        var solidFill5 = new DocumentFormat.OpenXml.Drawing.SolidFill();
        var schemeColor11 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

        solidFill5.Append(schemeColor11);

        var gradientFill3 = new DocumentFormat.OpenXml.Drawing.GradientFill { RotateWithShape = true };

        var gradientStopList3 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

        var gradientStop7 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 0 };

        var schemeColor12 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint4 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 40000 };
        var saturationModulation8 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 350000 };

        schemeColor12.Append(tint4);
        schemeColor12.Append(saturationModulation8);

        gradientStop7.Append(schemeColor12);

        var gradientStop8 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 40000 };

        var schemeColor13 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint5 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 45000 };
        var shade5 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 99000 };
        var saturationModulation9 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 350000 };

        schemeColor13.Append(tint5);
        schemeColor13.Append(shade5);
        schemeColor13.Append(saturationModulation9);

        gradientStop8.Append(schemeColor13);

        var gradientStop9 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 100000 };

        var schemeColor14 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade6 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 20000 };
        var saturationModulation10 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 255000 };

        schemeColor14.Append(shade6);
        schemeColor14.Append(saturationModulation10);

        gradientStop9.Append(schemeColor14);

        gradientStopList3.Append(gradientStop7);
        gradientStopList3.Append(gradientStop8);
        gradientStopList3.Append(gradientStop9);

        var pathGradientFill1 = new DocumentFormat.OpenXml.Drawing.PathGradientFill { Path = DocumentFormat.OpenXml.Drawing.PathShadeValues.Circle };
        var fillToRectangle1 = new DocumentFormat.OpenXml.Drawing.FillToRectangle { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

        pathGradientFill1.Append(fillToRectangle1);

        gradientFill3.Append(gradientStopList3);
        gradientFill3.Append(pathGradientFill1);

        var gradientFill4 = new DocumentFormat.OpenXml.Drawing.GradientFill { RotateWithShape = true };

        var gradientStopList4 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

        var gradientStop10 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 0 };

        var schemeColor15 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var tint6 = new DocumentFormat.OpenXml.Drawing.Tint { Val = 80000 };
        var saturationModulation11 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 300000 };

        schemeColor15.Append(tint6);
        schemeColor15.Append(saturationModulation11);

        gradientStop10.Append(schemeColor15);

        var gradientStop11 = new DocumentFormat.OpenXml.Drawing.GradientStop { Position = 100000 };

        var schemeColor16 = new DocumentFormat.OpenXml.Drawing.SchemeColor { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
        var shade7 = new DocumentFormat.OpenXml.Drawing.Shade { Val = 30000 };
        var saturationModulation12 = new DocumentFormat.OpenXml.Drawing.SaturationModulation { Val = 200000 };

        schemeColor16.Append(shade7);
        schemeColor16.Append(saturationModulation12);

        gradientStop11.Append(schemeColor16);

        gradientStopList4.Append(gradientStop10);
        gradientStopList4.Append(gradientStop11);

        var pathGradientFill2 = new DocumentFormat.OpenXml.Drawing.PathGradientFill { Path = DocumentFormat.OpenXml.Drawing.PathShadeValues.Circle };
        var fillToRectangle2 = new DocumentFormat.OpenXml.Drawing.FillToRectangle { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

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
        var objectDefaults1 = new DocumentFormat.OpenXml.Drawing.ObjectDefaults();
        var extraColorSchemeList1 = new DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList();

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
        var sheetDimension1 = new SheetDimension { Reference = "A2:C8" };

        var sheetViews1 = new SheetViews();

        var sheetView1 = new SheetView { TabSelected = true, ZoomScaleNormal = (UInt32Value)100U, WorkbookViewId = (UInt32Value)0U };
        var selection1 = new Selection { ActiveCell = "C4", SequenceOfReferences = new ListValue<StringValue> { InnerText = "C4" } };

        sheetView1.Append(selection1);

        sheetViews1.Append(sheetView1);
        var sheetFormatProperties1 = new SheetFormatProperties { DefaultColumnWidth = 9D, DefaultRowHeight = 14.4D };

        var columns1 = new Columns();
        var column1 = new Column { Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 3.44140625D, CustomWidth = true };
        var column2 = new Column { Min = (UInt32Value)3U, Max = (UInt32Value)3U, Width = 53.88671875D, CustomWidth = true };
        var column3 = new Column { Min = (UInt32Value)4U, Max = (UInt32Value)4U, Width = 8.88671875D, CustomWidth = true };

        columns1.Append(column1);
        columns1.Append(column2);
        columns1.Append(column3);

        var sheetData1 = new SheetData();

        var row1 = new Row { RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue> { InnerText = "1:3" } };

        var cell1 = new Cell { CellReference = "C2", StyleIndex = (UInt32Value)1U, DataType = CellValues.SharedString };
        var cellValue1 = new CellValue
        {
            Text = "0"
        };

        cell1.Append(cellValue1);

        row1.Append(cell1);

        var row2 = new Row { RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue> { InnerText = "1:3" } };

        var cell2 = new Cell { CellReference = "B3", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue2 = new CellValue
        {
            Text = "1"
        };

        cell2.Append(cellValue2);

        var cell3 = new Cell { CellReference = "C3", StyleIndex = (UInt32Value)6U, DataType = CellValues.String };
        var cellValue3 = new CellValue
        {
            Text = _model.GroupName
        };

        cell3.Append(cellValue3);

        row2.Append(cell2);
        row2.Append(cell3);

        var row3 = new Row { RowIndex = (UInt32Value)5U, Spans = new ListValue<StringValue> { InnerText = "1:3" }, Height = 14.4D, CustomHeight = true };

        var cell4 = new Cell { CellReference = "B5", StyleIndex = (UInt32Value)5U, DataType = CellValues.SharedString };
        var cellValue4 = new CellValue
        {
            Text = "2"
        };

        cell4.Append(cellValue4);

        var cell5 = new Cell { CellReference = "C5", StyleIndex = (UInt32Value)5U, DataType = CellValues.SharedString };
        var cellValue5 = new CellValue
        {
            Text = "3"
        };

        cell5.Append(cellValue5);

        row3.Append(cell4);
        row3.Append(cell5);

        var row4 = new Row { RowIndex = (UInt32Value)6U, Spans = new ListValue<StringValue> { InnerText = "1:3" } };
        var cell6 = new Cell { CellReference = "B6", StyleIndex = (UInt32Value)5U };
        var cell7 = new Cell { CellReference = "C6", StyleIndex = (UInt32Value)5U };

        row4.Append(cell6);
        row4.Append(cell7);


        sheetData1.Append(row1);
        sheetData1.Append(row2);
        sheetData1.Append(row3);
        sheetData1.Append(row4);

        MakeEnrolledTable(sheetData1);

        var mergeCells1 = new MergeCells { Count = (UInt32Value)2U };
        var mergeCell1 = new MergeCell { Reference = "B5:B6" };
        var mergeCell2 = new MergeCell { Reference = "C5:C6" };

        mergeCells1.Append(mergeCell1);
        mergeCells1.Append(mergeCell2);
        var pageMargins1 = new PageMargins { Left = 0.31527777777777799D, Right = 0.31527777777777799D, Top = 0.39374999999999999D, Bottom = 0.35416666666666702D, Header = 0.511811023622047D, Footer = 0.511811023622047D };
        var pageSetup1 = new PageSetup { PaperSize = (UInt32Value)9U, Orientation = OrientationValues.Landscape, HorizontalDpi = (UInt32Value)300U, VerticalDpi = (UInt32Value)300U };

        worksheet1.Append(sheetDimension1);
        worksheet1.Append(sheetViews1);
        worksheet1.Append(sheetFormatProperties1);
        worksheet1.Append(columns1);
        worksheet1.Append(sheetData1);
        worksheet1.Append(mergeCells1);
        worksheet1.Append(pageMargins1);
        worksheet1.Append(pageSetup1);

        worksheetPart1.Worksheet = worksheet1;
    }

    private void MakeEnrolledTable(OpenXmlElement sheetData)
    {
        var rowIndex = 7U;
        foreach (var student in _model.Students)
        {
            var row = new Row { RowIndex = (UInt32Value)rowIndex, Spans = new ListValue<StringValue> { InnerText = "1:3" } };
            var cell1 = new Cell { CellReference = $"A{rowIndex}", StyleIndex = (UInt32Value)3U };

            var cell2 = new Cell { CellReference = $"B{rowIndex}", StyleIndex = (UInt32Value)4U, DataType = CellValues.String };
            var cellValue2
                = new CellValue
                {
                    Text = student.Number
                };

            cell2.Append(cellValue2);

            var cell3 = new Cell { CellReference = $"C{rowIndex}", StyleIndex = (UInt32Value)4U, DataType = CellValues.String };
            var cellValue3 = new CellValue
            {
                Text = student.FullName
            };

            cell3.Append(cellValue3);

            row.Append(cell1);
            row.Append(cell2);
            row.Append(cell3);

            sheetData.Append(row);
            rowIndex += 1;
        }
    }

    // Generates content of sharedStringTablePart1.
    private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
    {
        var sharedStringTable1 = new SharedStringTable { Count = (UInt32Value)9U, UniqueCount = (UInt32Value)9U };

        var sharedStringItem1 = new SharedStringItem();
        var text1 = new Text
        {
            Text = "СВОДНАЯ ВЕДОМОСТЬ"
        };

        sharedStringItem1.Append(text1);

        var sharedStringItem2 = new SharedStringItem();
        var text2 = new Text
        {
            Text = "Группа"
        };

        sharedStringItem2.Append(text2);

        var sharedStringItem3 = new SharedStringItem();
        var text3 = new Text
        {
            Text = "№ п.п"
        };

        sharedStringItem3.Append(text3);

        var sharedStringItem4 = new SharedStringItem();
        var text4 = new Text
        {
            Text = "ФИО"
        };

        sharedStringItem4.Append(text4);

        sharedStringTable1.Append(sharedStringItem1);
        sharedStringTable1.Append(sharedStringItem2);
        sharedStringTable1.Append(sharedStringItem3);
        sharedStringTable1.Append(sharedStringItem4);

        sharedStringTablePart1.SharedStringTable = sharedStringTable1;
    }

    // Generates content of extendedFilePropertiesPart1.
    private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
    {
        var properties1 = new DocumentFormat.OpenXml.ExtendedProperties.Properties();
        properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
        var template1 = new DocumentFormat.OpenXml.ExtendedProperties.Template
        {
            Text = ""
        };
        var totalTime1 = new DocumentFormat.OpenXml.ExtendedProperties.TotalTime
        {
            Text = "0"
        };
        var application1 = new DocumentFormat.OpenXml.ExtendedProperties.Application
        {
            Text = "TechnicalSchoolAutomationSystem"
        };
        var documentSecurity1 = new DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity
        {
            Text = "0"
        };
        var scaleCrop1 = new DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop
        {
            Text = "false"
        };

        var headingPairs1 = new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs();

        var vTVector1 = new DocumentFormat.OpenXml.VariantTypes.VTVector { BaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues.Variant, Size = (UInt32Value)2U };

        var variant1 = new DocumentFormat.OpenXml.VariantTypes.Variant();
        var vTLPSTR1 = new DocumentFormat.OpenXml.VariantTypes.VTLPSTR
        {
            Text = "Листы"
        };

        variant1.Append(vTLPSTR1);

        var variant2 = new DocumentFormat.OpenXml.VariantTypes.Variant();
        var vTInt321 = new DocumentFormat.OpenXml.VariantTypes.VTInt32
        {
            Text = "1"
        };

        variant2.Append(vTInt321);

        vTVector1.Append(variant1);
        vTVector1.Append(variant2);

        headingPairs1.Append(vTVector1);

        var titlesOfParts1 = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();

        var vTVector2 = new DocumentFormat.OpenXml.VariantTypes.VTVector { BaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
        var vTLPSTR2 = new DocumentFormat.OpenXml.VariantTypes.VTLPSTR
        {
            Text = "Данные"
        };

        vTVector2.Append(vTLPSTR2);

        titlesOfParts1.Append(vTVector2);
        var linksUpToDate1 = new DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate
        {
            Text = "false"
        };
        var sharedDocument1 = new DocumentFormat.OpenXml.ExtendedProperties.SharedDocument
        {
            Text = "false"
        };
        var hyperlinksChanged1 = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged
        {
            Text = "false"
        };
        var applicationVersion1 = new DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion
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
        document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2022-05-16T07:45:15Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
        document.PackageProperties.LastModifiedBy = "Admin";
    }

    #region Binary Data
    private string extendedPart1Data = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAwNi0wOS0yOFQxMDozMzo0OVo8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj48L2RjOmNyZWF0b3I+PGRjOmRlc2NyaXB0aW9uPjwvZGM6ZGVzY3JpcHRpb24+PGRjOmxhbmd1YWdlPmVuLVVTPC9kYzpsYW5ndWFnZT48Y3A6bGFzdE1vZGlmaWVkQnk+PC9jcDpsYXN0TW9kaWZpZWRCeT48ZGN0ZXJtczptb2RpZmllZCB4c2k6dHlwZT0iZGN0ZXJtczpXM0NEVEYiPjIwMTMtMDgtMjNUMDA6Mjg6MTJaPC9kY3Rlcm1zOm1vZGlmaWVkPjxjcDpyZXZpc2lvbj4wPC9jcDpyZXZpc2lvbj48ZGM6c3ViamVjdD48L2RjOnN1YmplY3Q+PGRjOnRpdGxlPjwvZGM6dGl0bGU+PC9jcDpjb3JlUHJvcGVydGllcz4=";

    private System.IO.Stream GetBinaryDataStream(string base64String)
    {
        return new System.IO.MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion

}