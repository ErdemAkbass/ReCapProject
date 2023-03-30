
using core.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace core.dataAccess
{
    public interface IEntityRepository<T> where T :class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null  );

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void delete(T entity);

        void Update(T entity);
    }
}
