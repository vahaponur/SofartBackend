using Microsoft.EntityFrameworkCore;
using SofartBackend.DataAccess.EfCore.Contracts;
using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        readonly SofartDbContext dbContext;
        public Repository(SofartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Add(T entity)
        {

            dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();

        }

        public async Task AddAll(IEnumerable<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
            await dbContext.SaveChangesAsync();

        }

        public async Task Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();

        }

        public async Task DeleteAll(IEnumerable<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
            await dbContext.SaveChangesAsync();

        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {

            return await dbContext.Set<T>().FirstOrDefaultAsync(filter);
     
        }


        public async Task <ICollection<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
           return await dbContext.Set<T>().Where(filter).ToListAsync();
    
        }

        public async Task <T>  GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
             dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
