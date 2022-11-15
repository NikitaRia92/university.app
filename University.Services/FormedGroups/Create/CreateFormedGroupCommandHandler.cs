using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.FormedGroups.Create;

public class CreateFormedGroupCommandHandler : IRequestHandler<CreateFormedGroupCommand, FormedGroup>
{
    private readonly IFormedGroupRepository _repository;
    public CreateFormedGroupCommandHandler(IFormedGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<FormedGroup> Handle(CreateFormedGroupCommand command, CancellationToken token)
    {

        return await _repository.Create(command, token);
    }
}
