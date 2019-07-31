using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Domain.Interfaces.Services;

namespace DemarestEscolaBackend.Domain.Services
{
    public class ClasseService : IClasseService
    {
        private readonly IClasseRepository _classeRepository;

        public ClasseService(IClasseRepository classeRepository)
        {
            _classeRepository = classeRepository;
        }
    }
}