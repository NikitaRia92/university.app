using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Statements.Create;

public class CreateStatementCommandHandler : IRequestHandler<CreateStatementCommand, Statement>
{
    private readonly IStatementRepository _repository;
    public CreateStatementCommandHandler(IStatementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Statement> Handle(CreateStatementCommand command, CancellationToken token)
    {
        return await _repository.Create(command, token);
    }
}
