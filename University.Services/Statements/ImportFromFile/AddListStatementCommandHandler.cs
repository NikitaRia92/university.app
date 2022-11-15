using MediatR;
using University.Domain.Models;
using University.Services.ExcelFileProcessing;
using University.Services.Interfaces;

namespace University.Services.Statements.AddFromFile;

public class AddListStatementCommandHandler : IRequestHandler<AddListStatementCommand, IReadOnlyCollection<InvalidRowModel>>
{
    IStatementRepository _repository;
    public AddListStatementCommandHandler(IStatementRepository repository)
    {
        _repository = repository;
    }


    public async Task<IReadOnlyCollection<InvalidRowModel>> Handle(AddListStatementCommand command, CancellationToken token)
    {
        return await _repository.Import(command, token);
    }
}
