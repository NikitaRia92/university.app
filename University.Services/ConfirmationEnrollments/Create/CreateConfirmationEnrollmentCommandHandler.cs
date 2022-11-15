using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.ConfirmationEnrollments.Create;

public class CreateConfirmationEnrollmentCommandHandler : IRequestHandler<CreateConfirmationEnrollmentCommand
    , ConfirmationEnrollment>
{
    private readonly IConfirmationEnrollmentRepository _repository;
    public CreateConfirmationEnrollmentCommandHandler(IConfirmationEnrollmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<ConfirmationEnrollment> Handle(CreateConfirmationEnrollmentCommand request
        , CancellationToken cancellationToken)
    {

        return await _repository.Create(request, cancellationToken);
    }
}
