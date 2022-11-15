using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Groups.Update;

public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, Group>
{
    private readonly IGroupRepository _repository;
    public UpdateGroupCommandHandler(IGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<Group> Handle(UpdateGroupCommand command, CancellationToken token)
    {
        return await _repository.Update(command, token);
    }
}
