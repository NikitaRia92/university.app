using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.ConfirmationEnrollments.Update;

public class UpdateConfirmationEnrollmentCommandHandler : IRequestHandler<UpdateConfirmationEnrollmentCommand
    , ConfirmationEnrollment>
{
    private readonly IConfirmationEnrollmentRepository _repository;
    public UpdateConfirmationEnrollmentCommandHandler(IConfirmationEnrollmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<ConfirmationEnrollment> Handle(UpdateConfirmationEnrollmentCommand command, CancellationToken token)
    {
        return await _repository.Update(command, token);
    }
}
