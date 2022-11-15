using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Statements.Update;

public class UpdateStatementCommandHandler : IRequestHandler<UpdateStatementCommand, Statement>
{
    private readonly IStatementRepository _repository;
    public UpdateStatementCommandHandler(IStatementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Statement> Handle(UpdateStatementCommand command, CancellationToken token)
    {
        return await _repository.Update(command, token);
    }
}
