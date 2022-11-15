using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.Faculties.Create;
using University.Services.Faculties.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.Faculties.Update;

namespace University.Infrastructure.Repositories;

public class FacultyRepository : IFacultyRepository
{
    private readonly ApplicationContext _context;
    public FacultyRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<Faculty> Create(CreateFacultyCommand command, CancellationToken token)
    {
        var faculty = new Faculty()
        {
            Code = command.Code,
            Name = command.Name,
            ShortName = command.ShortName
        };
        _context.Faculties.Add(faculty);
        await _context.SaveChangesAsync(token);
        return faculty;
    }


    public async Task<IReadOnlyCollection<Faculty>> GetAll(CancellationToken token)
    {
        return await _context.Faculties.ToListAsync(token);
    }


    public async Task<Faculty> Update(UpdateFacultyCommand command, CancellationToken token)
    {

        var faculty = await _context.Faculties.FindAsync(command.Code);
        
        if(faculty != null)
        {
            (faculty.Name, faculty.ShortName) = (command.Name, command.ShortName);
            _context.Faculties.Update(faculty);
            await _context.SaveChangesAsync(token);
            return faculty;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }


    public async Task Delete(DeleteFacultyCommand command, CancellationToken token)
    {
        var faculty = await _context.Faculties.FindAsync(command.Code);
        if (faculty != null)
        {
            _context.Faculties.Remove(faculty);
            await _context.SaveChangesAsync(token);
        }
    }

    
}
