using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Groups.Create;

public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, Group>
{
    private readonly IGroupRepository _repository;
    public CreateGroupCommandHandler(IGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<Group> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        return await _repository.Create(request, cancellationToken);
    }
}
