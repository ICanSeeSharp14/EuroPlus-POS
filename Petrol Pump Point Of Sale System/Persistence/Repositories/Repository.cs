using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;
using Petrol_Pump_Point_Of_Sale_System.Models;


namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {

        protected readonly DatabaseContext Context;

        public Repository(DatabaseContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(int pageIndex, int pageSize = 50)
        {
            return Context.Set<TEntity>()

                .OrderBy(e => e.Id)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public TEntity GetById(int id)
        {
            return  Context.Set<TEntity>().Find(id);
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {

            return Context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
           Context.Set<TEntity>().Add(entity);
        }


        public void Add(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }
       
      
       
        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }


        public int Commit()
        {
           return Context.SaveChanges();
        }

        public int Count()
        {
            return Context.Set<TEntity>().Count();
        }

        public void Remove(TEntity entity)
        {
           Context.Set<TEntity>().Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
           
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        { 
            return await Context.Set<TEntity>().SingleOrDefaultAsync(predicate);
            
        }
        public TEntity Execute(string functionName, params object[] parameters)
        {
            var method = Context.GetType().GetMethod(functionName);
            if (method != null)
            {
                return (TEntity) method.Invoke(Context, parameters);
            }

            return null;

        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }   
}