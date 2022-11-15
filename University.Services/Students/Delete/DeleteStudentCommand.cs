using MediatR;

namespace University.Services.Students.Delete;

public record DeleteStudentCommand(string StudentCode) : IRequest<Unit>
{
}
