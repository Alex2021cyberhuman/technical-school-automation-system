using System.Text.RegularExpressions;
using Application.Common.Enums;
using Application.Common.Services;
using Application.Teachers.Data;
using Application.Teachers.Services.ProofreadingTeacherLoadVacancies;
using Microsoft.Extensions.Localization;

namespace Application.Teachers.Services.MonthProofreadingTeacherLoads;

public class MonthProofreadingTeacherLoadsCreator
{
    private readonly MonthsService _monthsService;
    private readonly IStringLocalizer _stringLocalizer;
    private readonly IConfiguration _configuration;

    public MonthProofreadingTeacherLoadsCreator(MonthsService monthsService, IStringLocalizer stringLocalizer,
        IConfiguration configuration)
    {
        _monthsService = monthsService;
        _stringLocalizer = stringLocalizer;
        _configuration = configuration;
    }

    public async Task<string> CreatePackageAsync(int month,
        int year,
        string teacher,
        IEnumerable<ProofreadingTeacherLoad> proofreadingTeacherLoads)
    {
        var monthName = _monthsService.GetName(month);
        var daysInMonthCount = DateTime.DaysInMonth(year, month);
        var model = new MonthProofreadingTeacherLoadsModel
        {
            Year = year,
            Month = monthName,
            DaysInMonthCount = daysInMonthCount,
            TeacherFullName = teacher,
            Items = proofreadingTeacherLoads.Select(x => new MonthProofreadingTeacherLoadsModel.ItemModel
            {
                GroupName = x.TeacherLoad.Group.Name,
                SubjectName = x.TeacherLoad.Subject.Name,
                Days = x.Days.OrderBy(proofreadingTeacherDay => proofreadingTeacherDay.Number)
                    .Take(daysInMonthCount)
                    .Select(proofreadingTeacherDay => new MonthProofreadingTeacherLoadsModel.ItemDayModel { Hours = proofreadingTeacherDay.Hours }),
                FinanceEnrollmentType = x.TeacherLoad.Group.FinanceEnrolmentType == FinanceEnrolmentType.Budget
                    ? "б"
                    : "в/б",
                TotalHours = x.TotalHours
            }).ToList()
        };
        var fileName =
            $"Вычитка_Часов_Преподавания_{Regex.Replace(teacher.Trim(), @"\s", string.Empty)}_За_{monthName}_{year}_г_{Path.GetRandomFileName()}.xlsx";
        var basePath = _configuration["AdmissionCommittee:ProofreadingTeacherLoadVacanciesPath"];
        var fullFileName = Path.Combine(basePath, fileName);
        var table = new GeneratedMonthProofreadingTeacherLoadsTable(model);
        var size = await table.CreateAsync(fullFileName);
        return fileName;
    }
}