using System.Text.RegularExpressions;
using Application.Common.Services;
using Application.Teachers.Data;
using Microsoft.Extensions.Localization;

namespace Application.Teachers.Services.ProofreadingTeacherLoadVacancies;

public class ProofreadingTeacherLoadVacanciesCreator
{
    private readonly MonthsService _monthsService;
    private readonly IStringLocalizer _stringLocalizer;
    private readonly IConfiguration _configuration;
    
    public ProofreadingTeacherLoadVacanciesCreator(MonthsService monthsService, IStringLocalizer stringLocalizer, IConfiguration configuration)
    {
        _monthsService = monthsService;
        _stringLocalizer = stringLocalizer;
        _configuration = configuration;
    }

    public async Task<string> CreatePackageAsync(int month,
        int year,
        string teacherFamilyName,
        IEnumerable<ProofreadingTeacherLoad> proofreadingTeacherLoads)
    {
        var monthName = _monthsService.GetName(month);
        var model = new ProofreadingTeacherLoadVacanciesModel
        {
            Year = year,
            Month = monthName,
            Items = proofreadingTeacherLoads.Select(x => new ProofreadingTeacherLoadVacanciesModel.ItemModel()
            {
                GroupName = x.TeacherLoad.Group.Name,
                SubjectName = x.TeacherLoad.Subject.Name,
                Hours = x.TotalHours,
                Kind = _stringLocalizer[x.TeacherLoad.Kind.ToString()],
                TeacherFamilyName = teacherFamilyName
            }).ToList()
        };
        var fileName =
            $"Вычитка_Часов_Преподавания_{Regex.Replace(teacherFamilyName.Trim(), @"\s", string.Empty)}_За_{monthName}_{year}_г_{Path.GetRandomFileName()}.xlsx";
        var basePath = _configuration["AdmissionCommittee:ProofreadingTeacherLoadVacanciesPath"];
        var fullFileName = Path.Combine(basePath, fileName);
        var table = new GeneratedProofreadingTeacherLoadVacanciesTable(model);
        var size = await table.CreateAsync(fullFileName);
        return fileName;
    }
}