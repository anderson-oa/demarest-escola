using DemarestEscolaBackend.Domain.Entities;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
    }
}