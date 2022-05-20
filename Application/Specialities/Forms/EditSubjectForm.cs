using Application.Specialities.Data;

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
            Semesters = subject.Semesters.Select(x => new SemesterForm { Number = x.Number, Hours = x.Hours })
                .ToList()
        };
        return form;
    }

    public void ToSubject(Subject subject)
    {
        subject.Name = Name;
        subject.Code = Code;
        subject.Semesters = subject.Semesters.Select(x => new Semester { Number = x.Number, Hours = x.Hours })
            .ToList();
    }
}