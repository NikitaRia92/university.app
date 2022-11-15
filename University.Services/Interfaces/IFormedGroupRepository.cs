using University.Domain.Models;
using University.Services.FormedGroups.Create;
using University.Services.FormedGroups.Delete;
using University.Services.FormedGroups.Update;

namespace University.Services.Interfaces;

public interface IFormedGroupRepository
{
    Task <FormedGroup> Create(CreateFormedGroupCommand command, CancellationToken token);
    Task <IReadOnlyCollection<FormedGroup>> GetAll(CancellationToken token);
    Task<FormedGroup> Update(UpdateFormedGroupCommand command, CancellationToken token);
    Task Delete(DeleteFormedGroupCommand command, CancellationToken token);
}
