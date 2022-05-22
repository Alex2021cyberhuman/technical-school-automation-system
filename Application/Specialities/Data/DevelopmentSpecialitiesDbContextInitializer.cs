using System.Data;
using Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Data;

public static class DevelopmentMainDbContextInitializer
{
    public static async Task InitializeMainDbContextDevelopmentInstallationAsync(
        this IServiceProvider services)
    {
        var factory = services.GetRequiredService<IDbContextFactory<MainDbContext>>();
        await MigrateAsync(factory);
        var environment = services.GetRequiredService<IHostEnvironment>();
        if (environment.IsDevelopment())
        {
            await UploadSpecialitiesAsync(factory);
        }
    }

    private static async Task MigrateAsync(IDbContextFactory<MainDbContext> factory)
    {
        await using var context = await factory.CreateDbContextAsync();
        await context.Database.MigrateAsync();
    }

    private static async Task UploadSpecialitiesAsync(
        IDbContextFactory<MainDbContext> factory)
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