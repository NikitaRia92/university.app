using MediatR;
using University.Services.Interfaces;

namespace University.Services.FormedGroups.Delete;

public class DeleteFormedGroupCommandHandler : IRequestHandler<DeleteFormedGroupCommand, Unit>
{
    private readonly IFormedGroupRepository _repository;
    public DeleteFormedGroupCommandHandler(IFormedGroupRepository repository)
    {
        _repository = repository;
    }

    public Task<Unit> Handle(DeleteFormedGroupCommand command, CancellationToken token)
    {
        _repository.Delete(command, token);
        return Unit.Task; 
    }
}
