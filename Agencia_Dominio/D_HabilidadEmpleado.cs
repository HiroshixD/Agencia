using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_HabilidadEmpleado
    {
        private readonly Repositorio<entidades.HabilidadEmpleado> habilidadempleado;
        public D_HabilidadEmpleado (Repositorio<entidades.HabilidadEmpleado> habilidadempleado)
	    {
            this.habilidadempleado = habilidadempleado;
	    }


        public void AgregarNuevo(entidades.HabilidadEmpleado modelo)
        {
            habilidadempleado.Agregar(modelo);
            habilidadempleado.Guardar();
            habilidadempleado.Commit();
        }

        public void Modificar(entidades.HabilidadEmpleado modelo)
        {
            habilidadempleado.Modificar(modelo);
            habilidadempleado.Guardar();
            habilidadempleado.Commit();

        }

        public void Eliminar(entidades.HabilidadEmpleado modelo)
        {
            habilidadempleado.Eliminar(modelo);
            habilidadempleado.Guardar();
            habilidadempleado.Commit();
        }

        public object TraerTodo()
        {
            return habilidadempleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return habilidadempleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            habilidadempleado.RollBack();
        }
    }
}
