using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class StudentClasseRepository : BaseRepository<StudentClasse>, IStudentClasseRepository
    {
        public StudentClasseRepository(MainContext mainContext) : base(mainContext)
        {
        }

        public IEnumerable<StudentClasse> GetByStudent(int studentId)
        {
            return DbSet.Include(i => i.Classe)
                        .Where(x => x.StudentId == studentId)
                        .OrderBy(o => o.Classe.Name);
        }
    }
}