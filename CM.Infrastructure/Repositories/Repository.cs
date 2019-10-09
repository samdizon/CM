using CM.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CM.Infrastructure.Repositories
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> dbSet;

        protected DbContext dbContext;

        public Repository(ApplicationDbContext context)
        {
            dbSet = context.Set<T>();
            dbContext = context;
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
