using University.Domain.Models;
using University.Services.Faculties.Create;
using University.Services.Faculties.Delete;
using University.Services.Faculties.Update;

namespace University.Services.Interfaces;

public interface IFacultyRepository
{
    Task<Faculty> Create (CreateFacultyCommand command, CancellationToken token);
    Task<IReadOnlyCollection<Faculty>> GetAll (CancellationToken token);
    Task<Faculty> Update(UpdateFacultyCommand command, CancellationToken token);
    Task Delete (DeleteFacultyCommand command, CancellationToken token);
}
