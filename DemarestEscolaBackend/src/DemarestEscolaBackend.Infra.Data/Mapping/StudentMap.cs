using DemarestEscolaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemarestEscolaBackend.Infra.Data.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Surname)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Email)
                   .HasMaxLength(300)
                   .IsRequired();

            builder.Property(x => x.Address)
                   .HasMaxLength(250)
                   .IsRequired();
        }
    }
}