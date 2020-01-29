using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
    interface IRepository<T> where T : class
    {
        public bool Guardar(T entity);
        public bool Modificar(T entity);
        public bool Eliminar(int Id);
        public T Buscar(int Id);
        public List<T> GetList(Expression<Func<T, bool>> expression);

    }
}
