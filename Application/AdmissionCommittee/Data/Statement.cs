using System.ComponentModel.DataAnnotations;

namespace Application.AdmissionCommittee.Data;

public class Statement
{
    [Required] public long Size { get; set; }

    [Required] public string Name { get; set; } = string.Empty;
}