using MediatR;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.Statements.Update;

public record UpdateStatementCommand(string ApplicantCode, string FullNameOfApplicant, string FacultyCode
    , string SpecialtyCode, bool SchoolCertificat, int NumberOfPointsScore, FormOfEducation FormOfEducation
    , bool Confirmation, DateTime DateSubmissionDocuments
    , DateTime EndDateAcceptanceDocuments) : IRequest<Statement> 

{

}
