using MediatR;
using University.Services.Interfaces;

namespace University.Services.ConfirmationEnrollments.Delete;

public class DeleteConfirmationEnrollmentCommandHandler : IRequestHandler<DeleteConfirmationEnrollmentCommand, Unit>
{
    private readonly IConfirmationEnrollmentRepository _repository;
    public DeleteConfirmationEnrollmentCommandHandler(IConfirmationEnrollmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteConfirmationEnrollmentCommand command, CancellationToken token)
    {
        await _repository.Delete(command, token);
        return Unit.Value;
    }
}
