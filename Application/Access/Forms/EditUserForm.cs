using System.ComponentModel.DataAnnotations;
using Application.Common.Data;

namespace Application.Access.Forms;

public class EditUserForm
{
    [MyRequired] [Display(Name = "Логин")] public string Login { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; } = string.Empty;

    [Compare(nameof(Password), ErrorMessageResourceName = "CompareAttribute_MustMatch",
        ErrorMessageResourceType = typeof(Resources.Resource))]
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

    public bool Lockout { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public string Profile { get; set; } = string.Empty;

    public bool LockoutForever { get; set; }
}