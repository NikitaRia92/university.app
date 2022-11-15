using University.Domain.Enums;

namespace University.Domain.Models;

public class Student
{
    public string StudentCode { get; set; }
    public string FullNameOfStudent { get; set; }
    public string FacultyCode { get; set; }
    public string SpecialtyCode { get; set; }
    public int GroupNumber { get; set; }
    public FormOfEducation FormOfEducation { get; set; }
    public int TuitionPayment { get; set; }
    public DateTime StudentEnrollmentDate { get; set; }
    public DateTime GraduationDate { get; set; }
}
