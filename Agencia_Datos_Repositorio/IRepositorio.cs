using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Datos_Repositorio
{
    public interface IRepositorio<T> where T: class
    {
        IQueryable<T> AsQueryable();
        IEnumerable<T> TraerTodo();
        IEnumerable<T> Buscar(Expression<Func<T,bool>> predicado);
        T TraerUno(Expression<Func<T, bool>> predicado);
        T TraerUnoPorId(int id);
        void Agregar(T modelo);
        void Modificar(T modelo);
        void Eliminar(T modelo);
        void Guardar();
        void Commit();
        void RollBack();
    }
}
