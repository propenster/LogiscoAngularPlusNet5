using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicoStartupEngine.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        void Remove(T entity);
        void Add(T entity);
        T GetById(int Id);
        void Edit(T entity);
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
    }
}
