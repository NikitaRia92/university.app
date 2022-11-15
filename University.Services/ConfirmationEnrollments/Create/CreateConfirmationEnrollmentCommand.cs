using MediatR;
using University.Domain.Models;

namespace University.Services.ConfirmationEnrollments.Create;

public record CreateConfirmationEnrollmentCommand(string ApplicantCode, string FullNameOfApplicant,
        int ApplicationNubmer, DateTime DateSubmissionApplication) : IRequest<ConfirmationEnrollment>
{
}
