using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Access.Forms;

public class LoginForm
{
    [Required] [Display(Name = "Логин")] public string Login { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Логин")]
    public string Password { get; set; } = string.Empty;
}