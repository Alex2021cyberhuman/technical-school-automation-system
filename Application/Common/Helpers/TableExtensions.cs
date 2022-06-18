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
}