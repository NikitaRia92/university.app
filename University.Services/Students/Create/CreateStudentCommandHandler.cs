using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Students.Create;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
{
    private readonly IStudentRepository _repository;
    public CreateStudentCommandHandler(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Student> Handle(CreateStudentCommand command, CancellationToken token)
    {

        return await _repository.Create(command, token);
    }
}
