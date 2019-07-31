using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class ExamRepository : BaseRepository<Exam>, IExamRepository
    {
        public ExamRepository(MainContext mainContext) : base(mainContext)
        {
        }

        public void Create(Exam exam)
        {
            DbSet.Add(exam);
            Db.SaveChanges();
        }

        public IEnumerable<dynamic> GetAll()
        {
            return DbSet.Include(i => i.StudentClasse.Student)
                        .Include(i => i.StudentClasse.Classe)
                        .GroupBy(g => g.StudentClasse.StudentId, (key, obj) => new
                        {
                            student = obj.FirstOrDefault().StudentClasse.Student,
                            items = obj.Select(x => new
                            {
                                x.Grade,
                                x.Semester,
                                classe = x.StudentClasse.Classe.Name,
                                aprovacao = x.GetAprovacao()
                            })
                        }).OrderBy(o => o.student.Name);
        }
    }
}