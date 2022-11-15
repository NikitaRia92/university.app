using MediatR;
using University.Services.Interfaces;

namespace University.Services.Students.Delete;

public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
{
    private readonly IStudentRepository _repository;
    public DeleteStudentCommandHandler(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteStudentCommand command, CancellationToken token)
    {
        await _repository.Delete(command, token);
        return Unit.Value;
    }
}
