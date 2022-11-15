using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.ConfirmationEnrollments.GetList;

public class GetListConfirmationEnrollmentQueryHandler : IRequestHandler<GetListConfirmationEnrollmentQuery
    , IReadOnlyCollection<ConfirmationEnrollment>>
{
    private readonly IConfirmationEnrollmentRepository _confirmation;
    public GetListConfirmationEnrollmentQueryHandler(IConfirmationEnrollmentRepository confirmation)
    {
        _confirmation = confirmation;
    }
    public async Task<IReadOnlyCollection<ConfirmationEnrollment>> Handle(GetListConfirmationEnrollmentQuery request, CancellationToken token)
    {
        return await _confirmation.GetAll(token);
    }
}
