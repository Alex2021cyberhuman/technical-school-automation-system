using System.ComponentModel.DataAnnotations;
using Application.Common.Data;

namespace Application.Access.Forms;

public class CreateUserForm
{
    [MyRequired] [Display(Name = "Логин")] public string Login { get; set; } = string.Empty;

    [MyRequired]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; } = string.Empty;

    [MyRequired]
    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердите пароль")]
    public string ConfirmPassword { get; set; } = string.Empty;

    [Display(Name = "Роли")]
    [MyRequired]
    [MyMinLength(1)]
    public List<string> RoleNames { get; set; } = new();

    [Display(Name = "Электронная почта")] public string Email { get; set; } = string.Empty;

    [Display(Name = "Фамилия")]
    [MyMaxLength(200)]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Имя")]
    [MyMaxLength(200)]
    public string FamilyName { get; set; } = string.Empty;

    [Display(Name = "Отчество")]
    [MyMaxLength(200)]
    public string SurName { get; set; } = string.Empty;

    public string Profile { get; set; } = string.Empty;
}