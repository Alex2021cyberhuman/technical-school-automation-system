namespace Application.Access.Enums;

public static class RoleIdentifiers
{
    public const string Administrator = "Administrator";

    public const string Director = "Director";

    public const string AdmissionCommitteeMember = "AdmissionCommitteeMember";

    public const string Teacher = "Teacher";

    public const string AssociateDirector = "AssociateDirector";

    public static readonly IReadOnlyList<string> Roles = new[]
    {
        Administrator,
        Director,
        AdmissionCommitteeMember,
        AssociateDirector,
        Teacher
    };
}