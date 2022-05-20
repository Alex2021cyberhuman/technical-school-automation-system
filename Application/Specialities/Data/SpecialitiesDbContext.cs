using Application.Common.Data;
using Application.Specialities.Services;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Data;

public class SpecialitiesDbContext : DbContext, ISpecialitiesContext
{
    protected SpecialitiesDbContext()
    {
    }

    public SpecialitiesDbContext(DbContextOptions<SpecialitiesDbContext> options) : base(options)
    {
    }

    public DbSet<Speciality> Speciality => Set<Speciality>();

    public DbSet<Subject> Subject => Set<Subject>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasOne(x => x.Speciality)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.SpecialityId);
            entity.OwnsMany(x => x.Semesters);
        });
    }

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