using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Context;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class ExamRepository : BaseRepository<Exam>, IExamRepository
    {
        public ExamRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}