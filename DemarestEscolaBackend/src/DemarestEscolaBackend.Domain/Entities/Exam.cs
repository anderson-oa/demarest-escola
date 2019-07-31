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

        public Aprovacao GetAprovacao()
        {
            if (Grade >= 7.5) return Aprovacao.Aprovado;
            else if (Grade < 6) return Aprovacao.Reprovado;
            else return Aprovacao.Conselho;
        }
    }
}