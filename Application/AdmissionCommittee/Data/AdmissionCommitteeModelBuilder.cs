using Application.Specialities.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.AdmissionCommittee.Data;

public static class AdmissionCommitteeModelBuilder
{
    public static void BuildAdmissionCommitteeModel(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Speciality>().ToTable("speciality", x => x.ExcludeFromMigrations());
        modelBuilder.Entity<Subject>().ToTable("subject", x => x.ExcludeFromMigrations());
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
}