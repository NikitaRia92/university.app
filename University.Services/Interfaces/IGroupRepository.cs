using University.Domain.Models;
using University.Services.Groups.Create;
using University.Services.Groups.Delete;
using University.Services.Groups.Update;

namespace University.Services.Interfaces;

public interface IGroupRepository
{
    Task<Group> Create(CreateGroupCommand command, CancellationToken token);
    Task<IReadOnlyCollection<Group>> GetAll(CancellationToken token);
    Task<Group> Update(UpdateGroupCommand command, CancellationToken token);
    Task Delete(DeleteGroupCommand command, CancellationToken token);
    

}
