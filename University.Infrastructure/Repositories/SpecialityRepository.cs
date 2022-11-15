using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.Specialities.Create;
using University.Services.Specialities.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.Specialities.Update;

namespace University.Infrastructure.Repositories;

public class SpecialityRepository : ISpecialityRepository
{
    private readonly ApplicationContext _context;
    public SpecialityRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<Speciality> Create(CreateSpecialityCommand command, CancellationToken token)
    {
        var speciality = new Speciality()
        {
            Code = command.Code,
            Name = command.Name,
            ShortName = command.ShortName,
            NumberOfSeats = command.NumberOfSeats,
            NumberOfFreeSeats = command.NumberOfFreeSeats,
            MinimumPassingScore = command.MinimumPassingScore,
            LevelsOfStudyAtTheUniversity = command.LevelsOfStudyAtTheUniversity,
            Price = command.Price
        };
        _context.Specialities.Add(speciality);
        await _context.SaveChangesAsync(token);
        return speciality;
    }

    public async Task<IReadOnlyCollection<Speciality>> GetAll(CancellationToken token)
    {
        return await _context.Specialities.ToListAsync(token);
    }

    public async Task<Speciality> Update(UpdateSpecialityCommand command, CancellationToken token)
    {
        var speciality = await _context.Specialities.FindAsync(command.Code);

        if(speciality != null)
        {
            speciality.Name = command.Name;
            speciality.ShortName = command.ShortName;
            speciality.Price = command.Price;
            speciality.MinimumPassingScore = command.MinimumPassingScore;
            speciality.LevelsOfStudyAtTheUniversity = command.LevelsOfStudyAtTheUniversity;
            speciality.NumberOfFreeSeats = command.NumberOfFreeSeats;
            speciality.NumberOfSeats = command.NumberOfSeats;

            _context.Specialities.Update(speciality);
            await _context.SaveChangesAsync(token);
            return speciality;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }
    public async Task Delete(DeleteSpecialityCommand command, CancellationToken token)
    {
        var speciality = await _context.Specialities.FindAsync(command.Code);
        if(speciality != null)
        {
            _context.Specialities.Remove(speciality);
            await _context.SaveChangesAsync(token);
        }
    }

    
}
