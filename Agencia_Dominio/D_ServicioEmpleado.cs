using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_ServicioEmpleado
    {
        private readonly Repositorio<entidades.ServicioEmpleado> servicioempleado;
        public D_ServicioEmpleado (Repositorio<entidades.ServicioEmpleado> servicioempleado)
	    {
            this.servicioempleado = servicioempleado;
	    }


        public void AgregarNuevo(entidades.ServicioEmpleado modelo)
        {
            servicioempleado.Agregar(modelo);
            servicioempleado.Guardar();
            servicioempleado.Commit();
        }

        public void Modificar(entidades.ServicioEmpleado modelo)
        {
            servicioempleado.Modificar(modelo);
            servicioempleado.Guardar();
            servicioempleado.Commit();

        }

        public void Eliminar(entidades.ServicioEmpleado modelo)
        {
            servicioempleado.Eliminar(modelo);
            servicioempleado.Guardar();
            servicioempleado.Commit();
        }

        public object TraerTodo()
        {
            return servicioempleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return servicioempleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            servicioempleado.RollBack();
        }
    }
}
