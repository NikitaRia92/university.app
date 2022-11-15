using MediatR;

namespace University.Services.FormedGroups.Delete;

public record DeleteFormedGroupCommand(int GroupNumber) : IRequest<Unit>
{

}
