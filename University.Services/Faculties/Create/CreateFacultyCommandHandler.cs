using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Faculties.Create;

public class CreateFacultyCommandHandler : IRequestHandler<CreateFacultyCommand, Faculty>
{
    private readonly IFacultyRepository _facultyRepository;
    public CreateFacultyCommandHandler(IFacultyRepository facultyRepository)
    {
        _facultyRepository = facultyRepository;
    }

    public async Task<Faculty> Handle(CreateFacultyCommand request, CancellationToken cancellationToken)
    {

        return await _facultyRepository.Create(request, cancellationToken);
    }
}
