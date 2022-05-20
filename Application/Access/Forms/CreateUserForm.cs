using System.ComponentModel.DataAnnotations;

namespace Application.Access.Forms;

public class CreateUserForm
{
    [Required] [Display(Name = "Логин")] public string Login { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердите пароль")]
    public string ConfirmPassword { get; set; } = string.Empty;

    [Display(Name = "Роли")]
    [Required]
    [MinLength(1)]
    public List<string> RoleNames { get; set; } = new();

    [Display(Name = "Электронная почта")] public string Email { get; set; } = string.Empty;

    [Display(Name = "Фамилия")]
    [MaxLength(200)]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Имя")]
    [MaxLength(200)]
    public string FamilyName { get; set; } = string.Empty;

    [Display(Name = "Отчество")]
    [MaxLength(200)]
    public string SurName { get; set; } = string.Empty;
}