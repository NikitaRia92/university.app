using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Specialities.Create;

public class CreateSpecialityCommandHandler : IRequestHandler<CreateSpecialityCommand, Speciality>
{
    private readonly ISpecialityRepository _repository;
    public CreateSpecialityCommandHandler(ISpecialityRepository repository)
    {
        _repository = repository;
    }

    public async Task<Speciality> Handle(CreateSpecialityCommand command, CancellationToken token)
    {

        return await _repository.Create(command, token);
    }
}
