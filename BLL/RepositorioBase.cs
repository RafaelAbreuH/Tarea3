using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tarea3.DAL;

namespace Tarea3.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto db;

        public RepositorioBase()
        {
            db = new Contexto();
        }

        public bool Guardar(T entity)
        {
            bool paso = false;


            try
            {
                if (db.Set<T>().Add(entity) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public bool Modificar(T entity)
        {
            bool paso = false;


            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }
        public T Buscar(int id)
        {
            T entity;


            try
            {
                entity = db.Set<T>().Find(id);

            }
            catch (Exception)
            {
                throw;
            }


            return entity;
        }
        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> lista = new List<T>();


            try
            {
                lista = db.Set<T>().Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }


            return lista;

        }
        public bool Eliminar(int id)
        {
            bool paso = false;


            try
            {
                T entity = this.Buscar(id);
                if (entity is null)
                    return false;

                db.Entry(entity).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public void Dispose()
        {
            db.Dispose();
        }

    }
}
