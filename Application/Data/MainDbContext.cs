using Application.Access.Data;
using Application.AdmissionCommittee.Data;
using Application.Common.Data;
using Application.Groups.Data;
using Application.Schedules.Data;
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

    public DbSet<ClassSchedule> ClassSchedule => Set<ClassSchedule>();

    public DbSet<ClassScheduleReplacement> ClassScheduleReplacement => Set<ClassScheduleReplacement>();

    public DbSet<Cabinet> Cabinet => Set<Cabinet>();

    public DbSet<Schedule> Schedule => Set<Schedule>();

    public DbSet<User> User => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Schedule>(e =>
        {
            e.HasOne(x => x.Group)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Schedule>(x => x.GroupId);
            e.HasMany(x => x.ClassSchedule)
                .WithOne(x => x.Schedule)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.ScheduleId);
        });

        modelBuilder.Entity<ClassSchedule>(e =>
        {
            e.HasOne(x => x.Cabinet)
                .WithMany()
                .HasForeignKey(x => x.CabinetId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            e.HasOne(x => x.Subject)
                .WithMany()
                .HasForeignKey(x => x.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ClassScheduleReplacement>(e =>
        {
            e.HasOne(x => x.Cabinet)
                .WithMany()
                .HasForeignKey(x => x.CabinetId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            e.HasOne(x => x.Subject)
                .WithMany()
                .HasForeignKey(x => x.SubjectId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.ClassSchedule)
                .WithMany()
                .HasForeignKey(x => x.ClassScheduleId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.Schedule)
                .WithMany()
                .HasForeignKey(x => x.ScheduleId)
                .OnDelete(DeleteBehavior.Cascade);
        });

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
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Student>(x => x.ApplicantId);
        });

        modelBuilder.Entity<ApplicantSpeciality>(e =>
        {
            e.HasOne(x => x.Applicant)
                .WithMany(x => x.ApplicantSpecialities)
                .HasForeignKey(x => x.ApplicantId)
                .OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.Speciality)
                .WithMany()
                .HasForeignKey(x => x.SpecialityId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasMany(x => x.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.Property(x => x.Graduation).HasComputedColumnSql(@"make_date(""graduation_year"", 8, 31)", true);
            entity.Property(x => x.Enrollment).HasComputedColumnSql(@"make_date(""enrollment_year"", 9, 1)", true);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasOne(x => x.Applicant)
                .WithOne(x => x.Student)
                .HasForeignKey<Student>(x => x.ApplicantId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasOne(x => x.Speciality)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.SpecialityId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.OwnsMany(x => x.Semesters);
        });

        modelBuilder.Entity<TeacherLoad>(entity =>
        {
            entity.HasOne(x => x.Group)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.GroupId);
            entity.HasOne(x => x.Subject)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.SubjectId);
            entity.HasOne(x => x.Teacher)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.TeacherId);
            entity.OwnsMany(x => x.Semesters);
        });

        modelBuilder.Entity<ProofreadingTeacherLoad>(entity =>
        {
            entity.HasOne(x => x.TeacherLoad)
                .WithMany(x => x.ProofreadingTeacherLoads)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.TeacherLoadId);
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