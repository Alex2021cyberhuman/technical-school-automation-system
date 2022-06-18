using Application.Schedules.Data;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Application.Common.Helpers;

public static class TableExtensions
{
    public static string GetCellReference(this uint rowIndex, int columIndex)
    {
        var column = columIndex;
        var columnName = string.Empty;
        while (column > 0)
        {
            var otherColumn = (column - 1) / 26;
            var alphaNumber = (column - 1) % 26;
            columnName = (char)(alphaNumber + 65) + columnName;
            column = otherColumn;
        }

        var cellReference = $"{columnName}{rowIndex}";
        return cellReference;
    }

    public static Cell GetCell(uint row, int column, uint style = 1, string? text = null, int? number = null)
    {
        var reference = row.GetCellReference(column);
        var cell = new Cell { CellReference = reference, StyleIndex = (UInt32Value)style };
        if (text != null)
        {
            cell.DataType = CellValues.String;
            cell.CellValue = new(text);
        }

        if (number.HasValue)
        {
            cell.DataType = CellValues.Number;
            cell.CellValue = new(number.Value);
        }

        return cell;
    }

    public static MergeCell GetMergeCell(uint row1, int column1, uint row2, int column2)
    {
        return new()
        {
            Reference = row1.GetCellReference(column1) + ":" + row2.GetCellReference(column2)
        };
    }

    public static string GetDayOfWeekText(int dayOfWeek)
    {
        return dayOfWeek switch
        {
            -1 => "Воскресенье",
            0 => "Понедельник",
            1 => "Вторник",
            2 => "Среда",
            3 => "Четверг",
            4 => "Пятница",
            5 => "Суббота",
            _ => throw new NotImplementedException()
        };
    }

    public static string GetWeekSeparationText(WeeksSeparationType type)
    {
        return type switch
        {
            WeeksSeparationType.Numerator => "Числитель",
            WeeksSeparationType.Divisor => "Знаменатель",
            WeeksSeparationType.All => "Все",
            _ => throw new NotImplementedException()
        };
    }
}