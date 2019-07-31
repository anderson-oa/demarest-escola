using DemarestEscolaBackend.Domain.Entities;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Interfaces.Repositories
{
    public interface IExamRepository
    {
        void Create(Exam exam);

        IEnumerable<dynamic> GetAll();
    }
}