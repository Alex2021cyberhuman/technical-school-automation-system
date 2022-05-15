using Application.Shared.Input;
using Application.Specialities.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Services;

public static class SpecialityViewService
{
    public static async Task<List<MyInputRadioGroup<long>.ValueRadioItem>> GetSpecialitiesAsync(this ISpecialitiesContext context)
    {
        var specialities = (await context.Speciality.OrderBy(x => x.Code).ThenBy(x => x.Name)
                .AsNoTracking()
                .ToListAsync())
            .Select(x => new MyInputRadioGroup<long>.ValueRadioItem($"{x.Code} {x.Name}", x.Id))
            .ToList();
        return specialities;
    }
}