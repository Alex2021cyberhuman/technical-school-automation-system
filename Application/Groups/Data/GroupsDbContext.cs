using Application.AdmissionCommittee.Data;
using Application.Common.Data;
using Application.Specialities.Data;
using Application.Specialities.Services;
using Microsoft.EntityFrameworkCore;

namespace Application.Groups.Data;

public class GroupsDbContext : DbContext, ISpecialitiesContext
{
    protected GroupsDbContext()
    {
    }

    public GroupsDbContext(DbContextOptions<GroupsDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Student => Set<Student>();

    public DbSet<Group> Group => Set<Group>();

    public DbSet<Speciality> Speciality => Set<Speciality>();

    public DbSet<Applicant> Applicant => Set<Applicant>();

    public DbSet<ApplicantSpeciality> ApplicantSpeciality => Set<ApplicantSpeciality>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupsDbContext).Assembly);
        modelBuilder.BuildAdmissionCommitteeModel();
        modelBuilder.Entity<Speciality>().ToTable("speciality", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<Applicant>().ToTable("applicant", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<ApplicantSpeciality>().ToTable("applicant_speciality", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasMany(x => x.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId);
        });
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasOne(x => x.Applicant)
                .WithOne(x => x.Student)
                .HasForeignKey<Student>(x => x.ApplicantId);
        });
    }

    public static void AddToServices(IServiceCollection services, IConfiguration configuration,
        IHostEnvironment environment)
    {
        services.AddPooledDbContextFactory<GroupsDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Groups");
            options.MakeNpgsqlOptions(
                connectionString,
                environment.IsDevelopment(),
                "groups_mt",
                typeof(GroupsDbContext).Assembly.FullName);
        });
    }
}