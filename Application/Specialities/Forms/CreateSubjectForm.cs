using Application.Shared.Input;
using Application.Specialities.Data;
using Application.Teachers.Components;
using Application.Teachers.Forms;

namespace Application.Specialities.Forms;

public class CreateSubjectForm
{
    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public List<SemesterForm> Semesters { get; set; } = SemesterForm.EightZeroHourSemesters;

    public Subject ToSubject(long specialityId)
    {
        var subject = new Subject
        {
            SpecialityId = specialityId,
            Name = Name,
            Code = Code,
            Semesters = Semesters.ToSemesters()
        };
        return subject;
    }
}