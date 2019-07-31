using DemarestEscolaBackend.Domain.Entities;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Interfaces.Services
{
    public interface IStudentClasseService
    {
        IEnumerable<StudentClasse> GetByStudent(int studentId);
    }
}