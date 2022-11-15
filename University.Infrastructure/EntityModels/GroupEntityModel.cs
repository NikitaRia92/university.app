using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;

namespace University.Infrastructure.EntityModels;

public class GroupEntityModel : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.GroupNumber).HasMaxLength(1).IsRequired();
        builder.Property(x => x.CourceNumber).HasMaxLength(1).IsRequired();
        builder.Property(x => x.FacultyCode).HasMaxLength(5).IsRequired();
        builder.Property(x => x.SpecialtyCode).HasMaxLength(8).IsRequired();
    }
}
