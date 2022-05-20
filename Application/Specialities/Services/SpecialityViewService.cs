using Application.Shared.Input;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Services;

public static class SpecialityViewService
{
    public static async Task<List<ValueRadioItem<long>>> GetSpecialitiesAsync(
        this ISpecialitiesContext context)
    {
        var specialities = (await context.Speciality.OrderBy(x => x.Code).ThenBy(x => x.Name)
                .AsNoTracking()
                .ToListAsync())
            .Select(x => new ValueRadioItem<long>($"{x.Code} {x.Name}", x.Id))
            .ToList();
        return specialities;
    }
}