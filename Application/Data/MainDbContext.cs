using Application.Access.Data;
using Application.AdmissionCommittee.Data;
using Application.Common.Data;
using Application.Groups.Data;
using Application.Specialities.Data;
using Application.Specialities.Services;
using Application.Teachers.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public class MainDbContext : DbContext, ISpecialitiesContext
{
    protected MainDbContext()
    {
    }

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
    }

    public DbSet<Speciality> Speciality => Set<Speciality>();

    public DbSet<Subject> Subject => Set<Subject>();

    public DbSet<ProofreadingTeacherDay> ProofreadingTeacherDay => Set<ProofreadingTeacherDay>();

    public DbSet<ProofreadingTeacherLoad> ProofreadingTeacherLoad => Set<ProofreadingTeacherLoad>();

    public DbSet<TeacherLoad> TeacherLoad => Set<TeacherLoad>();

    public DbSet<Student> Student => Set<Student>();

    public DbSet<Group> Group => Set<Group>();

    public DbSet<Applicant> Applicant => Set<Applicant>();

    public DbSet<ApplicantSpeciality> ApplicantSpeciality => Set<ApplicantSpeciality>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Applicant>(e =>
        {
            e.OwnsOne(x => x.Passport);
            e.OwnsOne(x => x.Mother);
            e.OwnsOne(x => x.Father);
            e.OwnsOne(x => x.Statement);
            e.Navigation(x => x.ApplicantSpecialities).AutoInclude();
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasOne(x => x.Applicant)
                .WithOne(x => x.Student)
                .HasForeignKey<Student>(x => x.ApplicantId);
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

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasOne(x => x.Speciality)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.SpecialityId);
            entity.OwnsMany(x => x.Semesters);
        });

        modelBuilder.Entity<TeacherLoad>(entity =>
        {
            entity.HasMany(x => x.ProofreadingTeacherLoads)
                .WithOne(x => x.TeacherLoad)
                .HasForeignKey(x => x.TeacherLoadId);
            entity.HasOne(x => x.Group)
                .WithMany()
                .HasForeignKey(x => x.GroupId);
            entity.HasOne(x => x.Subject)
                .WithMany()
                .HasForeignKey(x => x.SubjectId);
            entity.HasOne(x => x.Teacher)
                .WithMany()
                .HasForeignKey(x => x.TeacherId);
            entity.OwnsMany(x => x.Semesters);
        });

        modelBuilder.Entity<ProofreadingTeacherLoad>(entity =>
        {
            entity.OwnsMany(x => x.Days);
            entity.HasIndex(x => new { x.Year, x.Month });
        });

        ExcludeAccessDbContext(modelBuilder);
    }

    private static void ExcludeAccessDbContext(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("user", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<Role>().ToTable("role", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<IdentityUserClaim<long>>().ToTable("user_claim", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<IdentityRoleClaim<long>>().ToTable("role_claim", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<IdentityUserLogin<long>>(b =>
        {
            b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            b.ToTable("user_login", x => x.ExcludeFromMigrations());
        });
        modelBuilder.Entity<IdentityUserToken<long>>(b =>
        {
            b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            b.ToTable("user_token", x => x.ExcludeFromMigrations());
        });
        modelBuilder.Entity<UserRole>(b =>
        {
            b.HasKey(r => new { r.UserId, r.RoleId });
            b.ToTable("user_role", x => x.ExcludeFromMigrations());
        });
    }

    public static void AddToServices(IServiceCollection services, IConfiguration configuration,
        IHostEnvironment environment)
    {
        services.AddPooledDbContextFactory<MainDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Main");
            options.MakeNpgsqlOptions(
                connectionString,
                environment.IsDevelopment(),
                "main_mt",
                typeof(MainDbContext).Assembly.FullName);
        });
    }
}