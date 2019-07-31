using DemarestEscolaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemarestEscolaBackend.Infra.Data.Mapping
{
    public class ExamMap : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.HasOne(x => x.StudentClasse)
                   .WithOne(x => x.Exam);
        }
    }
}