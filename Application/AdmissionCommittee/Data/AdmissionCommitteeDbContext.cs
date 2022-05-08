using Application.Common.Data;
using Application.Specialities.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.AdmissionCommittee.Data;

public class AdmissionCommitteeDbContext : DbContext
{
    protected AdmissionCommitteeDbContext()
    {
    }

    public AdmissionCommitteeDbContext(DbContextOptions<AdmissionCommitteeDbContext> options) : base(options)
    {
    }

    public DbSet<Applicant> Applicant => Set<Applicant>();

    public DbSet<ApplicantSpeciality> ApplicantSpeciality => Set<ApplicantSpeciality>();

    public DbSet<Speciality> Speciality => Set<Speciality>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Speciality>().ToTable("speciality");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdmissionCommitteeDbContext).Assembly);
        modelBuilder.Entity<Applicant>(e =>
        {
            e.OwnsOne(x => x.Passport);
            e.OwnsOne(x => x.Mother);
            e.OwnsOne(x => x.Father);
            e.OwnsOne(x => x.Statement);
            e.Navigation(x => x.ApplicantSpecialities).AutoInclude();
        });
        modelBuilder.Entity<ApplicantSpeciality>(e =>
        {
            e.HasOne(x => x.Applicant)
                .WithMany(x => x.ApplicantSpecialities)
                .HasForeignKey(x => x.ApplicantId);
            e.HasOne(x => x.Speciality)
                .WithMany()
                .HasForeignKey(x => x.SpecialityId);
        });
    }

    public static void AddToServices(IServiceCollection services, IConfiguration configuration,
        IHostEnvironment environment)
    {
        services.AddPooledDbContextFactory<AdmissionCommitteeDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("AdmissionCommittee");
            options.MakeNpgsqlOptions(
                connectionString,
                environment.IsDevelopment(),
                "admission_committee_mt",
                typeof(AdmissionCommitteeDbContext).Assembly.FullName);
        });
    }
}