using MediatR;

namespace University.Services.Groups.Delete;

public record DeleteGroupCommand(int Id) : IRequest<Unit>
{

}
