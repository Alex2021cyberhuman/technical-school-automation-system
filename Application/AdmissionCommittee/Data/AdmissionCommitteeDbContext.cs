using Application.Common.Data;
using Application.Specialities.Data;
using Application.Specialities.Services;
using Microsoft.EntityFrameworkCore;

namespace Application.AdmissionCommittee.Data;

public class AdmissionCommitteeDbContext : DbContext, ISpecialitiesContext
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
        modelBuilder.BuildAdmissionCommitteeModel();
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