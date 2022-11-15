using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.FormedGroups.GetList;

public class GetListFormedGroupQueryHandler : IRequestHandler<GetListFormedGroupQuery
    , IReadOnlyCollection<FormedGroup>>
{
    private readonly IFormedGroupRepository _repository;
    public GetListFormedGroupQueryHandler(IFormedGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<FormedGroup>> Handle(GetListFormedGroupQuery request, CancellationToken token)
    {
        return await _repository.GetAll(token);
    }
}
