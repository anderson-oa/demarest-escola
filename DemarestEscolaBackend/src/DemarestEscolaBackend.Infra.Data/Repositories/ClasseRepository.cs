using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Context;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class ClasseRepository : BaseRepository<Classe>, IClasseRepository
    {
        public ClasseRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}