using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.FormedGroups.Update;

public class UpdateFormedGroupCommannHandler : IRequestHandler<UpdateFormedGroupCommand, FormedGroup>
{
    private readonly IFormedGroupRepository _repository;
    public UpdateFormedGroupCommannHandler(IFormedGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<FormedGroup> Handle(UpdateFormedGroupCommand command, CancellationToken token)
    {
        return await _repository.Update(command, token);
    }
}
