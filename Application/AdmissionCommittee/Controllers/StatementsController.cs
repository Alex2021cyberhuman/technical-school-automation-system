using Application.AdmissionCommittee.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application.AdmissionCommittee.Controllers;

[Route("/applicants/{id:long}/statement")]
public class StatementsController : ControllerBase
{
    private const string DocxMediaType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
    
    private readonly IDbContextFactory<AdmissionCommitteeDbContext> _dbContextFactory;
    private readonly IConfiguration _configuration;
    
    public StatementsController(IDbContextFactory<AdmissionCommitteeDbContext> dbContextFactory, IConfiguration configuration)
    {
        _dbContextFactory = dbContextFactory;
        _configuration = configuration;
    }

    [HttpGet]
    public async Task<IActionResult> DownloadStatement(long id, CancellationToken cancellationToken)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        var applicant = await context.Applicant.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        if (applicant is null || applicant.Statement is null)
        {
            return NotFound();
        }

        var statement = applicant.Statement;
        var basePath = _configuration["AdmissionCommittee:StatementPath"];
        var fullFileName = Path.Combine(basePath, statement.Name);
        var fileStream = System.IO.File.OpenRead(fullFileName);
        return File(fileStream, DocxMediaType, statement.Name);
    }
}