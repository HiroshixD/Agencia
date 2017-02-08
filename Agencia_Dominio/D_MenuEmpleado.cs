using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_MenuEmpleado
    {
        private readonly Repositorio<entidades.MenuEmpleado> menuempleado;
        public D_MenuEmpleado (Repositorio<entidades.MenuEmpleado> menuempleado)
	    {
            this.menuempleado = menuempleado;
	    }


        public void AgregarNuevo(entidades.MenuEmpleado modelo)
        {
            menuempleado.Agregar(modelo);
            menuempleado.Guardar();
            menuempleado.Commit();
        }

        public void Modificar(entidades.MenuEmpleado modelo)
        {
            menuempleado.Modificar(modelo);
            menuempleado.Guardar();
            menuempleado.Commit();

        }

        public void Eliminar(entidades.MenuEmpleado modelo)
        {
            menuempleado.Eliminar(modelo);
            menuempleado.Guardar();
            menuempleado.Commit();
        }

        public object TraerTodo()
        {
            return menuempleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return menuempleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            menuempleado.RollBack();
        }
    }
}
