using Application.Groups.Data;

namespace Application.AdmissionCommittee.Services.EnrolledStudentsTable;

public class EnrolledStudentsTableModel
{
    public EnrolledStudentsTableModel(Group group, IEnumerable<Student> students)
    {
        GroupName = group.Name;
        Students = students
            .OrderBy(x => x.FamilyName)
            .ThenBy(x => x.FirstName)
            .ThenBy(x => x.SurName)
            .Select((x) => new StudentModel(x.Id.ToString(), x.FullName)).ToList();
    }

    public string GroupName { get; set; }

    public List<StudentModel> Students { get; set; }

    public class StudentModel
    {
        public StudentModel(string number, string fullName)
        {
            Number = number;
            FullName = fullName;
        }

        public string Number { get; set; }

        public string FullName { get; set; }
    }
}