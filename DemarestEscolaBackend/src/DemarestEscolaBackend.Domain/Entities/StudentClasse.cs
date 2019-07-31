namespace DemarestEscolaBackend.Domain.Entities
{
    public class StudentClasse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public Exam Exam { get; set; }
    }
}