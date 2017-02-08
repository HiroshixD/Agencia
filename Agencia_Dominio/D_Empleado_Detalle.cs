using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Empleado_Detalle
    {
        private readonly Repositorio<entidades.Empleado_Detalle> empleado_detalle;
        public D_Empleado_Detalle (Repositorio<entidades.Empleado_Detalle> empleado_detalle)
	    {
            this.empleado_detalle = empleado_detalle;
	    }


        public void AgregarNuevo(entidades.Empleado_Detalle modelo)
        {
            empleado_detalle.Agregar(modelo);
            empleado_detalle.Guardar();
            empleado_detalle.Commit();
        }

        public void Modificar(entidades.Empleado_Detalle modelo)
        {
            empleado_detalle.Modificar(modelo);
            empleado_detalle.Guardar();
            empleado_detalle.Commit();

        }

        public void Eliminar(entidades.Empleado_Detalle modelo)
        {
            empleado_detalle.Eliminar(modelo);
            empleado_detalle.Guardar();
            empleado_detalle.Commit();
        }

        public object TraerTodo()
        {
            return empleado_detalle.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return empleado_detalle.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            empleado_detalle.RollBack();
        }
    }
}
