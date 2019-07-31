using DemarestEscolaBackend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DemarestEscolaBackend.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected MainContext Db;
        protected DbSet<TEntity> DbSet;

        public BaseRepository(MainContext mainContext)
        {
            Db = mainContext;
            DbSet = mainContext.Set<TEntity>();
        }
    }
}