using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(MainContext mainContext) : base(mainContext)
        {
        }

        public IEnumerable<Student> GetAll()
        {
            return DbSet.OrderBy(o => o.Name);
        }
    }
}