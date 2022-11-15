using MediatR;
using University.Domain.Models;

namespace University.Services.Statements.GetList;

public record GetListStatementQuery : IRequest<IReadOnlyCollection<Statement>>
{
}
