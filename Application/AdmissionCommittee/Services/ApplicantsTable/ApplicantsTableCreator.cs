namespace Application.AdmissionCommittee.Services.ApplicantsTable;

public class ApplicantsTableCreator
{
    public async Task<long> CreatePackageAsync(string filePath, ApplicantsTableModel model)
    {
        var generatedApplicantsTable = new GeneratedApplicantsTable(model);
        return await generatedApplicantsTable.CreateAsync(filePath);
    }
}