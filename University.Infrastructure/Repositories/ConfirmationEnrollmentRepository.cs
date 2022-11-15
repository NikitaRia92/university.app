using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.ConfirmationEnrollments.Create;
using University.Services.ConfirmationEnrollments.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.ConfirmationEnrollments.Update;

namespace University.Infrastructure.Repositories;

public class ConfirmationEnrollmentRepository : IConfirmationEnrollmentRepository
{
    private readonly ApplicationContext _context;
    public ConfirmationEnrollmentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<ConfirmationEnrollment> Create(CreateConfirmationEnrollmentCommand command, CancellationToken token)
    {
        //var tempStatement = _context.Statements.FirstOrDefault(x => x.Confirmation == false);


        var confirmationEnrollment = new ConfirmationEnrollment()
        //{
        //    ApplicantCode = tempStatement.ApplicantCode,
        //    FullNameOfApplicant = tempStatement.FullNameOfApplicant,
        //    ApplicationNumber = command.ApplicationNubmer,
        //    DateSubmissionApplication = command.DateSubmissionApplication
        //};
        {
            ApplicantCode = command.ApplicantCode,
            ApplicationNumber = command.ApplicationNubmer,
            FullNameOfApplicant = command.FullNameOfApplicant,
            DateSubmissionApplication = command.DateSubmissionApplication
        };
        _context.ConfirmationEnrollments.Add(confirmationEnrollment);
        await _context.SaveChangesAsync(token);
        return confirmationEnrollment;
    }

    public async Task<IReadOnlyCollection<ConfirmationEnrollment>> GetAll(CancellationToken token)
    {
        return await _context.ConfirmationEnrollments.ToListAsync(token);
    }

    public async Task<ConfirmationEnrollment> Update(UpdateConfirmationEnrollmentCommand command, CancellationToken token)
    {
        var confirmationEnrollment = await _context.ConfirmationEnrollments.FindAsync(command.ApplicantCode);

        if (confirmationEnrollment != null)
        {
            confirmationEnrollment.ApplicationNumber = command.ApplicationNumber;
            confirmationEnrollment.FullNameOfApplicant = command.FullNameOfApplicant;
            confirmationEnrollment.DateSubmissionApplication = command.DateSubmissionApplication;

            _context.ConfirmationEnrollments.Update(confirmationEnrollment);
            await _context.SaveChangesAsync(token);
            return confirmationEnrollment;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }

    public async Task Delete(DeleteConfirmationEnrollmentCommand command, CancellationToken token)
    {
        var confirmationEnrollment = await _context.ConfirmationEnrollments.FindAsync(command.ApplicantCode);
        if(confirmationEnrollment != null)
        {
            _context.ConfirmationEnrollments.Remove(confirmationEnrollment);
            await _context.SaveChangesAsync(token);
        }
    }

    

    
}

