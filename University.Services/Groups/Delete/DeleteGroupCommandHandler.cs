using MediatR;
using University.Services.Interfaces;

namespace University.Services.Groups.Delete;

public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand, Unit>
{
    private readonly IGroupRepository _repository;
    public DeleteGroupCommandHandler(IGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteGroupCommand request, CancellationToken token)
    {
        await _repository.Delete(request, token);
        return Unit.Value;
    }
}
