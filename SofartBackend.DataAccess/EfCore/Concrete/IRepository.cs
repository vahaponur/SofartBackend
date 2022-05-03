using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;


namespace SofartBackend.DataAccess.EfCore.Concrete
{
    internal interface IRepository<T> where T:class,IEntity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Predicate<T> filter);
        ICollection<T> GetAll(Predicate<ICollection<T>> filter);

    }
}
