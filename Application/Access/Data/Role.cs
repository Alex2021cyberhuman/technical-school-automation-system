using Microsoft.AspNetCore.Identity;

namespace Application.Access.Data;

public class Role : IdentityRole<long>
{
    public Role()
    {
    }

    public Role(string roleName) : base(roleName)
    {
    }
}