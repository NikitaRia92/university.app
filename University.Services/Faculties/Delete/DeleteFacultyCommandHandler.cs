using MediatR;
using University.Services.Interfaces;

namespace University.Services.Faculties.Delete;

public class DeleteFacultyCommandHandler : IRequestHandler<DeleteFacultyCommand, Unit>
{
    private readonly IFacultyRepository _repository;
    public DeleteFacultyCommandHandler(IFacultyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteFacultyCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request, cancellationToken);
        return Unit.Value;
    }
}
