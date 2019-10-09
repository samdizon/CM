using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace CM.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        IQueryable<T> GetAll();

        IQueryable<T> Search(Expression<Func<T, bool>> expression);
    }
}
