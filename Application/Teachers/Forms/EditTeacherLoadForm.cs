using Application.Groups.Data;
using Application.Shared.Input;
using Application.Specialities.Data;
using Application.Teachers.Components;
using Application.Teachers.Data;

namespace Application.Teachers.Forms;

public class EditTeacherLoadForm
{
    public EditTeacherLoadForm(TeacherLoad teacherLoad)
    {
        Semesters = teacherLoad.Semesters.ToSemesterForms();
        Kind = teacherLoad.Kind;
        Group = teacherLoad.Group;
        Subject = teacherLoad.Subject;
    }

    public List<SemesterForm> Semesters { get; set; }

    public TeacherLoadKind Kind { get; set; }

    public Group Group { get; set; }

    public Subject Subject { get; set; }

    public void ToTeacherLoad(TeacherLoad teacherLoad)
    {
        teacherLoad.GroupId = Group.Id;
        teacherLoad.SubjectId = Subject.Id;
        teacherLoad.Semesters = Semesters.ToSemesters();
        teacherLoad.Kind = Kind;
    }
}