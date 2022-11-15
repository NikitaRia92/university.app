namespace University.Domain.Models;

public class ConfirmationEnrollment
{
    public string ApplicantCode { get; set; }
    public string FullNameOfApplicant { get; set; }
    public int ApplicationNumber { get; set; }
    public DateTime DateSubmissionApplication { get; set; }
}
