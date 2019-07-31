using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public IEnumerable<StudentClasse> Classes { get; set; }
    }
}