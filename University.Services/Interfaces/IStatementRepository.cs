using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using University.Domain.Models;
using University.Services.ExcelFileProcessing;
using University.Services.Statements.AddFromFile;
using University.Services.Statements.Create;
using University.Services.Statements.Delete;
using University.Services.Statements.Update;

namespace University.Services.Interfaces;

public interface IStatementRepository
{
    Task <Statement> Create(CreateStatementCommand command, CancellationToken token);
    Task <IReadOnlyCollection<Statement>> GetAll (CancellationToken token);
    Task<Statement> Update(UpdateStatementCommand command, CancellationToken token);
    Task Delete (DeleteStatementCommand command, CancellationToken token);
    Task<IReadOnlyCollection<InvalidRowModel>> Import (AddListStatementCommand file, CancellationToken token);
}
