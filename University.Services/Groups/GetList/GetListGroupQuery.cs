using MediatR;
using University.Domain.Models;

namespace University.Services.Groups.GetList;

public record GetListGroupQuery : IRequest<IReadOnlyCollection<Group>>
{
}
