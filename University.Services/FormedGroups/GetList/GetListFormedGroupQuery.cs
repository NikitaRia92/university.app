using MediatR;
using University.Domain.Models;

namespace University.Services.FormedGroups.GetList;

public record GetListFormedGroupQuery : IRequest<IReadOnlyCollection<FormedGroup>>
{
}
