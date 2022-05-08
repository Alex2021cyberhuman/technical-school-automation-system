using System.ComponentModel.DataAnnotations;
using Application.Specialities.Data;

namespace Application.AdmissionCommittee.Data;

public abstract class ApplicantSpeciality
{
    [Key] public long Id { get; set; }

    [Required] public long ApplicantId { get; set; }

    public Applicant Applicant { get; set; } = null!;

    [Required] public long SpecialityId { get; set; }

    public Speciality Speciality { get; set; } = null!;
}