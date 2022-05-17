using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Data;

public static class DevelopmentSpecialitiesDbContextInitializer
{
    public static async Task InitializeSpecialitiesDbContextDevelopmentInstallationAsync(
        this IServiceProvider services)
    {
        var factory = services.GetRequiredService<IDbContextFactory<SpecialitiesDbContext>>();
        await MigrateAsync(factory);
        var environment = services.GetRequiredService<IHostEnvironment>();
        if (environment.IsDevelopment()) await UploadSpecialitiesAsync(factory);
    }

    private static async Task MigrateAsync(IDbContextFactory<SpecialitiesDbContext> factory)
    {
        await using var context = await factory.CreateDbContextAsync();
        await context.Database.MigrateAsync();
    }

    private static async Task UploadSpecialitiesAsync(
        IDbContextFactory<SpecialitiesDbContext> factory)
    {
        await using var context = await factory.CreateDbContextAsync();
        await context.Database.MigrateAsync();
        await using var transaction = await context.Database.BeginTransactionAsync(IsolationLevel.Serializable);
        var areSpecialitiesAlreadyUploaded = await context.Speciality.AnyAsync();
        if (!areSpecialitiesAlreadyUploaded)
        {
            var specialities = DevelopmentSpecialitiesProvider.ProvideSpecialities();
            context.Speciality.AddRange(specialities);
            await context.SaveChangesAsync();
        }

        await transaction.CommitAsync();
    }
}