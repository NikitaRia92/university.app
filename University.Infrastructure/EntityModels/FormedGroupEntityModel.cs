using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class FormedGroupEntityModel : IEntityTypeConfiguration<FormedGroup>
{
    public void Configure(EntityTypeBuilder<FormedGroup> builder)
    {
        builder.HasKey(x => x.RegistryNumber);
        builder.Property(x => x.RegistryNumber).HasMaxLength(8).IsRequired();
        builder.Property(x => x.FacultyCode).HasMaxLength(5).IsRequired();
        builder.Property(x => x.SpecialtyCode).HasMaxLength(8).IsRequired();
        builder.Property(x => x.GroupNumber).HasMaxLength(1).IsRequired();
        builder.Property(x => x.NumberOfStudentsInAGroup).HasMaxLength(2).IsRequired();
    }
}
