using MediatR;
using University.Services.Interfaces;

namespace University.Services.Specialities.Delete;

public class DeleteSpecialityCommandHandler : IRequestHandler<DeleteSpecialityCommand, Unit>
{
    private readonly ISpecialityRepository _repository;
    public DeleteSpecialityCommandHandler(ISpecialityRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteSpecialityCommand command, CancellationToken token)
    {
        await _repository.Delete(command, token);
        return Unit.Value;
    }
}
