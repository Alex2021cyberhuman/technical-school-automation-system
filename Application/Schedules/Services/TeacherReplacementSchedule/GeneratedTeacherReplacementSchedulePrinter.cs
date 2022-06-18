using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using static Application.Common.Helpers.TableExtensions;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;

namespace Application.Schedules.Services.TeacherReplacementSchedule;

public class GeneratedTeacherReplacementSchedulePrinter
{
    private readonly TeacherReplacementScheduleModel _model;

    public GeneratedTeacherReplacementSchedulePrinter(TeacherReplacementScheduleModel model)
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

        var extendedPart1 =
            document.AddExtendedPart(
                "http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties",
                "application/vnd.openxmlformats-package.core-properties+xml", "xml", "rId2");
        GenerateExtendedPart1Content(extendedPart1);

        var extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
        GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);
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
            { Name = "Лист1", SheetId = (UInt32Value)1U, State = SheetStateValues.Visible, Id = "rId2" };

        sheets1.Append(sheet1);
        var calculationProperties1 = new CalculationProperties
        {
            ReferenceMode = ReferenceModeValues.A1, Iterate = false, IterateCount = (UInt32Value)100U,
            IterateDelta = 0.001D
        };

        var workbookExtensionList1 = new WorkbookExtensionList();

        var workbookExtension1 = new WorkbookExtension { Uri = "{7626C862-2A13-11E5-B345-FEFF819CDC9F}" };
        workbookExtension1.AddNamespaceDeclaration("loext", "http://schemas.libreoffice.org/");

        var openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(
            "<loext:extCalcPr stringRefSyntax=\"CalcA1\" xmlns:loext=\"http://schemas.libreoffice.org/\" />");

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

        var fonts1 = new Fonts { Count = (UInt32Value)5U };

        var font1 = new Font();
        var fontSize1 = new FontSize { Val = 10D };
        var fontName1 = new FontName { Val = "Arial" };
        var fontFamilyNumbering1 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet1 = new FontCharSet { Val = 1 };

        font1.Append(fontSize1);
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
        var fontSize5 = new FontSize { Val = 14D };
        var fontName5 = new FontName { Val = "Arial" };
        var fontFamilyNumbering5 = new FontFamilyNumbering { Val = 2 };
        var fontCharSet2 = new FontCharSet { Val = 1 };

        font5.Append(fontSize5);
        font5.Append(fontName5);
        font5.Append(fontFamilyNumbering5);
        font5.Append(fontCharSet2);

        fonts1.Append(font1);
        fonts1.Append(font2);
        fonts1.Append(font3);
        fonts1.Append(font4);
        fonts1.Append(font5);

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
        var rightBorder2 = new RightBorder { Style = BorderStyleValues.Thin };
        var topBorder2 = new TopBorder { Style = BorderStyleValues.Thin };
        var bottomBorder2 = new BottomBorder { Style = BorderStyleValues.Thin };
        var diagonalBorder2 = new DiagonalBorder();

        border2.Append(leftBorder2);
        border2.Append(rightBorder2);
        border2.Append(topBorder2);
        border2.Append(bottomBorder2);
        border2.Append(diagonalBorder2);

        borders1.Append(border1);
        borders1.Append(border2);

        var cellStyleFormats1 = new CellStyleFormats { Count = (UInt32Value)23U };

        var cellFormat1 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = true
        };
        var alignment1 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
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
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)4U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = false
        };
        var alignment2 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };

        cellFormat21.Append(alignment2);

        var cellFormat22 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = false
        };
        var alignment3 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };

        cellFormat22.Append(alignment3);

        var cellFormat23 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true, ApplyAlignment = true,
            ApplyProtection = false
        };
        var alignment4 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };

        cellFormat23.Append(alignment4);

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

        var cellFormats1 = new CellFormats { Count = (UInt32Value)4U };

        var cellFormat24 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyFont = false, ApplyBorder = false,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment5 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection2 = new Protection { Locked = true, Hidden = false };

        cellFormat24.Append(alignment5);
        cellFormat24.Append(protection2);

        var cellFormat25 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)0U, FormatId = (UInt32Value)22U, ApplyFont = true, ApplyBorder = false,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment6 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection3 = new Protection { Locked = true, Hidden = false };

        cellFormat25.Append(alignment6);
        cellFormat25.Append(protection3);

        var cellFormat26 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)4U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)20U, ApplyFont = false, ApplyBorder = false,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment7 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection4 = new Protection { Locked = true, Hidden = false };

        cellFormat26.Append(alignment7);
        cellFormat26.Append(protection4);

        var cellFormat27 = new CellFormat
        {
            NumberFormatId = (UInt32Value)164U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U,
            BorderId = (UInt32Value)1U, FormatId = (UInt32Value)21U, ApplyFont = true, ApplyBorder = false,
            ApplyAlignment = false, ApplyProtection = false
        };
        var alignment8 = new Alignment
        {
            Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Top,
            TextRotation = (UInt32Value)0U, WrapText = true, Indent = (UInt32Value)0U, ShrinkToFit = false
        };
        var protection5 = new Protection { Locked = true, Hidden = false };

        cellFormat27.Append(alignment8);
        cellFormat27.Append(protection5);

        cellFormats1.Append(cellFormat24);
        cellFormats1.Append(cellFormat25);
        cellFormats1.Append(cellFormat26);
        cellFormats1.Append(cellFormat27);

        var cellStyles1 = new CellStyles { Count = (UInt32Value)9U };
        var cellStyle1 = new CellStyle { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };
        var cellStyle2 = new CellStyle { Name = "Comma", FormatId = (UInt32Value)15U, BuiltinId = (UInt32Value)3U };
        var cellStyle3 = new CellStyle { Name = "Comma [0]", FormatId = (UInt32Value)16U, BuiltinId = (UInt32Value)6U };
        var cellStyle4 = new CellStyle { Name = "Currency", FormatId = (UInt32Value)17U, BuiltinId = (UInt32Value)4U };
        var cellStyle5 = new CellStyle
            { Name = "Currency [0]", FormatId = (UInt32Value)18U, BuiltinId = (UInt32Value)7U };
        var cellStyle6 = new CellStyle { Name = "Percent", FormatId = (UInt32Value)19U, BuiltinId = (UInt32Value)5U };
        var cellStyle7 = new CellStyle { Name = "Title", FormatId = (UInt32Value)20U };
        var cellStyle8 = new CellStyle { Name = "Table", FormatId = (UInt32Value)21U };
        var cellStyle9 = new CellStyle { Name = "TailText", FormatId = (UInt32Value)22U };

        cellStyles1.Append(cellStyle1);
        cellStyles1.Append(cellStyle2);
        cellStyles1.Append(cellStyle3);
        cellStyles1.Append(cellStyle4);
        cellStyles1.Append(cellStyle5);
        cellStyles1.Append(cellStyle6);
        cellStyles1.Append(cellStyle7);
        cellStyles1.Append(cellStyle8);
        cellStyles1.Append(cellStyle9);

        stylesheet1.Append(numberingFormats1);
        stylesheet1.Append(fonts1);
        stylesheet1.Append(fills1);
        stylesheet1.Append(borders1);
        stylesheet1.Append(cellStyleFormats1);
        stylesheet1.Append(cellFormats1);
        stylesheet1.Append(cellStyles1);

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
        var sheetDimension1 = new SheetDimension { Reference = "A1:H8" };

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
            Pane = PaneValues.TopLeft, ActiveCell = "A9", ActiveCellId = (UInt32Value)0U,
            SequenceOfReferences = new ListValue<StringValue> { InnerText = "A9" }
        };

        sheetView1.Append(selection1);

        sheetViews1.Append(sheetView1);
        var sheetFormatProperties1 = new SheetFormatProperties
        {
            DefaultColumnWidth = 9.625D, DefaultRowHeight = 15D, ZeroHeight = false, OutlineLevelRow = 0,
            OutlineLevelColumn = 0
        };

        var columns1 = new Columns();
        var column1 = new Column
        {
            Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 15D, Style = (UInt32Value)0U, Hidden = false,
            CustomWidth = true, OutlineLevel = 0, Collapsed = false
        };
        var column2 = new Column
        {
            Min = (UInt32Value)2U, Max = (UInt32Value)8U, Width = 15D, Style = (UInt32Value)0U, Hidden = false,
            CustomWidth = true, OutlineLevel = 0, Collapsed = false
        };

        columns1.Append(column1);
        columns1.Append(column2);

        var sheetData1 = new SheetData();

        var mergeCells1 = new MergeCells { Count = (UInt32Value)2U };
        var mergeCell1 = new MergeCell { Reference = "A1:H1" };

        mergeCells1.Append(mergeCell1);

        var row1 = new Row
        {
            RowIndex = (UInt32Value)1U, CustomFormat = false, Height = 15D, Hidden = false, CustomHeight = false,
            OutlineLevel = 0, Collapsed = false
        };

        var dayOfWeekText = GetDayOfWeekText((int)_model.Date.DayOfWeek - 1);
        var dateText = _model.Date.ToShortDateString();
        var weekSeparationText = GetWeekSeparationText(_model.WeekSeparation);
        row1.Append(
            GetCell(1, 1, 1, $"Изменения в расписании на {dateText} {dayOfWeekText} ({weekSeparationText})"),
            GetCell(1, 2),
            GetCell(1, 3),
            GetCell(1, 4),
            GetCell(1, 5),
            GetCell(1, 6),
            GetCell(1, 7),
            GetCell(1, 8));

        sheetData1.Append(row1);

        var row2 = new Row
        {
            RowIndex = (UInt32Value)4U, CustomFormat = false, Height = 17.35D, Hidden = false, CustomHeight = false,
            OutlineLevel = 0, Collapsed = false
        };

        var cell9 = GetCell(4, 1, 2, "Учитель");

        var cell10 = new Cell { CellReference = "B4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue2 = new CellValue
        {
            Text = "1"
        };

        cell10.Append(cellValue2);

        var cell11 = new Cell { CellReference = "C4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue3 = new CellValue
        {
            Text = "2"
        };

        cell11.Append(cellValue3);

        var cell12 = new Cell { CellReference = "D4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue4 = new CellValue
        {
            Text = "3"
        };

        cell12.Append(cellValue4);

        var cell13 = new Cell { CellReference = "E4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue5 = new CellValue
        {
            Text = "4"
        };

        cell13.Append(cellValue5);

        var cell14 = new Cell { CellReference = "F4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue6 = new CellValue
        {
            Text = "5"
        };

        cell14.Append(cellValue6);

        var cell15 = new Cell { CellReference = "G4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue7 = new CellValue
        {
            Text = "6"
        };

        cell15.Append(cellValue7);

        var cell16 = new Cell { CellReference = "H4", StyleIndex = (UInt32Value)2U, DataType = CellValues.Number };
        var cellValue8 = new CellValue
        {
            Text = "7"
        };

        cell16.Append(cellValue8);

        row2.Append(cell9);
        row2.Append(cell10);
        row2.Append(cell11);
        row2.Append(cell12);
        row2.Append(cell13);
        row2.Append(cell14);
        row2.Append(cell15);
        row2.Append(cell16);

        sheetData1.Append(row2);

        var rowIndex = 5U;

        foreach (var (name, teacherId) in _model.Teachers)
        {
            var row = new Row
            {
                RowIndex = (UInt32Value)rowIndex,
                CustomFormat = false,
                Height = 24D,
                Hidden = false,
                CustomHeight = true,
                OutlineLevel = 0,
                Collapsed = false
            };
            row.Append(GetCell(rowIndex, 1, 3, name));
            for (var number = 0; number < 7; number++)
            {
                var column = number + 2;
                var item = _model.Schedule.GetValueOrDefault((number, teacherId));
                if (item is null)
                {
                    row.Append(GetCell(rowIndex, column, 3));
                }
                else
                {
                    if (item.TeacherId.HasValue && item.TeacherId != teacherId)
                    {
                        row.Append(GetCell(rowIndex, column, 3, "Отмена"));
                    }
                    else
                    {
                        row.Append(GetCell(rowIndex, column, 3, item.Text));
                    }
                }
            }

            sheetData1.Append(row);
            rowIndex += 1;
        }

        rowIndex += 1;
        var row5 = new Row
        {
            RowIndex = (UInt32Value)rowIndex, CustomFormat = false, Height = 15D, Hidden = false, CustomHeight = false,
            OutlineLevel = 0, Collapsed = false
        };

        row5.Append(GetCell(rowIndex, 1, 1, "Зам. Дирекотора по УР ___________________________________"),
            GetCell(rowIndex, 2),
            GetCell(rowIndex, 3),
            GetCell(rowIndex, 4),
            GetCell(rowIndex, 5),
            GetCell(rowIndex, 6),
            GetCell(rowIndex, 7),
            GetCell(rowIndex, 8));

        var mergeCell2 = GetMergeCell(rowIndex, 1, rowIndex, 8);

        mergeCells1.Append(mergeCell2);

        sheetData1.Append(row5);


        var printOptions1 = new PrintOptions
        {
            HorizontalCentered = false, VerticalCentered = false, Headings = false, GridLines = false,
            GridLinesSet = true
        };
        var pageMargins1 = new PageMargins
        {
            Left = 0D, Right = 0D, Top = 1.05277777777778D, Bottom = 1.05277777777778D, Header = 0D,
            Footer = 0D
        };
        var pageSetup1 = new PageSetup
        {
            PaperSize = (UInt32Value)9U, Scale = (UInt32Value)100U, FirstPageNumber = (UInt32Value)1U,
            FitToWidth = (UInt32Value)1U, FitToHeight = (UInt32Value)1U, PageOrder = PageOrderValues.DownThenOver,
            Orientation = OrientationValues.Portrait, BlackAndWhite = false, Draft = false,
            CellComments = CellCommentsValues.None, UseFirstPageNumber = true, HorizontalDpi = (UInt32Value)300U,
            VerticalDpi = (UInt32Value)300U, Copies = (UInt32Value)1U
        };

        var headerFooter1 = new HeaderFooter { DifferentOddEven = false, DifferentFirst = false };
        var oddHeader1 = new OddHeader
        {
            Text = "&C&\"Times New Roman,Обычный\"&A"
        };
        var oddFooter1 = new OddFooter
        {
            Text = "&C&\"Times New Roman,Обычный\"Страница &P"
        };

        headerFooter1.Append(oddHeader1);
        headerFooter1.Append(oddFooter1);

        worksheet1.Append(sheetProperties1);
        worksheet1.Append(sheetDimension1);
        worksheet1.Append(sheetViews1);
        worksheet1.Append(sheetFormatProperties1);
        worksheet1.Append(columns1);
        worksheet1.Append(sheetData1);
        worksheet1.Append(mergeCells1);
        worksheet1.Append(printOptions1);
        worksheet1.Append(pageMargins1);
        worksheet1.Append(pageSetup1);
        worksheet1.Append(headerFooter1);

        worksheetPart1.Worksheet = worksheet1;
    }

    // Generates content of extendedPart1.
    private void GenerateExtendedPart1Content(OpenXmlPart extendedPart1)
    {
        var data = GetBinaryDataStream(extendedPart1Data);
        extendedPart1.FeedData(data);
        data.Close();
    }

    // Generates content of extendedFilePropertiesPart1.
    private static void GenerateExtendedFilePropertiesPart1Content(
        ExtendedFilePropertiesPart extendedFilePropertiesPart1)
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

    #region Binary Data

    private string extendedPart1Data =
        "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8Y3A6Y29yZVByb3BlcnRpZXMgeG1sbnM6Y3A9Imh0dHA6Ly9zY2hlbWFzLm9wZW54bWxmb3JtYXRzLm9yZy9wYWNrYWdlLzIwMDYvbWV0YWRhdGEvY29yZS1wcm9wZXJ0aWVzIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOmRjdGVybXM9Imh0dHA6Ly9wdXJsLm9yZy9kYy90ZXJtcy8iIHhtbG5zOmRjbWl0eXBlPSJodHRwOi8vcHVybC5vcmcvZGMvZGNtaXR5cGUvIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIj48ZGN0ZXJtczpjcmVhdGVkIHhzaTp0eXBlPSJkY3Rlcm1zOlczQ0RURiI+MjAyMi0wNi0xOFQxNzo0MTo0M1o8L2RjdGVybXM6Y3JlYXRlZD48ZGM6Y3JlYXRvcj48L2RjOmNyZWF0b3I+PGRjOmRlc2NyaXB0aW9uPjwvZGM6ZGVzY3JpcHRpb24+PGRjOmxhbmd1YWdlPnJ1LVJVPC9kYzpsYW5ndWFnZT48Y3A6bGFzdE1vZGlmaWVkQnk+PC9jcDpsYXN0TW9kaWZpZWRCeT48ZGN0ZXJtczptb2RpZmllZCB4c2k6dHlwZT0iZGN0ZXJtczpXM0NEVEYiPjIwMjItMDYtMThUMTc6NTM6NDJaPC9kY3Rlcm1zOm1vZGlmaWVkPjxjcDpyZXZpc2lvbj4xPC9jcDpyZXZpc2lvbj48ZGM6c3ViamVjdD48L2RjOnN1YmplY3Q+PGRjOnRpdGxlPjwvZGM6dGl0bGU+PC9jcDpjb3JlUHJvcGVydGllcz4=";

    private Stream GetBinaryDataStream(string base64String)
    {
        return new MemoryStream(Convert.FromBase64String(base64String));
    }

    #endregion
}