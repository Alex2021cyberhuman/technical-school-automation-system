using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Data;

public static class DbContextExtensions
{
    public static void MakeNpgsqlOptions(
        this DbContextOptionsBuilder dbContextOptionsBuilder,
        string connectionString,
        bool developmentEnvironment = false,
        string? migrationTable = null,
        string? migrationAssembly = null)
    {
        if (developmentEnvironment)
        {
            dbContextOptionsBuilder.EnableDetailedErrors();
            dbContextOptionsBuilder.EnableSensitiveDataLogging();
        }

        dbContextOptionsBuilder.UseNpgsql(connectionString, npgsqlDbContextOptionsBuilder =>
        {
            if (migrationTable != null) npgsqlDbContextOptionsBuilder.MigrationsHistoryTable(migrationTable);
            npgsqlDbContextOptionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            npgsqlDbContextOptionsBuilder.MigrationsAssembly(migrationAssembly);
        });

        dbContextOptionsBuilder.UseSnakeCaseNamingConvention(new CultureInfo("en-US"));
    }
}