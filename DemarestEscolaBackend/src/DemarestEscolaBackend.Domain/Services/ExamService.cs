using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public void Create(Exam exam)
        {
            _examRepository.Create(exam);
        }

        public IEnumerable<dynamic> GetAll()
        {
            return _examRepository.GetAll();
        }
    }
}