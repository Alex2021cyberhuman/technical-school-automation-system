using Application.Shared.Input;
using Application.Specialities.Data;

namespace Application.Specialities.Forms;

public class CreateSubjectForm
{
    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public List<SemesterForm> Semesters { get; set; } =
        Enumerable.Range(1, 8).Select(x => new SemesterForm { Number = x, Hours = 0 }).ToList();

    public Subject ToSubject(long specialityId)
    {
        var subject = new Subject
        {
            SpecialityId = specialityId,
            Name = Name,
            Code = Code,
            Semesters = Semesters.Select(x => new Semester { Number = x.Number, Hours = x.Hours }).ToList()
        };
        return subject;
    }
}