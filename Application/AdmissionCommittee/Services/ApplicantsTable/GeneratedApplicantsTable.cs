using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using A = DocumentFormat.OpenXml.Drawing;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;

namespace Application.AdmissionCommittee.Services.ApplicantsTable;

public class GeneratedApplicantsTable
{
    private readonly ApplicantsTableModel _model;

    // Creates a SpreadsheetDocument.
    public GeneratedApplicantsTable(ApplicantsTableModel model)
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

    // Adds child parts and generates content of the specified part.
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
        var data = GetBinaryDataStream(_extendedPart1Data);
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

        var cellFormats1 = new CellFormats { Count = (UInt32Value)11U };
        var cellFormat2 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };

        var cellFormat3 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment1 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true };

        cellFormat3.Append(alignment1);

        var cellFormat4 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment2 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

        cellFormat4.Append(alignment2);

        var cellFormat5 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyBorder = true, ApplyAlignment = true };
        var alignment3 = new Alignment { Horizontal = HorizontalAlignmentValues.Left };

        cellFormat5.Append(alignment3);

        var cellFormat6 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment4 = new Alignment { Horizontal = HorizontalAlignmentValues.Center };

        cellFormat6.Append(alignment4);

        var cellFormat7 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment5 = new Alignment { Vertical = VerticalAlignmentValues.Center, WrapText = true };

        cellFormat7.Append(alignment5);

        var cellFormat8 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment6 = new Alignment { Vertical = VerticalAlignmentValues.Center };

        cellFormat8.Append(alignment6);

        var cellFormat9 = new CellFormat { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyAlignment = true };
        var alignment7 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top };

        cellFormat9.Append(alignment7);

        var cellFormat10 = new CellFormat { NumberFormatId = (UInt32Value)49U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyBorder = true, ApplyAlignment = true };
        var alignment8 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top, WrapText = true };

        cellFormat10.Append(alignment8);

        var cellFormat11 = new CellFormat { NumberFormatId = (UInt32Value)49U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyAlignment = true };
        var alignment9 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top };

        cellFormat11.Append(alignment9);

        var cellFormat12 = new CellFormat { NumberFormatId = (UInt32Value)2U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyAlignment = true };
        var alignment10 = new Alignment { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top };

        cellFormat12.Append(alignment10);

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
        cellFormats1.Append(cellFormat12);

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

        var outline1 = new A.Outline { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

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

        var outline2 = new A.Outline { Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

        var solidFill3 = new A.SolidFill();
        var schemeColor9 = new A.SchemeColor { Val = A.SchemeColorValues.PhColor };

        solidFill3.Append(schemeColor9);
        var presetDash2 = new A.PresetDash { Val = A.PresetLineDashValues.Solid };

        outline2.Append(solidFill3);
        outline2.Append(presetDash2);

        var outline3 = new A.Outline { Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

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

        var outerShadow1 = new A.OuterShadow { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex11 = new A.RgbColorModelHex { Val = "000000" };
        var alpha1 = new A.Alpha { Val = 38000 };

        rgbColorModelHex11.Append(alpha1);

        outerShadow1.Append(rgbColorModelHex11);

        effectList1.Append(outerShadow1);

        effectStyle1.Append(effectList1);

        var effectStyle2 = new A.EffectStyle();

        var effectList2 = new A.EffectList();

        var outerShadow2 = new A.OuterShadow { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex12 = new A.RgbColorModelHex { Val = "000000" };
        var alpha2 = new A.Alpha { Val = 35000 };

        rgbColorModelHex12.Append(alpha2);

        outerShadow2.Append(rgbColorModelHex12);

        effectList2.Append(outerShadow2);

        effectStyle2.Append(effectList2);

        var effectStyle3 = new A.EffectStyle();

        var effectList3 = new A.EffectList();

        var outerShadow3 = new A.OuterShadow { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

        var rgbColorModelHex13 = new A.RgbColorModelHex { Val = "000000" };
        var alpha3 = new A.Alpha { Val = 35000 };

        rgbColorModelHex13.Append(alpha3);

        outerShadow3.Append(rgbColorModelHex13);

        effectList3.Append(outerShadow3);

        var scene3DType1 = new A.Scene3DType();

        var camera1 = new A.Camera { Preset = A.PresetCameraValues.OrthographicFront };
        var rotation1 = new A.Rotation { Latitude = 0, Longitude = 0, Revolution = 0 };

        camera1.Append(rotation1);

        var lightRig1 = new A.LightRig { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
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
        var sheetDimension1 = new SheetDimension { Reference = "B2:J121" };

        var sheetViews1 = new SheetViews();

        var sheetView1 = new SheetView { TabSelected = true, ZoomScaleNormal = (UInt32Value)100U, WorkbookViewId = (UInt32Value)0U };
        var selection1 = new Selection { ActiveCell = "C12", SequenceOfReferences = new ListValue<StringValue> { InnerText = "C12" } };

        sheetView1.Append(selection1);

        sheetViews1.Append(sheetView1);
        var sheetFormatProperties1 = new SheetFormatProperties { DefaultColumnWidth = 9D, DefaultRowHeight = 14.4D };

        var columns1 = new Columns();
        var column1 = new Column { Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 3.44140625D, CustomWidth = true };
        var column2 = new Column { Min = (UInt32Value)3U, Max = (UInt32Value)3U, Width = 26.77734375D, CustomWidth = true };
        var column3 = new Column { Min = (UInt32Value)4U, Max = (UInt32Value)4U, Width = 26.33203125D, CustomWidth = true };
        var column4 = new Column { Min = (UInt32Value)5U, Max = (UInt32Value)5U, Width = 10.88671875D, CustomWidth = true };
        var column5 = new Column { Min = (UInt32Value)6U, Max = (UInt32Value)6U, Width = 14.5546875D, CustomWidth = true };
        var column6 = new Column { Min = (UInt32Value)7U, Max = (UInt32Value)7U, Width = 10.44140625D, CustomWidth = true };
        var column7 = new Column { Min = (UInt32Value)9U, Max = (UInt32Value)9U, Width = 12D, CustomWidth = true };
        var column8 = new Column { Min = (UInt32Value)10U, Max = (UInt32Value)10U, Width = 12.5546875D, CustomWidth = true };

        columns1.Append(column1);
        columns1.Append(column2);
        columns1.Append(column3);
        columns1.Append(column4);
        columns1.Append(column5);
        columns1.Append(column6);
        columns1.Append(column7);
        columns1.Append(column8);

        var sheetData = new SheetData();

        var row1 = new Row { RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue> { InnerText = "2:10" } };

        var cell1 = new Cell { CellReference = "C2", StyleIndex = (UInt32Value)4U, DataType = CellValues.SharedString };
        var cellValue1 = new CellValue
        {
            Text = "0"
        };

        cell1.Append(cellValue1);
        var cell2 = new Cell { CellReference = "D2", StyleIndex = (UInt32Value)4U };
        var cell3 = new Cell { CellReference = "E2", StyleIndex = (UInt32Value)4U };
        var cell4 = new Cell { CellReference = "F2", StyleIndex = (UInt32Value)4U };

        row1.Append(cell1);
        row1.Append(cell2);
        row1.Append(cell3);
        row1.Append(cell4);

        var row2 = new Row { RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue> { InnerText = "2:10" } };

        var cell5 = new Cell { CellReference = "B3", StyleIndex = (UInt32Value)4U, DataType = CellValues.SharedString };
        var cellValue2 = new CellValue
        {
            Text = "1"
        };

        cell5.Append(cellValue2);
        var cell6 = new Cell { CellReference = "C3", StyleIndex = (UInt32Value)4U };

        var cell7 = new Cell { CellReference = "D3", StyleIndex = (UInt32Value)3U, DataType = CellValues.String };
        var cellValue3 = new CellValue
        {
            Text = _model.SpecialityName
        };

        cell7.Append(cellValue3);
        var cell8 = new Cell { CellReference = "E3", StyleIndex = (UInt32Value)3U };
        var cell9 = new Cell { CellReference = "F3", StyleIndex = (UInt32Value)3U };
        var cell10 = new Cell { CellReference = "G3", StyleIndex = (UInt32Value)3U };
        var cell11 = new Cell { CellReference = "H3", StyleIndex = (UInt32Value)3U };
        var cell12 = new Cell { CellReference = "I3", StyleIndex = (UInt32Value)3U };
        var cell13 = new Cell { CellReference = "J3", StyleIndex = (UInt32Value)3U };

        row2.Append(cell5);
        row2.Append(cell6);
        row2.Append(cell7);
        row2.Append(cell8);
        row2.Append(cell9);
        row2.Append(cell10);
        row2.Append(cell11);
        row2.Append(cell12);
        row2.Append(cell13);

        var row3 = new Row { RowIndex = (UInt32Value)5U, Spans = new ListValue<StringValue> { InnerText = "2:10" }, Height = 14.4D, CustomHeight = true };

        var cell14 = new Cell { CellReference = "B5", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue4 = new CellValue
        {
            Text = "2"
        };

        cell14.Append(cellValue4);

        var cell15 = new Cell { CellReference = "C5", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue5 = new CellValue
        {
            Text = "3"
        };

        cell15.Append(cellValue5);

        var cell16 = new Cell { CellReference = "D5", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue6 = new CellValue
        {
            Text = "4"
        };

        cell16.Append(cellValue6);

        var cell17 = new Cell { CellReference = "E5", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue7 = new CellValue
        {
            Text = "5"
        };

        cell17.Append(cellValue7);
        var cell18 = new Cell { CellReference = "F5", StyleIndex = (UInt32Value)2U };

        var cell19 = new Cell { CellReference = "G5", StyleIndex = (UInt32Value)1U, DataType = CellValues.SharedString };
        var cellValue8 = new CellValue
        {
            Text = "6"
        };

        cell19.Append(cellValue8);

        var cell20 = new Cell { CellReference = "H5", StyleIndex = (UInt32Value)1U, DataType = CellValues.SharedString };
        var cellValue9 = new CellValue
        {
            Text = "7"
        };

        cell20.Append(cellValue9);

        var cell21 = new Cell { CellReference = "I5", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue10 = new CellValue
        {
            Text = "8"
        };

        cell21.Append(cellValue10);

        var cell22 = new Cell { CellReference = "J5", StyleIndex = (UInt32Value)1U, DataType = CellValues.SharedString };
        var cellValue11 = new CellValue
        {
            Text = "9"
        };

        cell22.Append(cellValue11);

        row3.Append(cell14);
        row3.Append(cell15);
        row3.Append(cell16);
        row3.Append(cell17);
        row3.Append(cell18);
        row3.Append(cell19);
        row3.Append(cell20);
        row3.Append(cell21);
        row3.Append(cell22);

        var row4 = new Row { RowIndex = (UInt32Value)6U, Spans = new ListValue<StringValue> { InnerText = "2:10" }, Height = 28.8D };
        var cell23 = new Cell { CellReference = "B6", StyleIndex = (UInt32Value)2U };
        var cell24 = new Cell { CellReference = "C6", StyleIndex = (UInt32Value)2U };
        var cell25 = new Cell { CellReference = "D6", StyleIndex = (UInt32Value)2U };

        var cell26 = new Cell { CellReference = "E6", StyleIndex = (UInt32Value)5U, DataType = CellValues.SharedString };
        var cellValue12 = new CellValue
        {
            Text = "10"
        };

        cell26.Append(cellValue12);

        var cell27 = new Cell { CellReference = "F6", StyleIndex = (UInt32Value)6U, DataType = CellValues.SharedString };
        var cellValue13 = new CellValue
        {
            Text = "11"
        };

        cell27.Append(cellValue13);
        var cell28 = new Cell { CellReference = "G6", StyleIndex = (UInt32Value)1U };
        var cell29 = new Cell { CellReference = "H6", StyleIndex = (UInt32Value)1U };
        var cell30 = new Cell { CellReference = "I6", StyleIndex = (UInt32Value)2U };
        var cell31 = new Cell { CellReference = "J6", StyleIndex = (UInt32Value)1U };

        row4.Append(cell23);
        row4.Append(cell24);
        row4.Append(cell25);
        row4.Append(cell26);
        row4.Append(cell27);
        row4.Append(cell28);
        row4.Append(cell29);
        row4.Append(cell30);
        row4.Append(cell31);

        sheetData.Append(row1);
        sheetData.Append(row2);
        sheetData.Append(row3);
        sheetData.Append(row4);
        
        MakeApplicantsTable(sheetData);

        var mergeCells1 = new MergeCells { Count = (UInt32Value)11U };
        var mergeCell1 = new MergeCell { Reference = "C2:F2" };
        var mergeCell2 = new MergeCell { Reference = "B3:C3" };
        var mergeCell3 = new MergeCell { Reference = "D3:J3" };
        var mergeCell4 = new MergeCell { Reference = "B5:B6" };
        var mergeCell5 = new MergeCell { Reference = "C5:C6" };
        var mergeCell6 = new MergeCell { Reference = "D5:D6" };
        var mergeCell7 = new MergeCell { Reference = "E5:F5" };
        var mergeCell8 = new MergeCell { Reference = "G5:G6" };
        var mergeCell9 = new MergeCell { Reference = "H5:H6" };
        var mergeCell10 = new MergeCell { Reference = "I5:I6" };
        var mergeCell11 = new MergeCell { Reference = "J5:J6" };

        mergeCells1.Append(mergeCell1);
        mergeCells1.Append(mergeCell2);
        mergeCells1.Append(mergeCell3);
        mergeCells1.Append(mergeCell4);
        mergeCells1.Append(mergeCell5);
        mergeCells1.Append(mergeCell6);
        mergeCells1.Append(mergeCell7);
        mergeCells1.Append(mergeCell8);
        mergeCells1.Append(mergeCell9);
        mergeCells1.Append(mergeCell10);
        mergeCells1.Append(mergeCell11);
        var pageMargins1 = new PageMargins { Left = 0.31527777777777799D, Right = 0.31527777777777799D, Top = 0.39374999999999999D, Bottom = 0.35416666666666702D, Header = 0.511811023622047D, Footer = 0.511811023622047D };
        var pageSetup1 = new PageSetup { PaperSize = (UInt32Value)9U, Orientation = OrientationValues.Landscape, HorizontalDpi = (UInt32Value)300U, VerticalDpi = (UInt32Value)300U };

        worksheet1.Append(sheetDimension1);
        worksheet1.Append(sheetViews1);
        worksheet1.Append(sheetFormatProperties1);
        worksheet1.Append(columns1);
        worksheet1.Append(sheetData);
        worksheet1.Append(mergeCells1);
        worksheet1.Append(pageMargins1);
        worksheet1.Append(pageSetup1);

        worksheetPart1.Worksheet = worksheet1;
    }

    private void MakeApplicantsTable(OpenXmlElement sheetData)
    {
        var rowIndex = 7U;
        foreach (var item in _model.Items)
        {
            var row = new Row
            {
                RowIndex = (UInt32Value)rowIndex, Spans = new ListValue<StringValue> { InnerText = "2:10" },
                StyleIndex = (UInt32Value)7U, CustomFormat = true
            };

            var cell1 = new Cell { CellReference = $"B{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue1 = new CellValue
            {
                Text = item.Number.ToString("000")
            };

            cell1.Append(cellValue1);

            var cell2 = new Cell { CellReference = $"C{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue2 = new CellValue
            {
                Text = item.FullName
            };

            cell2.Append(cellValue2);

            var cell3 = new Cell { CellReference = $"D{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue3 = new CellValue
            {
                Text = item.Education
            };

            cell3.Append(cellValue3);

            var cell4 = new Cell { CellReference = $"E{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue4 = new CellValue
            {
                Text = item.LanguageRating.ToString()
            };

            cell4.Append(cellValue4);

            var cell5 = new Cell { CellReference = $"F{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue5 = new CellValue
            {
                Text = item.MathRating.ToString()
            };

            cell5.Append(cellValue5);

            var cell6 = new Cell { CellReference = $"G{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue6 = new CellValue
            {
                Text = item.AverageAttestRating.ToString()
            };

            cell6.Append(cellValue6);

            var cell7 = new Cell { CellReference = $"H{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue7 = new CellValue
            {
                Text = item.CommonScore.ToString()
            };

            cell7.Append(cellValue7);

            var cell8 = new Cell { CellReference = $"I{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue8 = new CellValue
            {
                Text = item.Description
            };

            cell8.Append(cellValue8);

            var cell9 = new Cell { CellReference = $"J{rowIndex}", StyleIndex = (UInt32Value)8U, DataType = CellValues.String };
            var cellValue9 = new CellValue
            {
                Text = item.DirectorDecision
            };

            cell9.Append(cellValue9);

            row.Append(cell1);
            row.Append(cell2);
            row.Append(cell3);
            row.Append(cell4);
            row.Append(cell5);
            row.Append(cell6);
            row.Append(cell7);
            row.Append(cell8);
            row.Append(cell9);
            sheetData.Append(row);
            rowIndex += 1;
        }
    }

    // Generates content of sharedStringTablePart1.
    private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
    {
        var sharedStringTable1 = new SharedStringTable { Count = (UInt32Value)40U, UniqueCount = (UInt32Value)40U };

        var sharedStringItem1 = new SharedStringItem();
        var text1 = new Text
        {
            Text = "СВОДНАЯ ВЕДОМОСТЬ"
        };

        sharedStringItem1.Append(text1);

        var sharedStringItem2 = new SharedStringItem();
        var text2 = new Text
        {
            Text = "Специальность"
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

        var sharedStringItem5 = new SharedStringItem();
        var text5 = new Text
        {
            Text = "Образование"
        };

        sharedStringItem5.Append(text5);

        var sharedStringItem6 = new SharedStringItem();
        var text6 = new Text
        {
            Text = "Результаты ГИА"
        };

        sharedStringItem6.Append(text6);

        var sharedStringItem7 = new SharedStringItem();
        var text7 = new Text
        {
            Text = "Средний балл по аттестату"
        };

        sharedStringItem7.Append(text7);

        var sharedStringItem8 = new SharedStringItem();
        var text8 = new Text
        {
            Text = "Общая оценка"
        };

        sharedStringItem8.Append(text8);

        var sharedStringItem9 = new SharedStringItem();
        var text9 = new Text
        {
            Text = "Примечание"
        };

        sharedStringItem9.Append(text9);

        var sharedStringItem10 = new SharedStringItem();
        var text10 = new Text
        {
            Text = "Решение директора"
        };

        sharedStringItem10.Append(text10);

        var sharedStringItem11 = new SharedStringItem();
        var text11 = new Text
        {
            Text = "Русский язык"
        };

        sharedStringItem11.Append(text11);

        var sharedStringItem12 = new SharedStringItem();
        var text12 = new Text
        {
            Text = "Математика"
        };

        sharedStringItem12.Append(text12);

        sharedStringTable1.Append(sharedStringItem1);
        sharedStringTable1.Append(sharedStringItem2);
        sharedStringTable1.Append(sharedStringItem3);
        sharedStringTable1.Append(sharedStringItem4);
        sharedStringTable1.Append(sharedStringItem5);
        sharedStringTable1.Append(sharedStringItem6);
        sharedStringTable1.Append(sharedStringItem7);
        sharedStringTable1.Append(sharedStringItem8);
        sharedStringTable1.Append(sharedStringItem9);
        sharedStringTable1.Append(sharedStringItem10);
        sharedStringTable1.Append(sharedStringItem11);
        sharedStringTable1.Append(sharedStringItem12);

        sharedStringTablePart1.SharedStringTable = sharedStringTable1;
    }

    // Generates content of extendedFilePropertiesPart1.
    private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
    {
        var properties1 = new Ap.Properties();
        properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
        var template1 = new Ap.Template
        {
            Text = ""
        };
        var totalTime1 = new Ap.TotalTime
        {
            Text = "0"
        };
        var application1 = new Ap.Application
        {
            Text = "Microsoft Excel"
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
        var vTlpstr1 = new Vt.VTLPSTR
        {
            Text = "Листы"
        };

        variant1.Append(vTlpstr1);

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
        var vTlpstr2 = new Vt.VTLPSTR
        {
            Text = "Лист1"
        };

        vTVector2.Append(vTlpstr2);

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
            Text = "12.0000"
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
        document.PackageProperties.Modified = XmlConvert.ToDateTime("2022-05-15T07:30:51Z", XmlDateTimeSerializationMode.RoundtripKind);
        document.PackageProperties.LastModifiedBy = "Admin";
    }

    #region Binary Data
    private string _extendedPart1Data = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAwNi0wOS0yOFQxMDozMzo0OVo8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj48L2RjOmNyZWF0b3I+PGRjOmRlc2NyaXB0aW9uPjwvZGM6ZGVzY3JpcHRpb24+PGRjOmxhbmd1YWdlPmVuLVVTPC9kYzpsYW5ndWFnZT48Y3A6bGFzdE1vZGlmaWVkQnk+PC9jcDpsYXN0TW9kaWZpZWRCeT48ZGN0ZXJtczptb2RpZmllZCB4c2k6dHlwZT0iZGN0ZXJtczpXM0NEVEYiPjIwMTMtMDctMDZUMjE6NTY6MzBaPC9kY3Rlcm1zOm1vZGlmaWVkPjxjcDpyZXZpc2lvbj4wPC9jcDpyZXZpc2lvbj48ZGM6c3ViamVjdD48L2RjOnN1YmplY3Q+PGRjOnRpdGxlPjwvZGM6dGl0bGU+PC9jcDpjb3JlUHJvcGVydGllcz4=";

    private Stream GetBinaryDataStream(string base64String)
    {
        return new MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion

}