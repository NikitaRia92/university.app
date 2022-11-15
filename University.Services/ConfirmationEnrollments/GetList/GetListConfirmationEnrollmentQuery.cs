using MediatR;
using University.Domain.Models;

namespace University.Services.ConfirmationEnrollments.GetList;

public record GetListConfirmationEnrollmentQuery : IRequest<IReadOnlyCollection<ConfirmationEnrollment>>
{

}
