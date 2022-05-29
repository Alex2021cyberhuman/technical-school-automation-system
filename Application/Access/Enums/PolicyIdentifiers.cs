using System.Security.Claims;

namespace Application.Access.Enums;

public static class PolicyIdentifiers
{
    public const string AdmissionCommittee = "AdmissionCommittee";

    public const string Administrators = "Administrators";

    public const string Teachers = "Teacher";

    public const string Administration = "Administration";

    public const string ScheduleManagers = "ScheduleManagers";

    public const string Default = "Default";

    public static readonly IReadOnlyDictionary<string, string[]> PolicyRoles = new Dictionary<string, string[]>
    {
        {
            AdmissionCommittee, new[]
            {
                RoleIdentifiers.Administrator,
                RoleIdentifiers.Director,
                RoleIdentifiers.AssociateDirector,
                RoleIdentifiers.AdmissionCommitteeMember
            }
        },
        {
            Administrators, new[]
            {
                RoleIdentifiers.Administrator
            }
        },
        {
            Administration, new[]
            {
                RoleIdentifiers.Administrator,
                RoleIdentifiers.Director,
                RoleIdentifiers.AssociateDirector
            }
        },
        {
            Teachers, new[]
            {
                RoleIdentifiers.Teacher
            }
        },
        {
            ScheduleManagers, new[]
            {
                RoleIdentifiers.Administrator,
                RoleIdentifiers.ScheduleManager
            }
        }
    };

    public static bool IsInPolicy(this ClaimsPrincipal claimsPrincipal, string policy)
    {
        return PolicyRoles[policy].Any(claimsPrincipal.IsInRole);
    }
}