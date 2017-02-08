using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Entidades;

namespace Agencia_Datos_Repositorio
{
    public class Repositorio<T>:IRepositorio<T>, IDisposable where T: class
    {
        private readonly AgenciaContext _db;
        public Repositorio(AgenciaContext _db)
        {
            this._db = _db;
        }
        public IQueryable<T> AsQueryable()
        {
            return _db.Set<T>().AsQueryable();
        }

        public IEnumerable<T> TraerTodo()
        {
            return _db.Set<T>();
        }

        public IEnumerable<T> Buscar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _db.Set<T>().Where(predicado);
        }

        public T TraerUno(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _db.Set<T>().Where(predicado).FirstOrDefault();
        }

        public T TraerUnoPorId(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Agregar(T modelo)
        {
            if (_db.Entry<T>(modelo).State != System.Data.Entity.EntityState.Detached)
                _db.Entry<T>(modelo).State = System.Data.Entity.EntityState.Added;
            else
                _db.Set<T>().Add(modelo);
        }

        public void Modificar(T modelo)
        {
            if (_db.Entry<T>(modelo).State == System.Data.Entity.EntityState.Detached)
                _db.Set<T>().Attach(modelo);
            _db.Entry<T>(modelo).State = System.Data.Entity.EntityState.Modified;
        }

        public void Eliminar(T modelo)
        {
            if (_db.Entry<T>(modelo).State == System.Data.Entity.EntityState.Detached)
                _db.Set<T>().Attach(modelo);
            _db.Entry<T>(modelo).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Guardar()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            return;
        }


        public void Commit()
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                transaction.Commit();
            }
        }

        public void RollBack()
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                transaction.Rollback();
            }
        }
    }
}
