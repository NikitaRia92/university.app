using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class StudentEntityModel : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.StudentCode);
        builder.Property(x => x.StudentCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.FullNameOfStudent).HasMaxLength(40).IsRequired();
        builder.Property(x => x.FacultyCode).HasMaxLength(5).IsRequired();
        builder.Property(x => x.SpecialtyCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.FormOfEducation).IsRequired();//Enum
        builder.Property(x => x.StudentEnrollmentDate).IsRequired();//DateTime
        builder.Property(x => x.GraduationDate).IsRequired();//DateTime
        builder.Property(x => x.GroupNumber).HasMaxLength(3);
        builder.Property(x => x.TuitionPayment).HasMaxLength(6);
    }
}