using MediatR;

namespace University.Services.Statements.Delete;

public record DeleteStatementCommand(string ApplicantCode) : IRequest<Unit>
{
}
