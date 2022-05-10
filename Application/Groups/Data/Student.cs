using System.ComponentModel.DataAnnotations;
using Application.AdmissionCommittee.Data;
using Application.Common.Helpers;

namespace Application.Groups.Data;

public class Student
{
    public long Id { get; set; }

    public string FullName => NameExtensions.GetFullName(FamilyName, FirstName, SurName);

    [MaxLength(200)] [Required] public string FirstName { get; set; } = string.Empty;

    [MaxLength(200)] [Required] public string FamilyName { get; set; } = string.Empty;

    [MaxLength(200)] public string? SurName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Applicant Applicant { get; set; } = null!;

    public long ApplicantId { get; set; }

    public Group Group { get; set; } = null!;

    public long GroupId { get; set; }
}