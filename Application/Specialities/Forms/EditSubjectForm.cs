using Application.Shared.Input;
using Application.Specialities.Data;
using Application.Teachers.Components;
using Application.Teachers.Forms;

namespace Application.Specialities.Forms;

public class EditSubjectForm
{
    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public List<SemesterForm> Semesters { get; set; } = new();

    public static EditSubjectForm FromSubject(Subject subject)
    {
        var form = new EditSubjectForm
        {
            Name = subject.Name,
            Code = subject.Code,
            Semesters = subject.Semesters.ToSemesterForms()
        };
        return form;
    }

    public void ToSubject(Subject subject)
    {
        subject.Name = Name;
        subject.Code = Code;
        subject.Semesters = Semesters.ToSemesters();
    }
}