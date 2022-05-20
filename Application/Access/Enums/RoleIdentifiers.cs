namespace Application.Access.Enums;

public static class RoleIdentifiers
{
    public const string Administrator = "Administrator";

    public const string Director = "Director";

    public const string AdmissionCommitteeMember = "AdmissionCommitteeMember";

    public static readonly IReadOnlyList<string> Roles = new[]
    {
        Administrator,
        Director,
        AdmissionCommitteeMember
    };
}