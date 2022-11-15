using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Specialities.Update;

public class UpdateSpecialityCommandHandler : IRequestHandler<UpdateSpecialityCommand, Speciality>
{
    private readonly ISpecialityRepository _repository;
    public UpdateSpecialityCommandHandler(ISpecialityRepository repository)
    {
        _repository = repository;
    }

    public async Task<Speciality> Handle(UpdateSpecialityCommand command, CancellationToken token)
    {
        return await _repository.Update(command, token);
    }
}
