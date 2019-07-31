using DemarestEscolaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemarestEscolaBackend.Infra.Data.Mapping
{
    public class StudentClasseMap : IEntityTypeConfiguration<StudentClasse>
    {
        public void Configure(EntityTypeBuilder<StudentClasse> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Classe)
                   .WithMany(x => x.Students)
                   .HasForeignKey(x => x.ClasseId);

            builder.HasOne(x => x.Student)
                   .WithMany(x => x.Classes)
                   .HasForeignKey(x => x.StudentId);
        }
    }
}