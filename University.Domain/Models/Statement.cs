using University.Domain.Enums;

namespace University.Domain.Models;

public class Statement
{
    public string ApplicantCode { get; set; }
    public string FullNameOfApplicant { get; set; }
    public string FacultyCode { get; set; }
    public string SpecialtyCode { get; set; }
    public bool SchoolCertificat { get; set; }
    public FormOfEducation FormOfEducation { get; set; }
    public int NumberOfPointsScore { get; set; }
    public bool Confirmation { get; set; }
    public DateTime DateSubmissionDocuments { get; set; }
    public DateTime EndDateAcceptanceDocuments { get; set; }
}
