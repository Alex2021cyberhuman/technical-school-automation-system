namespace Application.AdmissionCommittee.Services.EnrolledStudentsTable;

public class EnrolledStudentsTableCreator
{
    public async Task<long> CreatePackageAsync(string filePath, EnrolledStudentsTableModel model)
    {
        var generatedDocument = new GeneratedEnrolledStudentsTable(model);
        return await generatedDocument.CreateAsync(filePath);
    }
}