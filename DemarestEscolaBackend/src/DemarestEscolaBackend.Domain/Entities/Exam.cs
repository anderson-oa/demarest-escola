using DemarestEscolaBackend.Domain.Entities.Enum;

namespace DemarestEscolaBackend.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public int StudentClasseId { get; set; }
        public StudentClasse StudentClasse { get; set; }
        public Semester Semester { get; set; }
        public double Grade { get; set; }
    }
}