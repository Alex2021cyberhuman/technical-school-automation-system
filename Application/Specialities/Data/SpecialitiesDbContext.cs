using Application.Common.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Data;

public class SpecialitiesDbContext : DbContext
{
    protected SpecialitiesDbContext()
    {
    }

    public SpecialitiesDbContext(DbContextOptions<SpecialitiesDbContext> options) : base(options)
    {
    }

    public DbSet<Speciality> Speciality => Set<Speciality>();
    
    public DbSet<Subject> Subject => Set<Subject>();

    public static void AddToServices(IServiceCollection services, IConfiguration configuration,
        IHostEnvironment environment)
    {
        services.AddPooledDbContextFactory<SpecialitiesDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Specialities");
            options.MakeNpgsqlOptions(
                connectionString,
                environment.IsDevelopment(),
                "specialities_mt",
                typeof(SpecialitiesDbContext).Assembly.FullName);
        });
    }
}