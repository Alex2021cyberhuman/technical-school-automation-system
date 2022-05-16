using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.Access.Data;

public class AccessDbContext : IdentityDbContext<User, Role, long, IdentityUserClaim<long>, UserRole,
    IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
{
    public AccessDbContext(DbContextOptions options) : base(options)
    {
    }

    public AccessDbContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>(b =>
        {
            b.HasKey(u => u.Id);
            b.HasIndex(u => u.NormalizedUserName).IsUnique();
            b.HasIndex(u => u.NormalizedEmail);
            b.ToTable("user");
            b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            b.Property(u => u.UserName).HasMaxLength(256);
            b.Property(u => u.NormalizedUserName).HasMaxLength(256);
            b.Property(u => u.Email).HasMaxLength(256);
            b.Property(u => u.NormalizedEmail).HasMaxLength(256);

            b.HasMany<IdentityUserClaim<long>>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
            b.HasMany<IdentityUserLogin<long>>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
            b.HasMany<IdentityUserToken<long>>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
            b.HasMany<UserRole>().WithOne(x => x.User).HasForeignKey(ur => ur.UserId).IsRequired();
        });

        builder.Entity<IdentityUserClaim<long>>(b =>
        {
            b.HasKey(uc => uc.Id);
            b.ToTable("user_claim");
        });

        builder.Entity<IdentityUserLogin<long>>(b =>
        {
            b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            b.ToTable("user_login");
        });

        builder.Entity<IdentityUserToken<long>>(b =>
        {
            b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            b.ToTable("user_token");
        });

        builder.Entity<Role>(b =>
        {
            b.HasKey(r => r.Id);
            b.HasIndex(r => r.NormalizedName).IsUnique();
            b.ToTable("role");
            b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            b.Property(u => u.Name).HasMaxLength(256);
            b.Property(u => u.NormalizedName).HasMaxLength(256);

            b.HasMany<UserRole>().WithOne(x => x.Role).HasForeignKey(ur => ur.RoleId).IsRequired();
            b.HasMany<IdentityRoleClaim<long>>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
        });

        builder.Entity<IdentityRoleClaim<long>>(b =>
        {
            b.HasKey(rc => rc.Id);
            b.ToTable("role_claim");
        });

        builder.Entity<UserRole>(b =>
        {
            b.HasKey(r => new { r.UserId, r.RoleId });
            b.ToTable("user_role");
        });
    }
}