using DemarestEscolaBackend.Domain.Entities;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
    }
}