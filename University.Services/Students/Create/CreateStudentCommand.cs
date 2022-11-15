using MediatR;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.Students.Create;

public record CreateStudentCommand(string StudentCode, string FullNameOfStudent
    , string FacultyCode, string SpecialtyCode, int GroupNumber, FormOfEducation FormOfEducation
    , int TuitionPayment, DateTime StudentEnrollmentDate, DateTime GraduationDate) : IRequest<Student>
{
}
