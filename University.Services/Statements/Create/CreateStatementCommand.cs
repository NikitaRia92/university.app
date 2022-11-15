using MediatR;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.Statements.Create;

public record CreateStatementCommand(string ApplicantCode, string FullNameOfApplicant
    , string FacultyCode, string SpecialtyCode, bool SchoolCertificat
    , int NumberOfPointsScore, FormOfEducation FormOfEducation, bool Confirmation
    , DateTime DateSubmissionDocuments, DateTime EndDateAcceptanceDocuments) : IRequest<Statement>
{
}
