using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
    public interface IRepository<T> where T : class
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(int id);
        Task<IList<T>> ListAsync();
        IList<T> List(Expression<Func<T, bool>> expression);

    }
}
