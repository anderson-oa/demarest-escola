using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Domain.Interfaces.Services;

namespace DemarestEscolaBackend.Domain.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
    }
}