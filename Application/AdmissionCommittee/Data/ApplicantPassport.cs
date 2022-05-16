using System.ComponentModel.DataAnnotations;

namespace Application.AdmissionCommittee.Data;

public class ApplicantPassport
{
    [MaxLength(20)] public string Serial { get; set; } = string.Empty;

    [MaxLength(20)] public string Number { get; set; } = string.Empty;

    [MaxLength(2000)] public string Issuer { get; set; } = string.Empty;

    [MaxLength(20)] public string IssuerCode { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public DateTime IssueDate { get; set; }
}