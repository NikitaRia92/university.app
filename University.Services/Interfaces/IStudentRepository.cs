using University.Domain.Models;
using University.Services.Statements.Update;
using University.Services.Students.Create;
using University.Services.Students.Delete;
using University.Services.Students.Update;

namespace University.Services.Interfaces;

public interface IStudentRepository
{
    Task<Student> Create(CreateStudentCommand command, CancellationToken token);
    Task<IReadOnlyCollection<Student>> GetAll(CancellationToken token);
    Task<Student> Update(UpdateStudentCommand command, CancellationToken token);
    Task Delete(DeleteStudentCommand command ,CancellationToken token);
}
