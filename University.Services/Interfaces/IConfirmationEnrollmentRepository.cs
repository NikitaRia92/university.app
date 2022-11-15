using University.Domain.Models;
using University.Services.ConfirmationEnrollments.Create;
using University.Services.ConfirmationEnrollments.Delete;
using University.Services.ConfirmationEnrollments.Update;

namespace University.Services.Interfaces;

public interface IConfirmationEnrollmentRepository
{
    Task<ConfirmationEnrollment> Create(CreateConfirmationEnrollmentCommand command, CancellationToken token);
    Task<IReadOnlyCollection<ConfirmationEnrollment>> GetAll(CancellationToken token);
    Task<ConfirmationEnrollment> Update(UpdateConfirmationEnrollmentCommand command, CancellationToken token);
    Task Delete (DeleteConfirmationEnrollmentCommand command, CancellationToken token);
}
