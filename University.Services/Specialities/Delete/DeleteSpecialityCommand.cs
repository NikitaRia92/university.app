using MediatR;

namespace University.Services.Specialities.Delete;

public record DeleteSpecialityCommand(string Code) : IRequest<Unit>
{
}
