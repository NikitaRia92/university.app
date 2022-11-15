using MediatR;
using University.Services.Interfaces;

namespace University.Services.Statements.Delete;

public class DeleteStatementCommandHandler : IRequestHandler<DeleteStatementCommand, Unit>
{
    private readonly IStatementRepository _repository;
    public DeleteStatementCommandHandler(IStatementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteStatementCommand command, CancellationToken token)
    {
        await _repository.Delete(command, token);
        return Unit.Value;
    }
}
