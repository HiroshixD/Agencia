using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Empleado
    {
        private readonly Repositorio<entidades.Empleado> empleado;
        public D_Empleado (Repositorio<entidades.Empleado> empleado)
	    {
            this.empleado = empleado;
	    }


        public void AgregarNuevo(entidades.Empleado modelo)
        {
            empleado.Agregar(modelo);
            empleado.Guardar();
            empleado.Commit();
        }

        public void Modificar(entidades.Empleado modelo)
        {
            empleado.Modificar(modelo);
            empleado.Guardar();
            empleado.Commit();

        }

        public void Eliminar(entidades.Empleado modelo)
        {
            empleado.Eliminar(modelo);
            empleado.Guardar();
            empleado.Commit();
        }

        public object TraerTodo()
        {
            return empleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return empleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            empleado.RollBack();
        }
    }
}
