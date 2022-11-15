using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Specialities.GetList;

public class GetListSpecialityQueryHandler : IRequestHandler<GetListSpecialityQuery, IReadOnlyCollection<Speciality>>
{
    private readonly ISpecialityRepository _repository;
    public GetListSpecialityQueryHandler(ISpecialityRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<Speciality>> Handle(GetListSpecialityQuery request, CancellationToken token)
    {
        return await _repository.GetAll(token);
    }
}
