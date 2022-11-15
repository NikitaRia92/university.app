using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class ConfirmationEnrollmentEntityModel : IEntityTypeConfiguration<ConfirmationEnrollment>
{
    public void Configure(EntityTypeBuilder<ConfirmationEnrollment> builder)
    {
        builder.HasKey(x=> x.ApplicantCode);
        builder.Property(x => x.ApplicantCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.FullNameOfApplicant).HasMaxLength(40).IsRequired();
        builder.Property(x => x.ApplicationNumber).HasMaxLength(6).IsRequired();
        builder.Property(x => x.DateSubmissionApplication).HasDefaultValue(DateTime.Now);
    }
}