using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.FormedGroups.Create;
using University.Services.FormedGroups.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.FormedGroups.Update;

namespace University.Infrastructure.Repositories;

public class FormedGroupRepository : IFormedGroupRepository
{
    private readonly ApplicationContext _context;
    public FormedGroupRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<FormedGroup> Create(CreateFormedGroupCommand command, CancellationToken token)
    {
        var formedGroup = new FormedGroup()
        {
            SpecialtyCode = command.SpecialtyCode,
            GroupNumber = command.GroupNumber,
            FacultyCode = command.FacultyCode,
            RegistryNumber = command.RegistryNumber,
            NumberOfStudentsInAGroup = command.NumberOfStudentsInAGroup
        };
        _context.FormedGroups.Add(formedGroup);
        await _context.SaveChangesAsync(token);
        return formedGroup;
    }

    public async Task<IReadOnlyCollection<FormedGroup>> GetAll(CancellationToken token)
    {
        return await _context.FormedGroups.ToListAsync(token);
    }

    public async Task<FormedGroup> Update(UpdateFormedGroupCommand command, CancellationToken token)
    {
        var formedGroup = await _context.FormedGroups.FindAsync(command.RegistryNumber);

        if(formedGroup != null)
        {
            formedGroup.SpecialtyCode = command.SpecialtyCode;
            formedGroup.GroupNumber = command.GroupNumber;
            formedGroup.FacultyCode = command.FacultyCode;
            formedGroup.NumberOfStudentsInAGroup = command.NumberOfStudentsInAGroup;

            _context.FormedGroups.Update(formedGroup);
            await _context.SaveChangesAsync(token);
            return formedGroup;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }

    public async Task Delete(DeleteFormedGroupCommand command, CancellationToken token)
    {
        var formedGroup = await _context.FormedGroups.FindAsync(command.GroupNumber);
        if (formedGroup != null)
        {
            _context.FormedGroups.Remove(formedGroup);
            await _context.SaveChangesAsync(token);
        }
    }
}
