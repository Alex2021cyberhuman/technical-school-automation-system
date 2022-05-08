using System.ComponentModel.DataAnnotations;
using Application.Common.Enums;

namespace Application.Specialities.Data;

public class Speciality
{
    public long Id { get; set; }

    [Required] [MaxLength(150)] public string Name { get; set; } = string.Empty;

    [Required] [MaxLength(20)] public string Code { get; set; } = string.Empty;
    
    public EntranceTestType? EntranceTest { get; set; }
}