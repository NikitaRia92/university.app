using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class StatementEntityModel : IEntityTypeConfiguration<Statement>
{
    public void Configure(EntityTypeBuilder<Statement> builder)
    {
        builder.HasKey(x=> x.ApplicantCode);
        builder.HasIndex(x => x.ApplicantCode).IsUnique();
        builder.Property(x => x.ApplicantCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.FullNameOfApplicant).HasMaxLength(40).IsRequired();
        builder.Property(x => x.FacultyCode).HasMaxLength(5).IsRequired();
        builder.Property(x => x.SpecialtyCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.SchoolCertificat).IsRequired();
        builder.Property(x => x.NumberOfPointsScore).HasMaxLength(3).IsRequired();
        builder.Property(x => x.FormOfEducation).IsRequired();//enum
        builder.Property(x => x.Confirmation).HasDefaultValue(false).IsRequired();
        builder.Property(x => x.DateSubmissionDocuments).IsRequired();//DateTime
        builder.Property(x => x.EndDateAcceptanceDocuments).IsRequired();//DateTime
    }
}
