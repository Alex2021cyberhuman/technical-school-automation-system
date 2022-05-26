using System.ComponentModel.DataAnnotations;
using Application.Common.Data;

namespace Application.Access.Forms;

public class LoginForm
{
    [MyRequired] [Display(Name = "Логин")] public string Login { get; set; } = string.Empty;

    [MyRequired]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; } = string.Empty;
}