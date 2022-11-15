using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Faculties.GetList;

public class GetListFacultyQueryHandler : IRequestHandler<GetListFacultyQuery, IReadOnlyCollection<Faculty>>
{
    private readonly IFacultyRepository _facultyRepository;
    public GetListFacultyQueryHandler(IFacultyRepository facultyRepository)
    {
        _facultyRepository = facultyRepository;
    }

    public async Task<IReadOnlyCollection<Faculty>> Handle(GetListFacultyQuery request, 
        CancellationToken cancellationToken)
    {
        return await _facultyRepository.GetAll(cancellationToken);
    }

}

