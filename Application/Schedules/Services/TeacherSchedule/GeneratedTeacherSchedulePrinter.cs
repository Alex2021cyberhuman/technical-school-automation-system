using Application.Common.Helpers;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;

namespace Application.Schedules.Services.TeacherSchedule;

public class GeneratedTeacherSchedulePrinter
{
    private readonly TeacherScheduleModel _model;

    public GeneratedTeacherSchedulePrinter(TeacherScheduleModel model)
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
        var workbookPart1 = document.AddWorkbookPart();
        GenerateWorkbookPart1Content(workbookPart1);

        var workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId1");
        GenerateWorkbookStylesPart1Content(workbookStylesPart1);

        var worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId2");
        GenerateWorksheetPart1Content(worksheetPart1);

        var sharedStringTablePart1 = workbookPart1.AddNewPart<SharedStringTablePart>("rId3");
        GenerateSharedStringTablePart1Content(sharedStringTablePart1);

        var extendedPart1 =
            document.AddExtendedPart(
                "http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties",
                "application/vnd.openxmlformats-package.core-properties+xml", "xml", "rId2");
        GenerateExtendedPart1Content(extendedPart1);

        var extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
        GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

        SetPackageProperties(document);
    }

    // Generates content of workbookPart1.
    private void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
    {
        var workbook1 = new Workbook();
        workbook1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        var fileVersion1 = new FileVersion { ApplicationName = "Calc" };
        var workbookProperties1 = new WorkbookProperties
            { DateCompatibility = false, ShowObjects = ObjectDisplayValues.All, BackupFile = false };
        var workbookProtection1 = new WorkbookProtection();

        var bookViews1 = new BookViews();
        var workbookView1 = new WorkbookView
        {
            ShowHorizontalScroll = true, ShowVerticalScroll = true, ShowSheetTabs = true, XWindow = 0, YWindow = 0,
            WindowWidth = (UInt32Value)16384U, WindowHeight = (UInt32Value)8192U, TabRatio = (UInt32Value)500U,
            FirstSheet = (UInt32Value)0U, ActiveTab = (UInt32Value)0U
        };

        bookViews1.Append(workbookView1);

        var sheets1 = new Sheets();
        var sheet1 = new Sheet
            { Name = "Даные", SheetId = (UInt32Value)1U, State = SheetStateValues.Visible, Id = "rId2" };

        sheets1.Append(sheet1);
        var calculationProperties1 = new CalculationProperties
        {
            ReferenceMode = ReferenceModeValues.A1, Iterate = false, IterateCount = (UInt32Value)100U,
            IterateDelta = 0.0001D
        };

        var workbookExtensionList1 = new WorkbookExtensionList();

        var workbookExtension1 = new WorkbookExtension { Uri = "{7626C862-2A13-11E5-B345-FEFF819CDC9F}" };
        workbookExtension1.AddNamespaceDeclaration("loext", "http://schemas.libreoffice.org/");

        var openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(
            "<loext:extCalcPr stringRefSyntax=\"CalcA1ExcelA1\" xmlns:loext=\"http://schemas.libreoffice.org/\" />");

        workbookExtension1.Append(openXmlUnknownElement1);

        workbookExtensionList1.Append(workbookExtension1);

        workbook1.Append(fileVersion1);
        workbook1.Append(workbookProperties1);
        workbook1.Append(workbookProtection1);
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

        var numberingFormats1 = new NumberingFormats { Count = (UInt32Value)1U };
        var numberingFormat1 = new NumberingFormat { NumberFormatId = (UInt32Value)164U, FormatCode = "General" };

        numberingFormats1.Append(numberingFormat1);

        var fonts1 = new Fonts { Count = (UInt32Value)16U };

        var font1 = new Font();
        var fontSize1 = new FontSize { Val = 10D };
        var color1 = new Color { Rgb = "FF000000" };
        var fontName1 = new FontName { Val = "Arial" };
        var fontFamilyNumbering1 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet1 = new FontCharSet { Val = 1 };

        font1.Append(fontSize1);
        font1.Append(color1);
        font1.Append(fontName1);
        font1.Append(fontFamilyNumbering1);
        font1.Append(fontCharSet1);

        var font2 = new Font();
        var fontSize2 = new FontSize { Val = 10D };
        var fontName2 = new FontName { Val = "Arial" };
        var fontFamilyNumbering2 = new FontFamilyNumbering { Val = 0 };

        font2.Append(fontSize2);
        font2.Append(fontName2);
        font2.Append(fontFamilyNumbering2);

        var font3 = new Font();
        var fontSize3 = new FontSize { Val = 10D };
        var fontName3 = new FontName { Val = "Arial" };
        var fontFamilyNumbering3 = new FontFamilyNumbering { Val = 0 };

        font3.Append(fontSize3);
        font3.Append(fontName3);
        font3.Append(fontFamilyNumbering3);

        var font4 = new Font();
        var fontSize4 = new FontSize { Val = 10D };
        var fontName4 = new FontName { Val = "Arial" };
        var fontFamilyNumbering4 = new FontFamilyNumbering { Val = 0 };

        font4.Append(fontSize4);
        font4.Append(fontName4);
        font4.Append(fontFamilyNumbering4);

        var font5 = new Font();
        var bold1 = new Bold { Val = true };
        var fontSize5 = new FontSize { Val = 10D };
        var color2 = new Color { Rgb = "FFFFFFFF" };
        var fontName5 = new FontName { Val = "Arial" };
        var fontFamilyNumbering5 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet2 = new FontCharSet { Val = 1 };

        font5.Append(bold1);
        font5.Append(fontSize5);
        font5.Append(color2);
        font5.Append(fontName5);
        font5.Append(fontFamilyNumbering5);
        font5.Append(fontCharSet2);

        var font6 = new Font();
        var bold2 = new Bold { Val = true };
        var fontSize6 = new FontSize { Val = 10D };
        var color3 = new Color { Rgb = "FF000000" };
        var fontName6 = new FontName { Val = "Arial" };
        var fontFamilyNumbering6 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet3 = new FontCharSet { Val = 1 };

        font6.Append(bold2);
        font6.Append(fontSize6);
        font6.Append(color3);
        font6.Append(fontName6);
        font6.Append(fontFamilyNumbering6);
        font6.Append(fontCharSet3);

        var font7 = new Font();
        var fontSize7 = new FontSize { Val = 10D };
        var color4 = new Color { Rgb = "FFCC0000" };
        var fontName7 = new FontName { Val = "Arial" };
        var fontFamilyNumbering7 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet4 = new FontCharSet { Val = 1 };

        font7.Append(fontSize7);
        font7.Append(color4);
        font7.Append(fontName7);
        font7.Append(fontFamilyNumbering7);
        font7.Append(fontCharSet4);

        var font8 = new Font();
        var italic1 = new Italic { Val = true };
        var fontSize8 = new FontSize { Val = 10D };
        var color5 = new Color { Rgb = "FF808080" };
        var fontName8 = new FontName { Val = "Arial" };
        var fontFamilyNumbering8 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet5 = new FontCharSet { Val = 1 };

        font8.Append(italic1);
        font8.Append(fontSize8);
        font8.Append(color5);
        font8.Append(fontName8);
        font8.Append(fontFamilyNumbering8);
        font8.Append(fontCharSet5);

        var font9 = new Font();
        var fontSize9 = new FontSize { Val = 10D };
        var color6 = new Color { Rgb = "FF006600" };
        var fontName9 = new FontName { Val = "Arial" };
        var fontFamilyNumbering9 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet6 = new FontCharSet { Val = 1 };

        font9.Append(fontSize9);
        font9.Append(color6);
        font9.Append(fontName9);
        font9.Append(fontFamilyNumbering9);
        font9.Append(fontCharSet6);

        var font10 = new Font();
        var bold3 = new Bold { Val = true };
        var fontSize10 = new FontSize { Val = 18D };
        var color7 = new Color { Rgb = "FF000000" };
        var fontName10 = new FontName { Val = "Arial" };
        var fontFamilyNumbering10 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet7 = new FontCharSet { Val = 1 };

        font10.Append(bold3);
        font10.Append(fontSize10);
        font10.Append(color7);
        font10.Append(fontName10);
        font10.Append(fontFamilyNumbering10);
        font10.Append(fontCharSet7);

        var font11 = new Font();
        var bold4 = new Bold { Val = true };
        var fontSize11 = new FontSize { Val = 24D };
        var color8 = new Color { Rgb = "FF000000" };
        var fontName11 = new FontName { Val = "Arial" };
        var fontFamilyNumbering11 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet8 = new FontCharSet { Val = 1 };

        font11.Append(bold4);
        font11.Append(fontSize11);
        font11.Append(color8);
        font11.Append(fontName11);
        font11.Append(fontFamilyNumbering11);
        font11.Append(fontCharSet8);

        var font12 = new Font();
        var bold5 = new Bold { Val = true };
        var fontSize12 = new FontSize { Val = 12D };
        var color9 = new Color { Rgb = "FF000000" };
        var fontName12 = new FontName { Val = "Arial" };
        var fontFamilyNumbering12 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet9 = new FontCharSet { Val = 1 };

        font12.Append(bold5);
        font12.Append(fontSize12);
        font12.Append(color9);
        font12.Append(fontName12);
        font12.Append(fontFamilyNumbering12);
        font12.Append(fontCharSet9);

        var font13 = new Font();
        var underline1 = new Underline { Val = UnderlineValues.Single };
        var fontSize13 = new FontSize { Val = 10D };
        var color10 = new Color { Rgb = "FF0000EE" };
        var fontName13 = new FontName { Val = "Arial" };
        var fontFamilyNumbering13 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet10 = new FontCharSet { Val = 1 };

        font13.Append(underline1);
        font13.Append(fontSize13);
        font13.Append(color10);
        font13.Append(fontName13);
        font13.Append(fontFamilyNumbering13);
        font13.Append(fontCharSet10);

        var font14 = new Font();
        var fontSize14 = new FontSize { Val = 10D };
        var color11 = new Color { Rgb = "FF996600" };
        var fontName14 = new FontName { Val = "Arial" };
        var fontFamilyNumbering14 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet11 = new FontCharSet { Val = 1 };

        font14.Append(fontSize14);
        font14.Append(color11);
        font14.Append(fontName14);
        font14.Append(fontFamilyNumbering14);
        font14.Append(fontCharSet11);

        var font15 = new Font();
        var fontSize15 = new FontSize { Val = 10D };
        var color12 = new Color { Rgb = "FF333333" };
        var fontName15 = new FontName { Val = "Arial" };
        var fontFamilyNumbering15 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet12 = new FontCharSet { Val = 1 };

        font15.Append(fontSize15);
        font15.Append(color12);
        font15.Append(fontName15);
        font15.Append(fontFamilyNumbering15);
        font15.Append(fontCharSet12);

        var font16 = new Font();
        var bold6 = new Bold { Val = true };
        var italic2 = new Italic { Val = true };
        var underline2 = new Underline { Val = UnderlineValues.Single };
        var fontSize16 = new FontSize { Val = 10D };
        var color13 = new Color { Rgb = "FF000000" };
        var fontName16 = new FontName { Val = "Arial" };
        var fontFamilyNumbering16 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet13 = new FontCharSet { Val = 1 };

        font16.Append(bold6);
        font16.Append(italic2);
        font16.Append(underline2);
        font16.Append(fontSize16);
        font16.Append(color13);
        font16.Append(fontName16);
        font16.Append(fontFamilyNumbering16);
        font16.Append(fontCharSet13);

        fonts1.Append(font1);
        fonts1.Append(font2);
        fonts1.Append(font3);
        fonts1.Append(font4);
        fonts1.Append(font5);
        fonts1.Append(font6);
        fonts1.Append(font7);
        fonts1.Append(font8);
        fonts1.Append(font9);
        fonts1.Append(font10);
        fonts1.Append(font11);
        fonts1.Append(font12);
        fonts1.Append(font13);
        fonts1.Append(font14);
        fonts1.Append(font15);
        fonts1.Append(font16);

        var fills1 = new Fills { Count = (UInt32Value)9U };

        var fill1 = new Fill();
        var patternFill1 = new PatternFill { PatternType = PatternValues.None };

        fill1.Append(patternFill1);

        var fill2 = new Fill();
        var patternFill2 = new PatternFill { PatternType = PatternValues.Gray125 };

        fill2.Append(patternFill2);

        var fill3 = new Fill();

        var patternFill3 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor1 = new ForegroundColor { Rgb = "FF000000" };
        var backgroundColor1 = new BackgroundColor { Rgb = "FF003300" };

        patternFill3.Append(foregroundColor1);
        patternFill3.Append(backgroundColor1);

        fill3.Append(patternFill3);

        var fill4 = new Fill();

        var patternFill4 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor2 = new ForegroundColor { Rgb = "FF808080" };
        var backgroundColor2 = new BackgroundColor { Rgb = "FF969696" };

        patternFill4.Append(foregroundColor2);
        patternFill4.Append(backgroundColor2);

        fill4.Append(patternFill4);

        var fill5 = new Fill();

        var patternFill5 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor3 = new ForegroundColor { Rgb = "FFDDDDDD" };
        var backgroundColor3 = new BackgroundColor { Rgb = "FFFFCCCC" };

        patternFill5.Append(foregroundColor3);
        patternFill5.Append(backgroundColor3);

        fill5.Append(patternFill5);

        var fill6 = new Fill();

        var patternFill6 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor4 = new ForegroundColor { Rgb = "FFFFCCCC" };
        var backgroundColor4 = new BackgroundColor { Rgb = "FFDDDDDD" };

        patternFill6.Append(foregroundColor4);
        patternFill6.Append(backgroundColor4);

        fill6.Append(patternFill6);

        var fill7 = new Fill();

        var patternFill7 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor5 = new ForegroundColor { Rgb = "FFCC0000" };
        var backgroundColor5 = new BackgroundColor { Rgb = "FF800000" };

        patternFill7.Append(foregroundColor5);
        patternFill7.Append(backgroundColor5);

        fill7.Append(patternFill7);

        var fill8 = new Fill();

        var patternFill8 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor6 = new ForegroundColor { Rgb = "FFCCFFCC" };
        var backgroundColor6 = new BackgroundColor { Rgb = "FFCCFFFF" };

        patternFill8.Append(foregroundColor6);
        patternFill8.Append(backgroundColor6);

        fill8.Append(patternFill8);

        var fill9 = new Fill();

        var patternFill9 = new PatternFill { PatternType = PatternValues.Solid };
        var foregroundColor7 = new ForegroundColor { Rgb = "FFFFFFCC" };
        var backgroundColor7 = new BackgroundColor { Rgb = "FFFFFFFF" };

        patternFill9.Append(foregroundColor7);
        patternFill9.Append(backgroundColor7);

        fill9.Append(patternFill9);

        fills1.Append(fill1);
        fills1.Append(fill2);
        fills1.Append(fill3);
        fills1.Append(fill4);
        fills1.Append(fill5);
        fills1.Append(fill6);
        fills1.Append(fill7);
        fills1.Append(fill8);
        fills1.Append(fill9);

        var borders1 = new Borders { Count = (UInt32Value)21U };

        var border1 = new Border { DiagonalUp = false, DiagonalDown = false };
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

        var border2 = new Border { DiagonalUp = false, DiagonalDown = false };

        var leftBorder2 = new LeftBorder { Style = BorderStyleValues.Thin };
        var color14 = new Color { Rgb = "FF808080" };

        leftBorder2.Append(color14);

        var rightBorder2 = new RightBorder { Style = BorderStyleValues.Thin };
        var color15 = new Color { Rgb = "FF808080" };

        rightBorder2.Append(color15);

        var topBorder2 = new TopBorder { Style = BorderStyleValues.Thin };
        var color16 = new Color { Rgb = "FF808080" };

        topBorder2.Append(color16);

        var bottomBorder2 = new BottomBorder { Style = BorderStyleValues.Thin };
        var color17 = new Color { Rgb = "FF808080" };

        bottomBorder2.Append(color17);
        var diagonalBorder2 = new DiagonalBorder();

        border2.Append(leftBorder2);
        border2.Append(rightBorder2);
        border2.Append(topBorder2);
        border2.Append(bottomBorder2);
        border2.Append(diagonalBorder2);

        var border3 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder3 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder3 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder3 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder3 = new BottomBorder();
        var diagonalBorder3 = new DiagonalBorder();

        border3.Append(leftBorder3);
        border3.Append(rightBorder3);
        border3.Append(topBorder3);
        border3.Append(bottomBorder3);
        border3.Append(diagonalBorder3);

        var border4 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder4 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder4 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder4 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder4 = new BottomBorder { Style = BorderStyleValues.Double };
        var diagonalBorder4 = new DiagonalBorder();

        border4.Append(leftBorder4);
        border4.Append(rightBorder4);
        border4.Append(topBorder4);
        border4.Append(bottomBorder4);
        border4.Append(diagonalBorder4);

        var border5 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder5 = new LeftBorder();
        var rightBorder5 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder5 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder5 = new BottomBorder();
        var diagonalBorder5 = new DiagonalBorder();

        border5.Append(leftBorder5);
        border5.Append(rightBorder5);
        border5.Append(topBorder5);
        border5.Append(bottomBorder5);
        border5.Append(diagonalBorder5);

        var border6 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder6 = new LeftBorder();
        var rightBorder6 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder6 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder6 = new BottomBorder { Style = BorderStyleValues.Double };
        var diagonalBorder6 = new DiagonalBorder();

        border6.Append(leftBorder6);
        border6.Append(rightBorder6);
        border6.Append(topBorder6);
        border6.Append(bottomBorder6);
        border6.Append(diagonalBorder6);

        var border7 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder7 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder7 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder7 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder7 = new BottomBorder { Style = BorderStyleValues.Double };
        var diagonalBorder7 = new DiagonalBorder();

        border7.Append(leftBorder7);
        border7.Append(rightBorder7);
        border7.Append(topBorder7);
        border7.Append(bottomBorder7);
        border7.Append(diagonalBorder7);

        var border8 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder8 = new LeftBorder();
        var rightBorder8 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder8 = new TopBorder { Style = BorderStyleValues.Double };
        var bottomBorder8 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder8 = new DiagonalBorder();

        border8.Append(leftBorder8);
        border8.Append(rightBorder8);
        border8.Append(topBorder8);
        border8.Append(bottomBorder8);
        border8.Append(diagonalBorder8);

        var border9 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder9 = new LeftBorder();
        var rightBorder9 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder9 = new TopBorder();
        var bottomBorder9 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder9 = new DiagonalBorder();

        border9.Append(leftBorder9);
        border9.Append(rightBorder9);
        border9.Append(topBorder9);
        border9.Append(bottomBorder9);
        border9.Append(diagonalBorder9);

        var border10 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder10 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder10 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder10 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder10 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder10 = new DiagonalBorder();

        border10.Append(leftBorder10);
        border10.Append(rightBorder10);
        border10.Append(topBorder10);
        border10.Append(bottomBorder10);
        border10.Append(diagonalBorder10);

        var border11 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder11 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder11 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder11 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder11 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder11 = new DiagonalBorder();

        border11.Append(leftBorder11);
        border11.Append(rightBorder11);
        border11.Append(topBorder11);
        border11.Append(bottomBorder11);
        border11.Append(diagonalBorder11);

        var border12 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder12 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder12 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder12 = new TopBorder();
        var bottomBorder12 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder12 = new DiagonalBorder();

        border12.Append(leftBorder12);
        border12.Append(rightBorder12);
        border12.Append(topBorder12);
        border12.Append(bottomBorder12);
        border12.Append(diagonalBorder12);

        var border13 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder13 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder13 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder13 = new TopBorder { Style = BorderStyleValues.Double };
        var bottomBorder13 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder13 = new DiagonalBorder();

        border13.Append(leftBorder13);
        border13.Append(rightBorder13);
        border13.Append(topBorder13);
        border13.Append(bottomBorder13);
        border13.Append(diagonalBorder13);

        var border14 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder14 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder14 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder14 = new TopBorder { Style = BorderStyleValues.Double };
        var bottomBorder14 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder14 = new DiagonalBorder();

        border14.Append(leftBorder14);
        border14.Append(rightBorder14);
        border14.Append(topBorder14);
        border14.Append(bottomBorder14);
        border14.Append(diagonalBorder14);

        var border15 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder15 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder15 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder15 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder15 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder15 = new DiagonalBorder();

        border15.Append(leftBorder15);
        border15.Append(rightBorder15);
        border15.Append(topBorder15);
        border15.Append(bottomBorder15);
        border15.Append(diagonalBorder15);

        var border16 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder16 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder16 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder16 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder16 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder16 = new DiagonalBorder();

        border16.Append(leftBorder16);
        border16.Append(rightBorder16);
        border16.Append(topBorder16);
        border16.Append(bottomBorder16);
        border16.Append(diagonalBorder16);

        var border17 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder17 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder17 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder17 = new TopBorder();
        var bottomBorder17 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder17 = new DiagonalBorder();

        border17.Append(leftBorder17);
        border17.Append(rightBorder17);
        border17.Append(topBorder17);
        border17.Append(bottomBorder17);
        border17.Append(diagonalBorder17);

        var border18 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder18 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder18 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder18 = new TopBorder { Style = BorderStyleValues.Thick };
        var bottomBorder18 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder18 = new DiagonalBorder();

        border18.Append(leftBorder18);
        border18.Append(rightBorder18);
        border18.Append(topBorder18);
        border18.Append(bottomBorder18);
        border18.Append(diagonalBorder18);

        var border19 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder19 = new LeftBorder { Style = BorderStyleValues.Double };
        var rightBorder19 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder19 = new TopBorder();
        var bottomBorder19 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder19 = new DiagonalBorder();

        border19.Append(leftBorder19);
        border19.Append(rightBorder19);
        border19.Append(topBorder19);
        border19.Append(bottomBorder19);
        border19.Append(diagonalBorder19);

        var border20 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder20 = new LeftBorder();
        var rightBorder20 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder20 = new TopBorder();
        var bottomBorder20 = new BottomBorder { Style = BorderStyleValues.Thick };
        var diagonalBorder20 = new DiagonalBorder();

        border20.Append(leftBorder20);
        border20.Append(rightBorder20);
        border20.Append(topBorder20);
        border20.Append(bottomBorder20);
        border20.Append(diagonalBorder20);

        var border21 = new Border { DiagonalUp = false, DiagonalDown = false };
        var leftBorder21 = new LeftBorder { Style = BorderStyleValues.Thin };
        var rightBorder21 = new RightBorder { Style = BorderStyleValues.Double };
        var topBorder21 = new TopBorder();
        var bottomBorder21 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder21 = new DiagonalBorder();

        border21.Append(leftBorder21);
        border21.Append(rightBorder21);
        border21.Append(topBorder21);
        border21.Append(bottomBorder21);
        border21.Append(diagonalBorder21);

        borders1.Append(border1);
        borders1.Append(border2);
        borders1.Append(border3);
        borders1.Append(border4);
        borders1.Append(border5);
        borders1.Append(border6);
        borders1.Append(border7);
        borders1.Append(border8);
        borders1.Append(border9);
        borders1.Append(border10);
        borders1.Append(border11);
        borders1.Append(border12);
        borders1.Append(border13);
        borders1.Append(border14);
        borders1.Append(border15);
        borders1.Append(border16);
        borders1.Append(border17);
        borders1.Append(border18);
        borders1.Append(border19);
        borders1.Append(border20);
        borders1.Append(border21);

        var cellStyleFormats1 = new CellStyleFormats { Count = (UInt32Value)38U };

        var cellFormat1 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment1 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection1 = new Protection { Locked = true, Hidden = false };

        cellFormat1.Append(alignment1);
        cellFormat1.Append(protection1);
        var cellFormat2 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat3 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat4 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat5 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat6 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat7 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat8 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat9 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat10 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat11 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat12 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat13 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat14 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat15 = new CellFormat
        {
            NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat16 = new CellFormat
        {
            NumberFormatId = (UInt32Value)43U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat17 = new CellFormat
        {
            NumberFormatId = (UInt32Value)41U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat18 = new CellFormat
        {
            NumberFormatId = (UInt32Value)44U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat19 = new CellFormat
        {
            NumberFormatId = (UInt32Value)42U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };
        var cellFormat20 = new CellFormat
        {
            NumberFormatId = (UInt32Value)9U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = false, ApplyAlignment = false,
            ApplyProtection = false
        };

        var cellFormat21 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)4U, FillId = (UInt32Value)2U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment2 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection2 = new Protection { Locked = true, Hidden = false };

        cellFormat21.Append(alignment2);
        cellFormat21.Append(protection2);

        var cellFormat22 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)4U, FillId = (UInt32Value)3U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment3 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection3 = new Protection { Locked = true, Hidden = false };

        cellFormat22.Append(alignment3);
        cellFormat22.Append(protection3);

        var cellFormat23 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)5U, FillId = (UInt32Value)4U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment4 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection4 = new Protection { Locked = true, Hidden = false };

        cellFormat23.Append(alignment4);
        cellFormat23.Append(protection4);

        var cellFormat24 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)5U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment5 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection5 = new Protection { Locked = true, Hidden = false };

        cellFormat24.Append(alignment5);
        cellFormat24.Append(protection5);

        var cellFormat25 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)6U, FillId = (UInt32Value)5U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment6 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection6 = new Protection { Locked = true, Hidden = false };

        cellFormat25.Append(alignment6);
        cellFormat25.Append(protection6);

        var cellFormat26 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)4U, FillId = (UInt32Value)6U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment7 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection7 = new Protection { Locked = true, Hidden = false };

        cellFormat26.Append(alignment7);
        cellFormat26.Append(protection7);

        var cellFormat27 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)7U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment8 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection8 = new Protection { Locked = true, Hidden = false };

        cellFormat27.Append(alignment8);
        cellFormat27.Append(protection8);

        var cellFormat28 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)8U, FillId = (UInt32Value)7U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment9 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection9 = new Protection { Locked = true, Hidden = false };

        cellFormat28.Append(alignment9);
        cellFormat28.Append(protection9);

        var cellFormat29 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)9U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment10 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection10 = new Protection { Locked = true, Hidden = false };

        cellFormat29.Append(alignment10);
        cellFormat29.Append(protection10);

        var cellFormat30 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)10U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment11 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection11 = new Protection { Locked = true, Hidden = false };

        cellFormat30.Append(alignment11);
        cellFormat30.Append(protection11);

        var cellFormat31 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)11U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment12 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection12 = new Protection { Locked = true, Hidden = false };

        cellFormat31.Append(alignment12);
        cellFormat31.Append(protection12);

        var cellFormat32 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)12U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment13 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection13 = new Protection { Locked = true, Hidden = false };

        cellFormat32.Append(alignment13);
        cellFormat32.Append(protection13);

        var cellFormat33 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)13U, FillId = (UInt32Value)8U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment14 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection14 = new Protection { Locked = true, Hidden = false };

        cellFormat33.Append(alignment14);
        cellFormat33.Append(protection14);

        var cellFormat34 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)14U, FillId = (UInt32Value)8U,
            BorderId = (UInt32Value)1U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment15 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection15 = new Protection { Locked = true, Hidden = false };

        cellFormat34.Append(alignment15);
        cellFormat34.Append(protection15);

        var cellFormat35 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)15U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment16 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection16 = new Protection { Locked = true, Hidden = false };

        cellFormat35.Append(alignment16);
        cellFormat35.Append(protection16);

        var cellFormat36 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment17 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection17 = new Protection { Locked = true, Hidden = false };

        cellFormat36.Append(alignment17);
        cellFormat36.Append(protection17);

        var cellFormat37 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment18 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection18 = new Protection { Locked = true, Hidden = false };

        cellFormat37.Append(alignment18);
        cellFormat37.Append(protection18);

        var cellFormat38 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)6U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment19 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection19 = new Protection { Locked = true, Hidden = false };

        cellFormat38.Append(alignment19);
        cellFormat38.Append(protection19);

        cellStyleFormats1.Append(cellFormat1);
        cellStyleFormats1.Append(cellFormat2);
        cellStyleFormats1.Append(cellFormat3);
        cellStyleFormats1.Append(cellFormat4);
        cellStyleFormats1.Append(cellFormat5);
        cellStyleFormats1.Append(cellFormat6);
        cellStyleFormats1.Append(cellFormat7);
        cellStyleFormats1.Append(cellFormat8);
        cellStyleFormats1.Append(cellFormat9);
        cellStyleFormats1.Append(cellFormat10);
        cellStyleFormats1.Append(cellFormat11);
        cellStyleFormats1.Append(cellFormat12);
        cellStyleFormats1.Append(cellFormat13);
        cellStyleFormats1.Append(cellFormat14);
        cellStyleFormats1.Append(cellFormat15);
        cellStyleFormats1.Append(cellFormat16);
        cellStyleFormats1.Append(cellFormat17);
        cellStyleFormats1.Append(cellFormat18);
        cellStyleFormats1.Append(cellFormat19);
        cellStyleFormats1.Append(cellFormat20);
        cellStyleFormats1.Append(cellFormat21);
        cellStyleFormats1.Append(cellFormat22);
        cellStyleFormats1.Append(cellFormat23);
        cellStyleFormats1.Append(cellFormat24);
        cellStyleFormats1.Append(cellFormat25);
        cellStyleFormats1.Append(cellFormat26);
        cellStyleFormats1.Append(cellFormat27);
        cellStyleFormats1.Append(cellFormat28);
        cellStyleFormats1.Append(cellFormat29);
        cellStyleFormats1.Append(cellFormat30);
        cellStyleFormats1.Append(cellFormat31);
        cellStyleFormats1.Append(cellFormat32);
        cellStyleFormats1.Append(cellFormat33);
        cellStyleFormats1.Append(cellFormat34);
        cellStyleFormats1.Append(cellFormat35);
        cellStyleFormats1.Append(cellFormat36);
        cellStyleFormats1.Append(cellFormat37);
        cellStyleFormats1.Append(cellFormat38);

        var cellFormats1 = new CellFormats { Count = (UInt32Value)21U };

        var cellFormat39 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = false,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment20 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection20 = new Protection { Locked = true, Hidden = false };

        cellFormat39.Append(alignment20);
        cellFormat39.Append(protection20);

        var cellFormat40 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)2U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment21 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.General, Vertical = VerticalAlignmentValues.Bottom,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection21 = new Protection { Locked = true, Hidden = false };

        cellFormat40.Append(alignment21);
        cellFormat40.Append(protection21);

        var cellFormat41 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)3U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment22 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection22 = new Protection { Locked = true, Hidden = false };

        cellFormat41.Append(alignment22);
        cellFormat41.Append(protection22);

        var cellFormat42 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)4U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment23 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection23 = new Protection { Locked = true, Hidden = false };

        cellFormat42.Append(alignment23);
        cellFormat42.Append(protection23);

        var cellFormat43 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)5U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment24 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection24 = new Protection { Locked = true, Hidden = false };

        cellFormat43.Append(alignment24);
        cellFormat43.Append(protection24);

        var cellFormat44 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)6U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment25 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection25 = new Protection { Locked = true, Hidden = false };

        cellFormat44.Append(alignment25);
        cellFormat44.Append(protection25);

        var cellFormat45 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)3U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment26 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection26 = new Protection { Locked = true, Hidden = false };

        cellFormat45.Append(alignment26);
        cellFormat45.Append(protection26);

        var cellFormat46 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)7U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment27 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection27 = new Protection { Locked = true, Hidden = false };

        cellFormat46.Append(alignment27);
        cellFormat46.Append(protection27);

        var cellFormat47 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)8U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment28 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Left, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection28 = new Protection { Locked = true, Hidden = false };

        cellFormat47.Append(alignment28);
        cellFormat47.Append(protection28);

        var cellFormat48 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)9U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment29 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection29 = new Protection { Locked = true, Hidden = false };

        cellFormat48.Append(alignment29);
        cellFormat48.Append(protection29);

        var cellFormat49 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)10U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment30 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection30 = new Protection { Locked = true, Hidden = false };

        cellFormat49.Append(alignment30);
        cellFormat49.Append(protection30);

        var cellFormat50 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)11U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment31 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection31 = new Protection { Locked = true, Hidden = false };

        cellFormat50.Append(alignment31);
        cellFormat50.Append(protection31);

        var cellFormat51 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)12U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment32 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection32 = new Protection { Locked = true, Hidden = false };

        cellFormat51.Append(alignment32);
        cellFormat51.Append(protection32);

        var cellFormat52 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)13U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment33 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection33 = new Protection { Locked = true, Hidden = false };

        cellFormat52.Append(alignment33);
        cellFormat52.Append(protection33);

        var cellFormat53 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)14U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment34 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection34 = new Protection { Locked = true, Hidden = false };

        cellFormat53.Append(alignment34);
        cellFormat53.Append(protection34);

        var cellFormat54 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)15U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment35 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection35 = new Protection { Locked = true, Hidden = false };

        cellFormat54.Append(alignment35);
        cellFormat54.Append(protection35);

        var cellFormat55 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)16U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment36 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection36 = new Protection { Locked = true, Hidden = false };

        cellFormat55.Append(alignment36);
        cellFormat55.Append(protection36);

        var cellFormat56 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)17U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment37 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Left, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection37 = new Protection { Locked = true, Hidden = false };

        cellFormat56.Append(alignment37);
        cellFormat56.Append(protection37);

        var cellFormat57 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)18U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment38 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection38 = new Protection { Locked = true, Hidden = false };

        cellFormat57.Append(alignment38);
        cellFormat57.Append(protection38);

        var cellFormat58 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)19U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment39 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection39 = new Protection { Locked = true, Hidden = false };

        cellFormat58.Append(alignment39);
        cellFormat58.Append(protection39);

        var cellFormat59 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)20U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = true,
            ApplyAlignment = true, ApplyProtection = false
        };
        var alignment40 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = false, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection40 = new Protection { Locked = true, Hidden = false };

        cellFormat59.Append(alignment40);
        cellFormat59.Append(protection40);

        cellFormats1.Append(cellFormat39);
        cellFormats1.Append(cellFormat40);
        cellFormats1.Append(cellFormat41);
        cellFormats1.Append(cellFormat42);
        cellFormats1.Append(cellFormat43);
        cellFormats1.Append(cellFormat44);
        cellFormats1.Append(cellFormat45);
        cellFormats1.Append(cellFormat46);
        cellFormats1.Append(cellFormat47);
        cellFormats1.Append(cellFormat48);
        cellFormats1.Append(cellFormat49);
        cellFormats1.Append(cellFormat50);
        cellFormats1.Append(cellFormat51);
        cellFormats1.Append(cellFormat52);
        cellFormats1.Append(cellFormat53);
        cellFormats1.Append(cellFormat54);
        cellFormats1.Append(cellFormat55);
        cellFormats1.Append(cellFormat56);
        cellFormats1.Append(cellFormat57);
        cellFormats1.Append(cellFormat58);
        cellFormats1.Append(cellFormat59);

        var cellStyles1 = new CellStyles { Count = (UInt32Value)24U };
        var cellStyle1 = new CellStyle { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };
        var cellStyle2 = new CellStyle { Name = "Comma", FormatId = (UInt32Value)15U, BuiltinId = (UInt32Value)3U };
        var cellStyle3 = new CellStyle { Name = "Comma [0]", FormatId = (UInt32Value)16U, BuiltinId = (UInt32Value)6U };
        var cellStyle4 = new CellStyle { Name = "Currency", FormatId = (UInt32Value)17U, BuiltinId = (UInt32Value)4U };
        var cellStyle5 = new CellStyle
            { Name = "Currency [0]", FormatId = (UInt32Value)18U, BuiltinId = (UInt32Value)7U };
        var cellStyle6 = new CellStyle { Name = "Percent", FormatId = (UInt32Value)19U, BuiltinId = (UInt32Value)5U };
        var cellStyle7 = new CellStyle { Name = "Accent 1 5", FormatId = (UInt32Value)20U };
        var cellStyle8 = new CellStyle { Name = "Accent 2 6", FormatId = (UInt32Value)21U };
        var cellStyle9 = new CellStyle { Name = "Accent 3 7", FormatId = (UInt32Value)22U };
        var cellStyle10 = new CellStyle { Name = "Accent 4", FormatId = (UInt32Value)23U };
        var cellStyle11 = new CellStyle { Name = "Bad 8", FormatId = (UInt32Value)24U };
        var cellStyle12 = new CellStyle { Name = "Error 9", FormatId = (UInt32Value)25U };
        var cellStyle13 = new CellStyle { Name = "Footnote 10", FormatId = (UInt32Value)26U };
        var cellStyle14 = new CellStyle { Name = "Good 11", FormatId = (UInt32Value)27U };
        var cellStyle15 = new CellStyle { Name = "Heading 1 13", FormatId = (UInt32Value)28U };
        var cellStyle16 = new CellStyle { Name = "Heading 12", FormatId = (UInt32Value)29U };
        var cellStyle17 = new CellStyle { Name = "Heading 2 14", FormatId = (UInt32Value)30U };
        var cellStyle18 = new CellStyle { Name = "Hyperlink 15", FormatId = (UInt32Value)31U };
        var cellStyle19 = new CellStyle { Name = "Neutral 16", FormatId = (UInt32Value)32U };
        var cellStyle20 = new CellStyle { Name = "Note 17", FormatId = (UInt32Value)33U };
        var cellStyle21 = new CellStyle { Name = "Result 18", FormatId = (UInt32Value)34U };
        var cellStyle22 = new CellStyle { Name = "Status 19", FormatId = (UInt32Value)35U };
        var cellStyle23 = new CellStyle { Name = "Text 20", FormatId = (UInt32Value)36U };
        var cellStyle24 = new CellStyle { Name = "Warning 21", FormatId = (UInt32Value)37U };

        cellStyles1.Append(cellStyle1);
        cellStyles1.Append(cellStyle2);
        cellStyles1.Append(cellStyle3);
        cellStyles1.Append(cellStyle4);
        cellStyles1.Append(cellStyle5);
        cellStyles1.Append(cellStyle6);
        cellStyles1.Append(cellStyle7);
        cellStyles1.Append(cellStyle8);
        cellStyles1.Append(cellStyle9);
        cellStyles1.Append(cellStyle10);
        cellStyles1.Append(cellStyle11);
        cellStyles1.Append(cellStyle12);
        cellStyles1.Append(cellStyle13);
        cellStyles1.Append(cellStyle14);
        cellStyles1.Append(cellStyle15);
        cellStyles1.Append(cellStyle16);
        cellStyles1.Append(cellStyle17);
        cellStyles1.Append(cellStyle18);
        cellStyles1.Append(cellStyle19);
        cellStyles1.Append(cellStyle20);
        cellStyles1.Append(cellStyle21);
        cellStyles1.Append(cellStyle22);
        cellStyles1.Append(cellStyle23);
        cellStyles1.Append(cellStyle24);

        var colors1 = new Colors();

        var indexedColors1 = new IndexedColors();
        var rgbColor1 = new RgbColor { Rgb = "FF000000" };
        var rgbColor2 = new RgbColor { Rgb = "FFFFFFFF" };
        var rgbColor3 = new RgbColor { Rgb = "FFCC0000" };
        var rgbColor4 = new RgbColor { Rgb = "FF00FF00" };
        var rgbColor5 = new RgbColor { Rgb = "FF0000EE" };
        var rgbColor6 = new RgbColor { Rgb = "FFFFFF00" };
        var rgbColor7 = new RgbColor { Rgb = "FFFF00FF" };
        var rgbColor8 = new RgbColor { Rgb = "FF00FFFF" };
        var rgbColor9 = new RgbColor { Rgb = "FF800000" };
        var rgbColor10 = new RgbColor { Rgb = "FF006600" };
        var rgbColor11 = new RgbColor { Rgb = "FF000080" };
        var rgbColor12 = new RgbColor { Rgb = "FF996600" };
        var rgbColor13 = new RgbColor { Rgb = "FF800080" };
        var rgbColor14 = new RgbColor { Rgb = "FF008080" };
        var rgbColor15 = new RgbColor { Rgb = "FFC0C0C0" };
        var rgbColor16 = new RgbColor { Rgb = "FF808080" };
        var rgbColor17 = new RgbColor { Rgb = "FF9999FF" };
        var rgbColor18 = new RgbColor { Rgb = "FF993366" };
        var rgbColor19 = new RgbColor { Rgb = "FFFFFFCC" };
        var rgbColor20 = new RgbColor { Rgb = "FFCCFFFF" };
        var rgbColor21 = new RgbColor { Rgb = "FF660066" };
        var rgbColor22 = new RgbColor { Rgb = "FFFF8080" };
        var rgbColor23 = new RgbColor { Rgb = "FF0066CC" };
        var rgbColor24 = new RgbColor { Rgb = "FFDDDDDD" };
        var rgbColor25 = new RgbColor { Rgb = "FF000080" };
        var rgbColor26 = new RgbColor { Rgb = "FFFF00FF" };
        var rgbColor27 = new RgbColor { Rgb = "FFFFFF00" };
        var rgbColor28 = new RgbColor { Rgb = "FF00FFFF" };
        var rgbColor29 = new RgbColor { Rgb = "FF800080" };
        var rgbColor30 = new RgbColor { Rgb = "FF800000" };
        var rgbColor31 = new RgbColor { Rgb = "FF008080" };
        var rgbColor32 = new RgbColor { Rgb = "FF0000FF" };
        var rgbColor33 = new RgbColor { Rgb = "FF00CCFF" };
        var rgbColor34 = new RgbColor { Rgb = "FFCCFFFF" };
        var rgbColor35 = new RgbColor { Rgb = "FFCCFFCC" };
        var rgbColor36 = new RgbColor { Rgb = "FFFFFF99" };
        var rgbColor37 = new RgbColor { Rgb = "FF99CCFF" };
        var rgbColor38 = new RgbColor { Rgb = "FFFF99CC" };
        var rgbColor39 = new RgbColor { Rgb = "FFCC99FF" };
        var rgbColor40 = new RgbColor { Rgb = "FFFFCCCC" };
        var rgbColor41 = new RgbColor { Rgb = "FF3366FF" };
        var rgbColor42 = new RgbColor { Rgb = "FF33CCCC" };
        var rgbColor43 = new RgbColor { Rgb = "FF99CC00" };
        var rgbColor44 = new RgbColor { Rgb = "FFFFCC00" };
        var rgbColor45 = new RgbColor { Rgb = "FFFF9900" };
        var rgbColor46 = new RgbColor { Rgb = "FFFF6600" };
        var rgbColor47 = new RgbColor { Rgb = "FF666699" };
        var rgbColor48 = new RgbColor { Rgb = "FF969696" };
        var rgbColor49 = new RgbColor { Rgb = "FF003366" };
        var rgbColor50 = new RgbColor { Rgb = "FF339966" };
        var rgbColor51 = new RgbColor { Rgb = "FF003300" };
        var rgbColor52 = new RgbColor { Rgb = "FF333300" };
        var rgbColor53 = new RgbColor { Rgb = "FF993300" };
        var rgbColor54 = new RgbColor { Rgb = "FF993366" };
        var rgbColor55 = new RgbColor { Rgb = "FF333399" };
        var rgbColor56 = new RgbColor { Rgb = "FF333333" };

        indexedColors1.Append(rgbColor1);
        indexedColors1.Append(rgbColor2);
        indexedColors1.Append(rgbColor3);
        indexedColors1.Append(rgbColor4);
        indexedColors1.Append(rgbColor5);
        indexedColors1.Append(rgbColor6);
        indexedColors1.Append(rgbColor7);
        indexedColors1.Append(rgbColor8);
        indexedColors1.Append(rgbColor9);
        indexedColors1.Append(rgbColor10);
        indexedColors1.Append(rgbColor11);
        indexedColors1.Append(rgbColor12);
        indexedColors1.Append(rgbColor13);
        indexedColors1.Append(rgbColor14);
        indexedColors1.Append(rgbColor15);
        indexedColors1.Append(rgbColor16);
        indexedColors1.Append(rgbColor17);
        indexedColors1.Append(rgbColor18);
        indexedColors1.Append(rgbColor19);
        indexedColors1.Append(rgbColor20);
        indexedColors1.Append(rgbColor21);
        indexedColors1.Append(rgbColor22);
        indexedColors1.Append(rgbColor23);
        indexedColors1.Append(rgbColor24);
        indexedColors1.Append(rgbColor25);
        indexedColors1.Append(rgbColor26);
        indexedColors1.Append(rgbColor27);
        indexedColors1.Append(rgbColor28);
        indexedColors1.Append(rgbColor29);
        indexedColors1.Append(rgbColor30);
        indexedColors1.Append(rgbColor31);
        indexedColors1.Append(rgbColor32);
        indexedColors1.Append(rgbColor33);
        indexedColors1.Append(rgbColor34);
        indexedColors1.Append(rgbColor35);
        indexedColors1.Append(rgbColor36);
        indexedColors1.Append(rgbColor37);
        indexedColors1.Append(rgbColor38);
        indexedColors1.Append(rgbColor39);
        indexedColors1.Append(rgbColor40);
        indexedColors1.Append(rgbColor41);
        indexedColors1.Append(rgbColor42);
        indexedColors1.Append(rgbColor43);
        indexedColors1.Append(rgbColor44);
        indexedColors1.Append(rgbColor45);
        indexedColors1.Append(rgbColor46);
        indexedColors1.Append(rgbColor47);
        indexedColors1.Append(rgbColor48);
        indexedColors1.Append(rgbColor49);
        indexedColors1.Append(rgbColor50);
        indexedColors1.Append(rgbColor51);
        indexedColors1.Append(rgbColor52);
        indexedColors1.Append(rgbColor53);
        indexedColors1.Append(rgbColor54);
        indexedColors1.Append(rgbColor55);
        indexedColors1.Append(rgbColor56);

        colors1.Append(indexedColors1);

        stylesheet1.Append(numberingFormats1);
        stylesheet1.Append(fonts1);
        stylesheet1.Append(fills1);
        stylesheet1.Append(borders1);
        stylesheet1.Append(cellStyleFormats1);
        stylesheet1.Append(cellFormats1);
        stylesheet1.Append(cellStyles1);
        stylesheet1.Append(colors1);

        workbookStylesPart1.Stylesheet = stylesheet1;
    }

    // Generates content of worksheetPart1.
    private void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
    {
        var worksheet1 = new Worksheet();
        worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        worksheet1.AddNamespaceDeclaration("xdr",
            "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
        worksheet1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
        worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

        var sheetProperties1 = new SheetProperties { FilterMode = false };
        var pageSetupProperties1 = new PageSetupProperties { FitToPage = false };

        sheetProperties1.Append(pageSetupProperties1);
        var sheetDimension1 = new SheetDimension { Reference = "A1:BT7" };

        var sheetViews1 = new SheetViews();

        var sheetView1 = new SheetView
        {
            ShowFormulas = false, ShowGridLines = true, ShowRowColHeaders = true, ShowZeros = true, RightToLeft = false,
            TabSelected = true, ShowOutlineSymbols = true, DefaultGridColor = true, View = SheetViewValues.Normal,
            TopLeftCell = "A1", ColorId = (UInt32Value)64U, ZoomScale = (UInt32Value)100U,
            ZoomScaleNormal = (UInt32Value)100U, ZoomScalePageLayoutView = (UInt32Value)100U,
            WorkbookViewId = (UInt32Value)0U
        };
        var selection1 = new Selection
        {
            Pane = PaneValues.TopLeft, ActiveCell = "U6", ActiveCellId = (UInt32Value)0U,
            SequenceOfReferences = new ListValue<StringValue> { InnerText = "U6" }
        };

        sheetView1.Append(selection1);

        sheetViews1.Append(sheetView1);
        var sheetFormatProperties1 = new SheetFormatProperties
        {
            DefaultColumnWidth = 8.6875D, DefaultRowHeight = 12.75D, ZeroHeight = false, OutlineLevelRow = 0,
            OutlineLevelColumn = 0
        };

        var columns1 = new Columns();

        const int perLessonCellWidth = 2;
        const int lessonsOnDayCount = 7;
        const int perDayOfWeekSectionWidth = perLessonCellWidth * lessonsOnDayCount;
        const int studyDaysAtWeek = 5;
        const int perWeekSectionWidth = studyDaysAtWeek * perDayOfWeekSectionWidth;
        const int startScheduleTable = 3;
        const int cellsWidth = 2 + perWeekSectionWidth;
        columns1.Append(new Column
            {
                Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 4D, Style = (UInt32Value)0U, Hidden = false,
                CustomWidth = true, OutlineLevel = 0, Collapsed = false
            },
            new Column
            {
                Min = (UInt32Value)2U, Max = (UInt32Value)2U, Width = 20D, Style = (UInt32Value)0U, Hidden = false,
                CustomWidth = true, OutlineLevel = 0, Collapsed = false
            });
        for (var index = startScheduleTable; index < cellsWidth; index += 2)
            columns1.Append(new Column
            {
                Min = (UInt32Value)(uint)index, Max = (UInt32Value)(uint)index, Width = 20D, Style = (UInt32Value)0U,
                Hidden = false,
                CustomWidth = true, OutlineLevel = 0, Collapsed = false
            }, new Column
            {
                Min = (UInt32Value)(uint)index + 1, Max = (UInt32Value)(uint)index + 1, Width = 5D,
                Style = (UInt32Value)0U,
                Hidden = false,
                CustomWidth = true, OutlineLevel = 0, Collapsed = false
            });

        var sheetData1 = new SheetData();

        var mergeCells = new MergeCells();

        var row1 = new Row
        {
            RowIndex = (UInt32Value)1U, CustomFormat = false, Height = 28.35D, Hidden = false, CustomHeight = true,
            OutlineLevel = 0, Collapsed = false
        };
        var cell1 = new Cell { CellReference = "A1", StyleIndex = (UInt32Value)1U };

        var cell2 = new Cell { CellReference = "B1", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
        var cellValue1 = new CellValue
        {
            Text = "0"
        };

        cell2.Append(cellValue1);

        var cell3 = new Cell { CellReference = "C1", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
        var cellValue2 = new CellValue
        {
            Text = "1"
        };

        cell3.Append(cellValue2);
        var cell4 = new Cell { CellReference = "D1", StyleIndex = (UInt32Value)3U };
        var cell5 = new Cell { CellReference = "E1", StyleIndex = (UInt32Value)3U };
        var cell6 = new Cell { CellReference = "F1", StyleIndex = (UInt32Value)3U };
        var cell7 = new Cell { CellReference = "G1", StyleIndex = (UInt32Value)3U };
        var cell8 = new Cell { CellReference = "H1", StyleIndex = (UInt32Value)3U };
        var cell9 = new Cell { CellReference = "I1", StyleIndex = (UInt32Value)3U };
        var cell10 = new Cell { CellReference = "J1", StyleIndex = (UInt32Value)3U };
        var cell11 = new Cell { CellReference = "K1", StyleIndex = (UInt32Value)3U };
        var cell12 = new Cell { CellReference = "L1", StyleIndex = (UInt32Value)3U };
        var cell13 = new Cell { CellReference = "M1", StyleIndex = (UInt32Value)3U };
        var cell14 = new Cell { CellReference = "N1", StyleIndex = (UInt32Value)3U };
        var cell15 = new Cell { CellReference = "O1", StyleIndex = (UInt32Value)3U };
        var cell16 = new Cell { CellReference = "P1", StyleIndex = (UInt32Value)3U };

        var cell17 = new Cell
            { CellReference = "Q1", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
        var cellValue3 = new CellValue
        {
            Text = "2"
        };

        cell17.Append(cellValue3);
        var cell18 = new Cell { CellReference = "R1", StyleIndex = (UInt32Value)3U };
        var cell19 = new Cell { CellReference = "S1", StyleIndex = (UInt32Value)3U };
        var cell20 = new Cell { CellReference = "T1", StyleIndex = (UInt32Value)3U };
        var cell21 = new Cell { CellReference = "U1", StyleIndex = (UInt32Value)3U };
        var cell22 = new Cell { CellReference = "V1", StyleIndex = (UInt32Value)3U };
        var cell23 = new Cell { CellReference = "W1", StyleIndex = (UInt32Value)3U };
        var cell24 = new Cell { CellReference = "X1", StyleIndex = (UInt32Value)3U };
        var cell25 = new Cell { CellReference = "Y1", StyleIndex = (UInt32Value)3U };
        var cell26 = new Cell { CellReference = "Z1", StyleIndex = (UInt32Value)3U };
        var cell27 = new Cell { CellReference = "AA1", StyleIndex = (UInt32Value)3U };
        var cell28 = new Cell { CellReference = "AB1", StyleIndex = (UInt32Value)3U };
        var cell29 = new Cell { CellReference = "AC1", StyleIndex = (UInt32Value)3U };
        var cell30 = new Cell { CellReference = "AD1", StyleIndex = (UInt32Value)3U };

        var cell31 = new Cell
            { CellReference = "AE1", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
        var cellValue4 = new CellValue
        {
            Text = "3"
        };

        cell31.Append(cellValue4);
        var cell32 = new Cell { CellReference = "AF1", StyleIndex = (UInt32Value)3U };
        var cell33 = new Cell { CellReference = "AG1", StyleIndex = (UInt32Value)3U };
        var cell34 = new Cell { CellReference = "AH1", StyleIndex = (UInt32Value)3U };
        var cell35 = new Cell { CellReference = "AI1", StyleIndex = (UInt32Value)3U };
        var cell36 = new Cell { CellReference = "AJ1", StyleIndex = (UInt32Value)3U };
        var cell37 = new Cell { CellReference = "AK1", StyleIndex = (UInt32Value)3U };
        var cell38 = new Cell { CellReference = "AL1", StyleIndex = (UInt32Value)3U };
        var cell39 = new Cell { CellReference = "AM1", StyleIndex = (UInt32Value)3U };
        var cell40 = new Cell { CellReference = "AN1", StyleIndex = (UInt32Value)3U };
        var cell41 = new Cell { CellReference = "AO1", StyleIndex = (UInt32Value)3U };
        var cell42 = new Cell { CellReference = "AP1", StyleIndex = (UInt32Value)3U };
        var cell43 = new Cell { CellReference = "AQ1", StyleIndex = (UInt32Value)3U };
        var cell44 = new Cell { CellReference = "AR1", StyleIndex = (UInt32Value)3U };

        var cell45 = new Cell
            { CellReference = "AS1", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
        var cellValue5 = new CellValue
        {
            Text = "4"
        };

        cell45.Append(cellValue5);
        var cell46 = new Cell { CellReference = "AT1", StyleIndex = (UInt32Value)3U };
        var cell47 = new Cell { CellReference = "AU1", StyleIndex = (UInt32Value)3U };
        var cell48 = new Cell { CellReference = "AV1", StyleIndex = (UInt32Value)3U };
        var cell49 = new Cell { CellReference = "AW1", StyleIndex = (UInt32Value)3U };
        var cell50 = new Cell { CellReference = "AX1", StyleIndex = (UInt32Value)3U };
        var cell51 = new Cell { CellReference = "AY1", StyleIndex = (UInt32Value)3U };
        var cell52 = new Cell { CellReference = "AZ1", StyleIndex = (UInt32Value)3U };
        var cell53 = new Cell { CellReference = "BA1", StyleIndex = (UInt32Value)3U };
        var cell54 = new Cell { CellReference = "BB1", StyleIndex = (UInt32Value)3U };
        var cell55 = new Cell { CellReference = "BC1", StyleIndex = (UInt32Value)3U };
        var cell56 = new Cell { CellReference = "BD1", StyleIndex = (UInt32Value)3U };
        var cell57 = new Cell { CellReference = "BE1", StyleIndex = (UInt32Value)3U };
        var cell58 = new Cell { CellReference = "BF1", StyleIndex = (UInt32Value)3U };

        var cell59 = new Cell
            { CellReference = "BG1", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
        var cellValue6 = new CellValue
        {
            Text = "5"
        };

        cell59.Append(cellValue6);
        var cell60 = new Cell { CellReference = "BH1", StyleIndex = (UInt32Value)3U };
        var cell61 = new Cell { CellReference = "BI1", StyleIndex = (UInt32Value)3U };
        var cell62 = new Cell { CellReference = "BJ1", StyleIndex = (UInt32Value)3U };
        var cell63 = new Cell { CellReference = "BK1", StyleIndex = (UInt32Value)3U };
        var cell64 = new Cell { CellReference = "BL1", StyleIndex = (UInt32Value)3U };
        var cell65 = new Cell { CellReference = "BM1", StyleIndex = (UInt32Value)3U };
        var cell66 = new Cell { CellReference = "BN1", StyleIndex = (UInt32Value)3U };
        var cell67 = new Cell { CellReference = "BO1", StyleIndex = (UInt32Value)3U };
        var cell68 = new Cell { CellReference = "BP1", StyleIndex = (UInt32Value)3U };
        var cell69 = new Cell { CellReference = "BQ1", StyleIndex = (UInt32Value)3U };
        var cell70 = new Cell { CellReference = "BR1", StyleIndex = (UInt32Value)3U };
        var cell71 = new Cell { CellReference = "BS1", StyleIndex = (UInt32Value)3U };
        var cell72 = new Cell { CellReference = "BT1", StyleIndex = (UInt32Value)3U };

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
        row1.Append(cell16);
        row1.Append(cell17);
        row1.Append(cell18);
        row1.Append(cell19);
        row1.Append(cell20);
        row1.Append(cell21);
        row1.Append(cell22);
        row1.Append(cell23);
        row1.Append(cell24);
        row1.Append(cell25);
        row1.Append(cell26);
        row1.Append(cell27);
        row1.Append(cell28);
        row1.Append(cell29);
        row1.Append(cell30);
        row1.Append(cell31);
        row1.Append(cell32);
        row1.Append(cell33);
        row1.Append(cell34);
        row1.Append(cell35);
        row1.Append(cell36);
        row1.Append(cell37);
        row1.Append(cell38);
        row1.Append(cell39);
        row1.Append(cell40);
        row1.Append(cell41);
        row1.Append(cell42);
        row1.Append(cell43);
        row1.Append(cell44);
        row1.Append(cell45);
        row1.Append(cell46);
        row1.Append(cell47);
        row1.Append(cell48);
        row1.Append(cell49);
        row1.Append(cell50);
        row1.Append(cell51);
        row1.Append(cell52);
        row1.Append(cell53);
        row1.Append(cell54);
        row1.Append(cell55);
        row1.Append(cell56);
        row1.Append(cell57);
        row1.Append(cell58);
        row1.Append(cell59);
        row1.Append(cell60);
        row1.Append(cell61);
        row1.Append(cell62);
        row1.Append(cell63);
        row1.Append(cell64);
        row1.Append(cell65);
        row1.Append(cell66);
        row1.Append(cell67);
        row1.Append(cell68);
        row1.Append(cell69);
        row1.Append(cell70);
        row1.Append(cell71);
        row1.Append(cell72);

        var row2 = new Row
        {
            RowIndex = (UInt32Value)2U, CustomFormat = false, Height = 20.85D, Hidden = false, CustomHeight = true,
            OutlineLevel = 0, Collapsed = false
        };
        var cell73 = new Cell { CellReference = "A2", StyleIndex = (UInt32Value)1U };
        var cell74 = new Cell { CellReference = "B2", StyleIndex = (UInt32Value)2U };

        var cell75 = new Cell { CellReference = "C2", StyleIndex = (UInt32Value)4U, DataType = CellValues.Number };
        var cellValue7 = new CellValue
        {
            Text = "1"
        };

        cell75.Append(cellValue7);
        var cell76 = new Cell { CellReference = "D2", StyleIndex = (UInt32Value)4U };

        var cell77 = new Cell { CellReference = "E2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue8 = new CellValue
        {
            Text = "2"
        };

        cell77.Append(cellValue8);
        var cell78 = new Cell { CellReference = "F2", StyleIndex = (UInt32Value)5U };

        var cell79 = new Cell { CellReference = "G2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue9 = new CellValue
        {
            Text = "3"
        };

        cell79.Append(cellValue9);
        var cell80 = new Cell { CellReference = "H2", StyleIndex = (UInt32Value)5U };

        var cell81 = new Cell { CellReference = "I2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue10 = new CellValue
        {
            Text = "4"
        };

        cell81.Append(cellValue10);
        var cell82 = new Cell { CellReference = "J2", StyleIndex = (UInt32Value)5U };

        var cell83 = new Cell { CellReference = "K2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue11 = new CellValue
        {
            Text = "5"
        };

        cell83.Append(cellValue11);
        var cell84 = new Cell { CellReference = "L2", StyleIndex = (UInt32Value)5U };

        var cell85 = new Cell { CellReference = "M2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue12 = new CellValue
        {
            Text = "6"
        };

        cell85.Append(cellValue12);
        var cell86 = new Cell { CellReference = "N2", StyleIndex = (UInt32Value)5U };

        var cell87 = new Cell { CellReference = "O2", StyleIndex = (UInt32Value)6U, DataType = CellValues.Number };
        var cellValue13 = new CellValue
        {
            Text = "7"
        };

        cell87.Append(cellValue13);
        var cell88 = new Cell { CellReference = "P2", StyleIndex = (UInt32Value)6U };

        var cell89 = new Cell { CellReference = "Q2", StyleIndex = (UInt32Value)4U, DataType = CellValues.Number };
        var cellValue14 = new CellValue
        {
            Text = "1"
        };

        cell89.Append(cellValue14);
        var cell90 = new Cell { CellReference = "R2", StyleIndex = (UInt32Value)4U };

        var cell91 = new Cell { CellReference = "S2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue15 = new CellValue
        {
            Text = "2"
        };

        cell91.Append(cellValue15);
        var cell92 = new Cell { CellReference = "T2", StyleIndex = (UInt32Value)5U };

        var cell93 = new Cell { CellReference = "U2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue16 = new CellValue
        {
            Text = "3"
        };

        cell93.Append(cellValue16);
        var cell94 = new Cell { CellReference = "V2", StyleIndex = (UInt32Value)5U };

        var cell95 = new Cell { CellReference = "W2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue17 = new CellValue
        {
            Text = "4"
        };

        cell95.Append(cellValue17);
        var cell96 = new Cell { CellReference = "X2", StyleIndex = (UInt32Value)5U };

        var cell97 = new Cell { CellReference = "Y2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue18 = new CellValue
        {
            Text = "5"
        };

        cell97.Append(cellValue18);
        var cell98 = new Cell { CellReference = "Z2", StyleIndex = (UInt32Value)5U };

        var cell99 = new Cell { CellReference = "AA2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue19 = new CellValue
        {
            Text = "6"
        };

        cell99.Append(cellValue19);
        var cell100 = new Cell { CellReference = "AB2", StyleIndex = (UInt32Value)5U };

        var cell101 = new Cell { CellReference = "AC2", StyleIndex = (UInt32Value)6U, DataType = CellValues.Number };
        var cellValue20 = new CellValue
        {
            Text = "7"
        };

        cell101.Append(cellValue20);
        var cell102 = new Cell { CellReference = "AD2", StyleIndex = (UInt32Value)6U };

        var cell103 = new Cell { CellReference = "AE2", StyleIndex = (UInt32Value)4U, DataType = CellValues.Number };
        var cellValue21 = new CellValue
        {
            Text = "1"
        };

        cell103.Append(cellValue21);
        var cell104 = new Cell { CellReference = "AF2", StyleIndex = (UInt32Value)4U };

        var cell105 = new Cell { CellReference = "AG2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue22 = new CellValue
        {
            Text = "2"
        };

        cell105.Append(cellValue22);
        var cell106 = new Cell { CellReference = "AH2", StyleIndex = (UInt32Value)5U };

        var cell107 = new Cell { CellReference = "AI2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue23 = new CellValue
        {
            Text = "3"
        };

        cell107.Append(cellValue23);
        var cell108 = new Cell { CellReference = "AJ2", StyleIndex = (UInt32Value)5U };

        var cell109 = new Cell { CellReference = "AK2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue24 = new CellValue
        {
            Text = "4"
        };

        cell109.Append(cellValue24);
        var cell110 = new Cell { CellReference = "AL2", StyleIndex = (UInt32Value)5U };

        var cell111 = new Cell { CellReference = "AM2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue25 = new CellValue
        {
            Text = "5"
        };

        cell111.Append(cellValue25);
        var cell112 = new Cell { CellReference = "AN2", StyleIndex = (UInt32Value)5U };

        var cell113 = new Cell { CellReference = "AO2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue26 = new CellValue
        {
            Text = "6"
        };

        cell113.Append(cellValue26);
        var cell114 = new Cell { CellReference = "AP2", StyleIndex = (UInt32Value)5U };

        var cell115 = new Cell { CellReference = "AQ2", StyleIndex = (UInt32Value)6U, DataType = CellValues.Number };
        var cellValue27 = new CellValue
        {
            Text = "7"
        };

        cell115.Append(cellValue27);
        var cell116 = new Cell { CellReference = "AR2", StyleIndex = (UInt32Value)6U };

        var cell117 = new Cell { CellReference = "AS2", StyleIndex = (UInt32Value)4U, DataType = CellValues.Number };
        var cellValue28 = new CellValue
        {
            Text = "1"
        };

        cell117.Append(cellValue28);
        var cell118 = new Cell { CellReference = "AT2", StyleIndex = (UInt32Value)4U };

        var cell119 = new Cell { CellReference = "AU2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue29 = new CellValue
        {
            Text = "2"
        };

        cell119.Append(cellValue29);
        var cell120 = new Cell { CellReference = "AV2", StyleIndex = (UInt32Value)5U };

        var cell121 = new Cell { CellReference = "AW2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue30 = new CellValue
        {
            Text = "3"
        };

        cell121.Append(cellValue30);
        var cell122 = new Cell { CellReference = "AX2", StyleIndex = (UInt32Value)5U };

        var cell123 = new Cell { CellReference = "AY2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue31 = new CellValue
        {
            Text = "4"
        };

        cell123.Append(cellValue31);
        var cell124 = new Cell { CellReference = "AZ2", StyleIndex = (UInt32Value)5U };

        var cell125 = new Cell { CellReference = "BA2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue32 = new CellValue
        {
            Text = "5"
        };

        cell125.Append(cellValue32);
        var cell126 = new Cell { CellReference = "BB2", StyleIndex = (UInt32Value)5U };

        var cell127 = new Cell { CellReference = "BC2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue33 = new CellValue
        {
            Text = "6"
        };

        cell127.Append(cellValue33);
        var cell128 = new Cell { CellReference = "BD2", StyleIndex = (UInt32Value)5U };

        var cell129 = new Cell { CellReference = "BE2", StyleIndex = (UInt32Value)6U, DataType = CellValues.Number };
        var cellValue34 = new CellValue
        {
            Text = "7"
        };

        cell129.Append(cellValue34);
        var cell130 = new Cell { CellReference = "BF2", StyleIndex = (UInt32Value)6U };

        var cell131 = new Cell { CellReference = "BG2", StyleIndex = (UInt32Value)4U, DataType = CellValues.Number };
        var cellValue35 = new CellValue
        {
            Text = "1"
        };

        cell131.Append(cellValue35);
        var cell132 = new Cell { CellReference = "BH2", StyleIndex = (UInt32Value)4U };

        var cell133 = new Cell { CellReference = "BI2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue36 = new CellValue
        {
            Text = "2"
        };

        cell133.Append(cellValue36);
        var cell134 = new Cell { CellReference = "BJ2", StyleIndex = (UInt32Value)5U };

        var cell135 = new Cell { CellReference = "BK2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue37 = new CellValue
        {
            Text = "3"
        };

        cell135.Append(cellValue37);
        var cell136 = new Cell { CellReference = "BL2", StyleIndex = (UInt32Value)5U };

        var cell137 = new Cell { CellReference = "BM2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue38 = new CellValue
        {
            Text = "4"
        };

        cell137.Append(cellValue38);
        var cell138 = new Cell { CellReference = "BN2", StyleIndex = (UInt32Value)5U };

        var cell139 = new Cell { CellReference = "BO2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue39 = new CellValue
        {
            Text = "5"
        };

        cell139.Append(cellValue39);
        var cell140 = new Cell { CellReference = "BP2", StyleIndex = (UInt32Value)5U };

        var cell141 = new Cell { CellReference = "BQ2", StyleIndex = (UInt32Value)5U, DataType = CellValues.Number };
        var cellValue40 = new CellValue
        {
            Text = "6"
        };

        cell141.Append(cellValue40);
        var cell142 = new Cell { CellReference = "BR2", StyleIndex = (UInt32Value)5U };

        var cell143 = new Cell { CellReference = "BS2", StyleIndex = (UInt32Value)6U, DataType = CellValues.Number };
        var cellValue41 = new CellValue
        {
            Text = "7"
        };

        cell143.Append(cellValue41);
        var cell144 = new Cell { CellReference = "BT2", StyleIndex = (UInt32Value)6U };

        row2.Append(cell73);
        row2.Append(cell74);
        row2.Append(cell75);
        row2.Append(cell76);
        row2.Append(cell77);
        row2.Append(cell78);
        row2.Append(cell79);
        row2.Append(cell80);
        row2.Append(cell81);
        row2.Append(cell82);
        row2.Append(cell83);
        row2.Append(cell84);
        row2.Append(cell85);
        row2.Append(cell86);
        row2.Append(cell87);
        row2.Append(cell88);
        row2.Append(cell89);
        row2.Append(cell90);
        row2.Append(cell91);
        row2.Append(cell92);
        row2.Append(cell93);
        row2.Append(cell94);
        row2.Append(cell95);
        row2.Append(cell96);
        row2.Append(cell97);
        row2.Append(cell98);
        row2.Append(cell99);
        row2.Append(cell100);
        row2.Append(cell101);
        row2.Append(cell102);
        row2.Append(cell103);
        row2.Append(cell104);
        row2.Append(cell105);
        row2.Append(cell106);
        row2.Append(cell107);
        row2.Append(cell108);
        row2.Append(cell109);
        row2.Append(cell110);
        row2.Append(cell111);
        row2.Append(cell112);
        row2.Append(cell113);
        row2.Append(cell114);
        row2.Append(cell115);
        row2.Append(cell116);
        row2.Append(cell117);
        row2.Append(cell118);
        row2.Append(cell119);
        row2.Append(cell120);
        row2.Append(cell121);
        row2.Append(cell122);
        row2.Append(cell123);
        row2.Append(cell124);
        row2.Append(cell125);
        row2.Append(cell126);
        row2.Append(cell127);
        row2.Append(cell128);
        row2.Append(cell129);
        row2.Append(cell130);
        row2.Append(cell131);
        row2.Append(cell132);
        row2.Append(cell133);
        row2.Append(cell134);
        row2.Append(cell135);
        row2.Append(cell136);
        row2.Append(cell137);
        row2.Append(cell138);
        row2.Append(cell139);
        row2.Append(cell140);
        row2.Append(cell141);
        row2.Append(cell142);
        row2.Append(cell143);
        row2.Append(cell144);


        var mergeCell1 = new MergeCell { Reference = "A1:A2" };
        var mergeCell2 = new MergeCell { Reference = "B1:B2" };
        var mergeCell3 = new MergeCell { Reference = "C1:P1" };
        var mergeCell4 = new MergeCell { Reference = "Q1:AD1" };
        var mergeCell5 = new MergeCell { Reference = "AE1:AR1" };
        var mergeCell6 = new MergeCell { Reference = "AS1:BF1" };
        var mergeCell7 = new MergeCell { Reference = "BG1:BT1" };
        var mergeCell8 = new MergeCell { Reference = "C2:D2" };
        var mergeCell9 = new MergeCell { Reference = "E2:F2" };
        var mergeCell10 = new MergeCell { Reference = "G2:H2" };
        var mergeCell11 = new MergeCell { Reference = "I2:J2" };
        var mergeCell12 = new MergeCell { Reference = "K2:L2" };
        var mergeCell13 = new MergeCell { Reference = "M2:N2" };
        var mergeCell14 = new MergeCell { Reference = "O2:P2" };
        var mergeCell15 = new MergeCell { Reference = "Q2:R2" };
        var mergeCell16 = new MergeCell { Reference = "S2:T2" };
        var mergeCell17 = new MergeCell { Reference = "U2:V2" };
        var mergeCell18 = new MergeCell { Reference = "W2:X2" };
        var mergeCell19 = new MergeCell { Reference = "Y2:Z2" };
        var mergeCell20 = new MergeCell { Reference = "AA2:AB2" };
        var mergeCell21 = new MergeCell { Reference = "AC2:AD2" };
        var mergeCell22 = new MergeCell { Reference = "AE2:AF2" };
        var mergeCell23 = new MergeCell { Reference = "AG2:AH2" };
        var mergeCell24 = new MergeCell { Reference = "AI2:AJ2" };
        var mergeCell25 = new MergeCell { Reference = "AK2:AL2" };
        var mergeCell26 = new MergeCell { Reference = "AM2:AN2" };
        var mergeCell27 = new MergeCell { Reference = "AO2:AP2" };
        var mergeCell28 = new MergeCell { Reference = "AQ2:AR2" };
        var mergeCell29 = new MergeCell { Reference = "AS2:AT2" };
        var mergeCell30 = new MergeCell { Reference = "AU2:AV2" };
        var mergeCell31 = new MergeCell { Reference = "AW2:AX2" };
        var mergeCell32 = new MergeCell { Reference = "AY2:AZ2" };
        var mergeCell33 = new MergeCell { Reference = "BA2:BB2" };
        var mergeCell34 = new MergeCell { Reference = "BC2:BD2" };
        var mergeCell35 = new MergeCell { Reference = "BE2:BF2" };
        var mergeCell36 = new MergeCell { Reference = "BG2:BH2" };
        var mergeCell37 = new MergeCell { Reference = "BI2:BJ2" };
        var mergeCell38 = new MergeCell { Reference = "BK2:BL2" };
        var mergeCell39 = new MergeCell { Reference = "BM2:BN2" };
        var mergeCell40 = new MergeCell { Reference = "BO2:BP2" };
        var mergeCell41 = new MergeCell { Reference = "BQ2:BR2" };
        var mergeCell42 = new MergeCell { Reference = "BS2:BT2" };

        mergeCells.Append(mergeCell1);
        mergeCells.Append(mergeCell2);
        mergeCells.Append(mergeCell3);
        mergeCells.Append(mergeCell4);
        mergeCells.Append(mergeCell5);
        mergeCells.Append(mergeCell6);
        mergeCells.Append(mergeCell7);
        mergeCells.Append(mergeCell8);
        mergeCells.Append(mergeCell9);
        mergeCells.Append(mergeCell10);
        mergeCells.Append(mergeCell11);
        mergeCells.Append(mergeCell12);
        mergeCells.Append(mergeCell13);
        mergeCells.Append(mergeCell14);
        mergeCells.Append(mergeCell15);
        mergeCells.Append(mergeCell16);
        mergeCells.Append(mergeCell17);
        mergeCells.Append(mergeCell18);
        mergeCells.Append(mergeCell19);
        mergeCells.Append(mergeCell20);
        mergeCells.Append(mergeCell21);
        mergeCells.Append(mergeCell22);
        mergeCells.Append(mergeCell23);
        mergeCells.Append(mergeCell24);
        mergeCells.Append(mergeCell25);
        mergeCells.Append(mergeCell26);
        mergeCells.Append(mergeCell27);
        mergeCells.Append(mergeCell28);
        mergeCells.Append(mergeCell29);
        mergeCells.Append(mergeCell30);
        mergeCells.Append(mergeCell31);
        mergeCells.Append(mergeCell32);
        mergeCells.Append(mergeCell33);
        mergeCells.Append(mergeCell34);
        mergeCells.Append(mergeCell35);
        mergeCells.Append(mergeCell36);
        mergeCells.Append(mergeCell37);
        mergeCells.Append(mergeCell38);
        mergeCells.Append(mergeCell39);
        mergeCells.Append(mergeCell40);
        mergeCells.Append(mergeCell41);
        mergeCells.Append(mergeCell42);

        sheetData1.Append(row1);
        sheetData1.Append(row2);

        var upRowIndex = 3U;
        var downRowIndex = upRowIndex + 1;
        foreach (var (teacher, i) in _model.Teachers
                     .OrderBy(x => x.Name)
                     .Select((x, i) => (x, i)))
        {
            var upRow = new Row
            {
                RowIndex = (UInt32Value)upRowIndex,
                CustomFormat = false,
                Height = 13.5D,
                Hidden = false,
                CustomHeight = false,
                OutlineLevel = 0,
                Collapsed = false
            };
            var downRow = new Row
            {
                RowIndex = (UInt32Value)downRowIndex,
                CustomFormat = false,
                Height = 13.5D,
                Hidden = false,
                CustomHeight = false,
                OutlineLevel = 0,
                Collapsed = false
            };

            // number
            upRow.Append(new Cell
            {
                CellReference = upRowIndex.GetCellReference(1),
                StyleIndex = (UInt32Value)10U,
                DataType = CellValues.Number,
                CellValue = new CellValue(i + 1)
            });
            downRow.Append(new Cell
            {
                CellReference = downRowIndex.GetCellReference(1),
                StyleIndex = (UInt32Value)11U
            });
            mergeCells.Append(new MergeCell
            {
                Reference = upRowIndex.GetCellReference(1) +
                            ":" +
                            downRowIndex.GetCellReference(1)
            });
            // teacher name
            upRow.Append(new Cell
            {
                CellReference = upRowIndex.GetCellReference(2),
                StyleIndex = (UInt32Value)10U,
                DataType = CellValues.String,
                CellValue = new CellValue(teacher.Name)
            });
            downRow.Append(new Cell
            {
                CellReference = downRowIndex.GetCellReference(2),
                StyleIndex = (UInt32Value)11U
            });
            mergeCells.Append(new MergeCell
            {
                Reference = upRowIndex.GetCellReference(2) +
                            ":" +
                            downRowIndex.GetCellReference(2)
            });
            for (var dayOfWeek = 0; dayOfWeek < studyDaysAtWeek; dayOfWeek++)
            for (var number = 0; number < lessonsOnDayCount; number++)
            {
                var horizontalStart = startScheduleTable +
                                      dayOfWeek * perDayOfWeekSectionWidth +
                                      number * perLessonCellWidth;
                var tuple = teacher.Schedule.GetValueOrDefault((number, dayOfWeek));
                var mergeCabinetCells = upRowIndex.GetCellReference(horizontalStart + 1) +
                                        ":" +
                                        downRowIndex.GetCellReference(horizontalStart + 1);
                var mergeSubjectCells = upRowIndex.GetCellReference(horizontalStart) +
                                        ":" +
                                        downRowIndex.GetCellReference(horizontalStart);
                if (tuple.all is not null &&
                    tuple.numerator is null &&
                    tuple.divisor is null)
                {
                    upRow.Append(new Cell
                    {
                        CellReference = upRowIndex.GetCellReference(horizontalStart),
                        StyleIndex = (UInt32Value)10U,
                        DataType = CellValues.String,
                        CellValue = new CellValue(tuple.all.Subject)
                    });
                    upRow.Append(new Cell
                    {
                        CellReference = upRowIndex.GetCellReference(horizontalStart + 1),
                        StyleIndex = (UInt32Value)10U,
                        DataType = CellValues.String,
                        CellValue = !string.IsNullOrWhiteSpace(tuple.all.Cabinet)
                            ? new CellValue(tuple.all.Cabinet)
                            : null
                    });
                    downRow.Append(new Cell
                    {
                        CellReference = downRowIndex.GetCellReference(horizontalStart),
                        StyleIndex = (UInt32Value)11U
                    });
                    downRow.Append(new Cell
                    {
                        CellReference = downRowIndex.GetCellReference(horizontalStart + 1),
                        StyleIndex = (UInt32Value)11U
                    });
                    mergeCells.Append(new MergeCell
                    {
                        Reference = mergeSubjectCells
                    });
                    mergeCells.Append(new MergeCell
                    {
                        Reference = mergeCabinetCells
                    });
                }
                else if (tuple.numerator is not null || tuple.divisor is not null)
                {
                    if (tuple.numerator is not null)
                    {
                        upRow.Append(new Cell
                        {
                            CellReference = upRowIndex.GetCellReference(horizontalStart),
                            StyleIndex = (UInt32Value)10U,
                            DataType = CellValues.String,
                            CellValue = new CellValue(tuple.numerator.Subject)
                        });
                        upRow.Append(new Cell
                        {
                            CellReference = upRowIndex.GetCellReference(horizontalStart + 1),
                            StyleIndex = (UInt32Value)10U,
                            DataType = CellValues.String,
                            CellValue = !string.IsNullOrWhiteSpace(tuple.numerator.Cabinet)
                                ? new CellValue(tuple.numerator.Cabinet)
                                : null
                        });
                    }
                    else
                    {
                        upRow.Append(new Cell
                        {
                            CellReference = upRowIndex.GetCellReference(horizontalStart),
                            StyleIndex = (UInt32Value)10U
                        });
                        upRow.Append(new Cell
                        {
                            CellReference = upRowIndex.GetCellReference(horizontalStart + 1),
                            StyleIndex = (UInt32Value)10U
                        });
                    }

                    if (tuple.divisor is not null)
                    {
                        downRow.Append(new Cell
                        {
                            CellReference = downRowIndex.GetCellReference(horizontalStart),
                            StyleIndex = (UInt32Value)11U,
                            DataType = CellValues.String,
                            CellValue = new CellValue(tuple.divisor.Subject)
                        });
                        downRow.Append(new Cell
                        {
                            CellReference = downRowIndex.GetCellReference(horizontalStart + 1),
                            StyleIndex = (UInt32Value)11U,
                            DataType = CellValues.String,
                            CellValue = !string.IsNullOrWhiteSpace(tuple.divisor.Cabinet)
                                ? new CellValue(tuple.divisor.Cabinet)
                                : null
                        });
                    }
                    else
                    {
                        downRow.Append(new Cell
                        {
                            CellReference = downRowIndex.GetCellReference(horizontalStart),
                            StyleIndex = (UInt32Value)11U
                        });
                        downRow.Append(new Cell
                        {
                            CellReference = downRowIndex.GetCellReference(horizontalStart + 1),
                            StyleIndex = (UInt32Value)11U
                        });
                    }
                }
                else
                {
                    upRow.Append(new Cell
                    {
                        CellReference = upRowIndex.GetCellReference(horizontalStart),
                        StyleIndex = (UInt32Value)10U
                    });
                    upRow.Append(new Cell
                    {
                        CellReference = upRowIndex.GetCellReference(horizontalStart + 1),
                        StyleIndex = (UInt32Value)10U
                    });
                    downRow.Append(new Cell
                    {
                        CellReference = downRowIndex.GetCellReference(horizontalStart),
                        StyleIndex = (UInt32Value)11U
                    });
                    downRow.Append(new Cell
                    {
                        CellReference = downRowIndex.GetCellReference(horizontalStart + 1),
                        StyleIndex = (UInt32Value)11U
                    });
                    mergeCells.Append(new MergeCell
                    {
                        Reference = mergeSubjectCells
                    });
                    mergeCells.Append(new MergeCell
                    {
                        Reference = mergeCabinetCells
                    });
                }
            }

            sheetData1.Append(upRow);
            sheetData1.Append(downRow);

            upRowIndex += 2;
            downRowIndex = upRowIndex + 1;
        }

        var printOptions1 = new PrintOptions
        {
            HorizontalCentered = false, VerticalCentered = false, Headings = false, GridLines = false,
            GridLinesSet = true
        };
        var pageMargins1 = new PageMargins
            { Left = 0D, Right = 0D, Top = 0.39375D, Bottom = 0.39375D, Header = 0D, Footer = 0D };
        var pageSetup1 = new PageSetup
        {
            PaperSize = (UInt32Value)9U, Scale = (UInt32Value)100U, FitToWidth = (UInt32Value)1U,
            FitToHeight = (UInt32Value)1U, PageOrder = PageOrderValues.DownThenOver,
            Orientation = OrientationValues.Portrait, BlackAndWhite = false, Draft = false,
            CellComments = CellCommentsValues.None, HorizontalDpi = (UInt32Value)300U, VerticalDpi = (UInt32Value)300U,
            Copies = (UInt32Value)1U
        };

        var headerFooter1 = new HeaderFooter { DifferentOddEven = false, DifferentFirst = false };
        var oddHeader1 = new OddHeader
        {
            Text = "&C&A"
        };
        var oddFooter1 = new OddFooter
        {
            Text = "&CСтраница &P"
        };

        headerFooter1.Append(oddHeader1);
        headerFooter1.Append(oddFooter1);

        worksheet1.Append(sheetProperties1);
        worksheet1.Append(sheetDimension1);
        worksheet1.Append(sheetViews1);
        worksheet1.Append(sheetFormatProperties1);
        worksheet1.Append(columns1);
        worksheet1.Append(sheetData1);
        worksheet1.Append(mergeCells);
        worksheet1.Append(printOptions1);
        worksheet1.Append(pageMargins1);
        worksheet1.Append(pageSetup1);
        worksheet1.Append(headerFooter1);

        worksheetPart1.Worksheet = worksheet1;
    }

    // Generates content of sharedStringTablePart1.
    private static void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
    {
        var sharedStringTable1 = new SharedStringTable();

        var sharedStringItem1 = new SharedStringItem();
        var text1 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "ФИО"
        };

        sharedStringItem1.Append(text1);

        var sharedStringItem2 = new SharedStringItem();
        var text2 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Понедельник"
        };

        sharedStringItem2.Append(text2);

        var sharedStringItem3 = new SharedStringItem();
        var text3 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Вторник"
        };

        sharedStringItem3.Append(text3);

        var sharedStringItem4 = new SharedStringItem();
        var text4 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Среда"
        };

        sharedStringItem4.Append(text4);

        var sharedStringItem5 = new SharedStringItem();
        var text5 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Четверг"
        };

        sharedStringItem5.Append(text5);

        var sharedStringItem6 = new SharedStringItem();
        var text6 = new Text
        {
            Space = SpaceProcessingModeValues.Preserve,
            Text = "Пятница"
        };

        sharedStringItem6.Append(text6);

        sharedStringTable1.Append(sharedStringItem1);
        sharedStringTable1.Append(sharedStringItem2);
        sharedStringTable1.Append(sharedStringItem3);
        sharedStringTable1.Append(sharedStringItem4);
        sharedStringTable1.Append(sharedStringItem5);
        sharedStringTable1.Append(sharedStringItem6);

        sharedStringTablePart1.SharedStringTable = sharedStringTable1;
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
            Text = ""
        };
        var totalTime1 = new Ap.TotalTime
        {
            Text = "0"
        };
        var application1 = new Ap.Application
        {
            Text = "TechnicalSchoolAutomationSystem"
        };
        var applicationVersion1 = new Ap.ApplicationVersion
        {
            Text = "0.1"
        };

        properties1.Append(template1);
        properties1.Append(totalTime1);
        properties1.Append(application1);
        properties1.Append(applicationVersion1);

        extendedFilePropertiesPart1.Properties = properties1;
    }

    private void SetPackageProperties(OpenXmlPackage document)
    {
    }

    #region Binary Data

    private string extendedPart1Data =
        "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAyMi0wNi0xNVQxMzowMzo0NVo8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj5BZG1pbjwvZGM6Y3JlYXRvcj48ZGM6ZGVzY3JpcHRpb24+PC9kYzpkZXNjcmlwdGlvbj48ZGM6bGFuZ3VhZ2U+cnUtUlU8L2RjOmxhbmd1YWdlPjxjcDpsYXN0TW9kaWZpZWRCeT5BZG1pbjwvY3A6bGFzdE1vZGlmaWVkQnk+PGRjdGVybXM6bW9kaWZpZWQgeHNpOnR5cGU9ImRjdGVybXM6VzNDRFRGIj4yMDIyLTA2LTE1VDE1OjM5OjUxWjwvZGN0ZXJtczptb2RpZmllZD48Y3A6cmV2aXNpb24+MTwvY3A6cmV2aXNpb24+PGRjOnN1YmplY3Q+PC9kYzpzdWJqZWN0PjxkYzp0aXRsZT48L2RjOnRpdGxlPjwvY3A6Y29yZVByb3BlcnRpZXM+";

    private Stream GetBinaryDataStream(string base64String)
    {
        return new MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion
}