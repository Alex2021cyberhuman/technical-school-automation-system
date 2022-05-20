using System.ComponentModel.DataAnnotations;
using Application.Common.Helpers;
using Microsoft.AspNetCore.Identity;

namespace Application.Access.Data;

public class User : IdentityUser<long>
{
    public string FullName => NameExtensions.GetFullName(FamilyName, FirstName, SurName);

    [MaxLength(200)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string? SurName { get; set; }

    public List<UserRole> UserRoles { get; set; } = null!;
}