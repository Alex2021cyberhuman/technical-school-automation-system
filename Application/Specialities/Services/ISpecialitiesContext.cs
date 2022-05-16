using Application.Specialities.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Specialities.Services;

public interface ISpecialitiesContext
{
    DbSet<Speciality> Speciality { get; }
}