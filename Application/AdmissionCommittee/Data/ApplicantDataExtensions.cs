using Application.AdmissionCommittee.Forms;
using Application.Common.Enums;
using Application.Data;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace Application.AdmissionCommittee.Data;

public static class ApplicantDataExtensions
{
    public static async Task<(List<Applicant> items, int totalItems)> LoadApplicantPagesAsync(
        this IDbContextFactory<MainDbContext> dbContextFactory,
        string sortLabel,
        SortDirection sortDirection,
        int page,
        int pageSize,
        ApplicantsTableFilterForm filter)
    {
        await using var context = await dbContextFactory.CreateDbContextAsync();
        var queryable = context.Applicant
            .AsNoTracking();
        queryable = queryable
            .Where(x => x.Submitted.Year == filter.SelectedYear);

        queryable = FilterApplicantsSearchString(queryable, filter.SearchString);

        if (filter.SelectedSpecialityId.HasValue)
            queryable = queryable
                .Where(x => x.ApplicantSpecialities.Any(speciality =>
                    speciality.SpecialityId == filter.SelectedSpecialityId.Value));

        if (filter.SelectedEducationForm.HasValue)
            queryable = queryable.Where(x => x.EducationForm == filter.SelectedEducationForm.Value);

        queryable = filter.SelectedFinanceEnrolmentType switch
        {
            FinanceEnrolmentType.Budget => queryable.Where(x => x.FinanceEducationType == FinanceEducationType.Budget),
            FinanceEnrolmentType.OutOfBudget => queryable.Where(x =>
                x.FinanceEducationType != FinanceEducationType.Budget),
            _ => queryable
        };

        if (filter.SelectedDirectorDecisionType.HasValue)
            queryable = queryable.Where(x => x.DirectorDecision == filter.SelectedDirectorDecisionType);

        var sortedQueryable = queryable.SortApplicantsTable(sortLabel, sortDirection);

        var pagedQueryable = sortedQueryable.Skip(page * pageSize).Take(pageSize);

        var items = await pagedQueryable.ToListAsync();
        var totalItems = items.Count;
        if (items.Count == pageSize) totalItems = await queryable.CountAsync();

        return (items, totalItems);
    }

    public static IQueryable<Applicant> FilterApplicantsSearchString(this IQueryable<Applicant> queryable,
        string? filterSearchString)
    {
        return !string.IsNullOrWhiteSpace(filterSearchString)
            ? queryable
                .Where(x =>
                    EF.Functions.ILike(x.FamilyName + " " + x.FirstName + " " + x.SurName,
                        "%" + filterSearchString + "%"))
            : queryable;
    }

    public static IQueryable<Applicant> SortApplicantsTable(this IQueryable<Applicant> queryable, string sortLabel,
        SortDirection sortDirection)
    {
        queryable = sortLabel switch
        {
            "Id" => queryable.OrderByDirection(sortDirection, x => x.Id),
            "MathRating" => queryable.OrderByDirection(sortDirection, x => x.MathRating),
            "LanguageRating" => queryable.OrderByDirection(sortDirection, x => x.LanguageRating),
            "AverageAttestRating" => queryable.OrderByDirection(sortDirection, x => x.AverageAttestRating),
            "CommonScore" => queryable.OrderByDirection(sortDirection, x => x.CommonScore),
            _ => sortDirection switch
            {
                SortDirection.None => queryable,
                SortDirection.Ascending => queryable.OrderBy(x => x.FamilyName)
                    .ThenBy(x => x.FirstName)
                    .ThenBy(x => x.SurName),
                SortDirection.Descending => queryable.OrderByDescending(x => x.FamilyName)
                    .ThenByDescending(x => x.FirstName)
                    .ThenByDescending(x => x.SurName),
                _ => throw new ArgumentOutOfRangeException(nameof(sortDirection))
            }
        };
        return queryable;
    }
}