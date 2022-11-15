using MediatR;
using University.Domain.Models;

namespace University.Services.ConfirmationEnrollments.Update;

public record UpdateConfirmationEnrollmentCommand(string ApplicantCode, string FullNameOfApplicant
    , int ApplicationNumber, DateTime DateSubmissionApplication) : IRequest<ConfirmationEnrollment>
{
}
