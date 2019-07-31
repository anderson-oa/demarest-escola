using DemarestEscolaBackend.Domain.Entities;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Interfaces.Services
{
    public interface IExamService
    {
        void Create(Exam exam);

        IEnumerable<dynamic> GetAll();
    }
}