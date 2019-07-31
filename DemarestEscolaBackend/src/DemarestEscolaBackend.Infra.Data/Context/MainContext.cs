using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DemarestEscolaBackend.Infra.Data.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentClasse> StudentClasses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClasseMap());
            modelBuilder.ApplyConfiguration(new ExamMap());
            modelBuilder.ApplyConfiguration(new StudentClasseMap());
            modelBuilder.ApplyConfiguration(new StudentMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}