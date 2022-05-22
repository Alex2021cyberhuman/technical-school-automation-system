using Application.Access.Data;
using Application.Groups.Data;
using Application.Specialities.Data;

namespace Application.Teachers.Data;

public class TeacherLoad
{
    public long Id { get; set; }

    public long SubjectId { get; set; }

    public Subject Subject { get; set; } = null!;

    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public long TeacherId { get; set; }

    public User Teacher { get; set; } = null!;

    public TeacherLoadKind Kind { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public List<Semester> Semesters { get; set; } = null!;

    public List<ProofreadingTeacherLoad> ProofreadingTeacherLoads { get; set; } = new();
}