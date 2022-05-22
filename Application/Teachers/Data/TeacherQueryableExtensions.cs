using Application.Data;
using Application.Groups.Data;
using Application.Specialities.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Teachers.Data;

public static class TeacherQueryableExtensions
{
    public static async Task<List<Group>> GetGroupsBySubjectAsync(this MainDbContext context, Subject subject)
    {
        return await context.Group.AsNoTracking()
            .Where(x => x.SpecialityId == subject.SpecialityId)
            .OrderByDescending(x => x.Created)
            .ToListAsync();
    }

    public static async Task<List<Subject>> GetSubjectsWithSpecialitiesAsync(this MainDbContext context)
    {
        return await context.Subject.AsNoTracking()
            .OrderBy(x => x.Code)
            .ThenBy(x => x.Name)
            .Include(x => x.Speciality)
            .ToListAsync();
    }

    public static async Task<List<TeacherLoad>> GetTeacherLoadsAsync(this MainDbContext context, long currentUserId)
    {
        return await context.TeacherLoad.AsNoTracking()
            .Include(x => x.Group)
            .Include(x => x.Subject)
            .OrderByDescending(x => x.Created)
            .Where(x => x.TeacherId == currentUserId)
            .ToListAsync();
    }

    public static async Task<List<ProofreadingTeacherLoad>> GetProofreadingTeacherLoadsAsync(this MainDbContext context,
        long currentUserId)
    {
        return await context.ProofreadingTeacherLoad.AsNoTracking()
            .Include(x => x.TeacherLoad)
            .ThenInclude(x => x.Group)
            .Include(x => x.TeacherLoad)
            .ThenInclude(x => x.Subject)
            .OrderByDescending(x => x.Created)
            .Where(x => x.TeacherLoad.TeacherId == currentUserId)
            .ToListAsync();
    }
}