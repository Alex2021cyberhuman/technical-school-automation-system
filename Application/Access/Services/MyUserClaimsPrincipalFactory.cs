using System.Security.Claims;
using Application.Access.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Application.Access.Services;

public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<User, Role>
{
    public MyUserClaimsPrincipalFactory(UserManager<User> userManager, RoleManager<Role> roleManager,
        IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
    {
        var identity = await base.GenerateClaimsAsync(user);
        if (!string.IsNullOrWhiteSpace(user.FullName))
            identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FullName));

        // identity.AddClaim(new Claim(MyClaimTypes.Activated, user.Activated.Ticks.ToString()));
        return identity;
    }
}