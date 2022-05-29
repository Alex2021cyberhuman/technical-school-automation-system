using System.ComponentModel.DataAnnotations;
using Application.Common.Helpers;
using Microsoft.AspNetCore.Identity;

namespace Application.Access.Data;

public class User : IdentityUser<long>
{
    public string FullName => NameExtensions.GetFullName(FamilyName, FirstName, SurName);

    public string Initials => NameExtensions.GetInitials(FamilyName, FirstName, SurName);

    [MaxLength(200)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string? SurName { get; set; }

    // public DateTime Activated { get; set; } = DateTime.UtcNow;

    public string Profile { get; set; } = string.Empty;

    public List<UserRole> UserRoles { get; set; } = null!;
}