using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Statements.GetList;

public class GetListStatementQueryHandler : IRequestHandler<GetListStatementQuery, IReadOnlyCollection<Statement>>
{
    private readonly IStatementRepository _repository;
    public GetListStatementQueryHandler(IStatementRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<Statement>> Handle(GetListStatementQuery request, CancellationToken token)
    {
        return await _repository.GetAll(token);
    }
}
