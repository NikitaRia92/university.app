using MediatR;

namespace University.Services.ConfirmationEnrollments.Delete;

public record DeleteConfirmationEnrollmentCommand(string ApplicantCode) : IRequest<Unit> 
{

}
