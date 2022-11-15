
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class SpecialityEntityModel : IEntityTypeConfiguration<Speciality>
{
    public void Configure(EntityTypeBuilder<Speciality> builder)
    {
        builder.HasKey(x => x.Code);
        builder.Property(x => x.Code).HasMaxLength(8).IsRequired();
        builder.Property(x => x.ShortName).HasMaxLength(6).IsRequired();
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x => x.LevelsOfStudyAtTheUniversity).HasConversion<char>(p => (char)p, p => (LevelsOfStudyAtTheUniversity)(int)p).IsRequired();
        builder.Property(x => x.MinimumPassingScore).HasMaxLength(3).IsRequired();
        builder.Property(x => x.Price).HasMaxLength(6).IsRequired();
        builder.Property(x => x.NumberOfSeats).HasMaxLength(2).IsRequired();
        builder.Property(x => x.NumberOfFreeSeats).HasMaxLength(3).IsRequired();
    }
}
