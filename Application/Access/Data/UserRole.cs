using Microsoft.AspNetCore.Identity;

namespace Application.Access.Data;

public class UserRole : IdentityUserRole<long>
{
    public override long UserId { get; set; }

    public User User { get; set; } = null!;

    public override long RoleId { get; set; }

    public Role Role { get; set; } = null!;
}