using University.Domain.Models;
using University.Services.Specialities.Create;
using University.Services.Specialities.Delete;
using University.Services.Specialities.Update;

namespace University.Services.Interfaces;

public interface ISpecialityRepository
{
    Task<Speciality> Create(CreateSpecialityCommand command, CancellationToken token);
    Task<IReadOnlyCollection<Speciality>> GetAll(CancellationToken token);
    Task<Speciality> Update(UpdateSpecialityCommand command, CancellationToken token);
    Task Delete(DeleteSpecialityCommand command, CancellationToken token);
}
