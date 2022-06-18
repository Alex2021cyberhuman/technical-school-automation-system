using Application.Common.Data;
using Application.Groups.Data;
using Application.Specialities.Data;
using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public class CreateTeacherLoadForm
{
    public List<SemesterForm> Semesters { get; set; } = SemesterForm.EightZeroHourSemesters;

    public TeacherLoadKind? Kind { get; set; } = TeacherLoadKind.Vacancies;

    [MyRequired] public Group? Group { get; set; }

    [MyRequired] public Subject? Subject { get; set; }

    public TeacherLoad ToTeacherLoad(long teacherId)
    {
        _ = Group ?? throw new NullReferenceException();
        _ = Subject ?? throw new NullReferenceException();
        return new()
        {
            GroupId = Group.Id,
            TeacherId = teacherId,
            SubjectId = Subject.Id,
            Semesters = Semesters.ToSemesters(),
            Kind = Kind!.Value
        };
    }
}