namespace Application.AdmissionCommittee.Services.StatementDocument;

public class StatementDocumentCreator
{
    public async Task<long> CreatePackageAsync(string filePath, StatementDocumentModel model)
    {
        var generatedDocument = new GeneratedStatementDocument(model);
        return await generatedDocument.CreateAsync(filePath);
    }
}