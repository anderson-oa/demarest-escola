using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Entities
{
    public class Classe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DaysAttended { get; set; }
        public IEnumerable<StudentClasse> Students { get; set; }
    }
}