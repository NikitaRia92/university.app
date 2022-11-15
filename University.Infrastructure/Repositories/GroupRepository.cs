using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.Groups.Delete;
using University.Services.Groups.Create;
using Microsoft.EntityFrameworkCore;
using University.Services.Groups.Update;

namespace University.Infrastructure.Repositories;

public class GroupRepository : IGroupRepository
{
    private readonly ApplicationContext _context;
    public GroupRepository(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<Group> Create(CreateGroupCommand command, CancellationToken token)
    {
        var group = new Group 
        {      
            CourceNumber = command.CourceNumber, 
            FacultyCode = command.FacultyCode, 
            GroupNumber = command.GroupNumber, 
            SpecialtyCode = command.SpecialtyCode
        };
        _context.Groups.Add(group);
        await _context.SaveChangesAsync(token);
        return group;
    }

    public async Task<IReadOnlyCollection<Group>> GetAll(CancellationToken token)
    {
        return await _context.Groups.ToListAsync(token);
    }

    public async Task<Group> Update(UpdateGroupCommand command, CancellationToken token)
    {
        var group = await _context.Groups.FindAsync(command.Id);

        if(group != null)
        {
            group.GroupNumber = command.GroupNumber;
            group.CourceNumber = command.CourceNumber;
            group.FacultyCode = command.FacultyCode;
            group.SpecialtyCode = command.SpecialtyCode;

            _context.Groups.Update(group);
            await _context.SaveChangesAsync(token);
            return group;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }


    public async Task Delete(DeleteGroupCommand command, CancellationToken token)
    {
        var group = await _context.Groups.FindAsync(command.Id);

        if(group != null)
        {
            _context.Groups.Remove(group);
            await _context.SaveChangesAsync(token);
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }

    

    
}