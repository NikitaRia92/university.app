using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Groups.GetList;

public class GetListGroupQueryHandler : IRequestHandler<GetListGroupQuery, IReadOnlyCollection<Group>>
{
    private readonly IGroupRepository _repository;
    public GetListGroupQueryHandler(IGroupRepository repository)
    {
        this._repository = repository;
    }

    public async Task<IReadOnlyCollection<Group>> Handle(GetListGroupQuery request, CancellationToken token)
    {
        return await _repository.GetAll(token);
    }
}
