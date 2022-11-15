using MediatR;

namespace University.Services.Faculties.Delete;

public record DeleteFacultyCommand(string Code) : IRequest<Unit>
{
}
