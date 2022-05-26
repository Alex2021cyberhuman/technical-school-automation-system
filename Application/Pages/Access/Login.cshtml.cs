using System.ComponentModel.DataAnnotations;
using Application.Access.Data;
using Application.Common.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application.Pages.Access;

public class LoginModel : PageModel
{
    private readonly SignInManager<User> _signInManager;
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(SignInManager<User> signInManager, ILogger<LoginModel> logger)
    {
        _signInManager = signInManager;
        _logger = logger;
    }

    [BindProperty] public InputModel Input { get; set; } = null!;

    public IList<AuthenticationScheme> ExternalLogins { get; set; } = null!;

    public string ReturnUrl { get; set; } = null!;

    [TempData] public string ErrorMessage { get; set; } = null!;

    public class InputModel
    {
        [MyRequired] [Display(Name = "Логин")] public string Login { get; set; } = null!;

        [MyRequired]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = null!;

        [Display(Name = "Не выходить")] public bool RememberMe { get; set; }
    }

    public async Task OnGetAsync(string? returnUrl = null)
    {
        if (!string.IsNullOrEmpty(ErrorMessage)) ModelState.AddModelError(string.Empty, ErrorMessage);

        returnUrl ??= Url.Content("~/");

        // Clear the existing external cookie to ensure a clean login process
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        ReturnUrl = returnUrl;
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        if (!ModelState.IsValid) return Page();
        var result = await _signInManager.PasswordSignInAsync(Input.Login, Input.Password, Input.RememberMe, true);
        if (result.Succeeded)
        {
            _logger.LogInformation("User logged in");
            return LocalRedirect(returnUrl);
        }

        if (result.RequiresTwoFactor)
            // TODO: Сделать 2х факторную авторизацию
            throw new NotImplementedException();
        if (result.IsLockedOut)
        {
            _logger.LogWarning("User account locked out");
            return RedirectToPage("./Lockout");
        }

        ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
        return Page();
    }
}