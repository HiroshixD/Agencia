using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Servicios
    {
        private readonly Repositorio<entidades.Servicios> servicios;
        public D_Servicios (Repositorio<entidades.Servicios> servicios)
	    {
            this.servicios = servicios;
	    }


        public void AgregarNuevo(entidades.Servicios modelo)
        {
            servicios.Agregar(modelo);
            servicios.Guardar();
            servicios.Commit();
        }

        public void Modificar(entidades.Servicios modelo)
        {
            servicios.Modificar(modelo);
            servicios.Guardar();
            servicios.Commit();

        }

        public void Eliminar(entidades.Servicios modelo)
        {
            servicios.Eliminar(modelo);
            servicios.Guardar();
            servicios.Commit();
        }

        public object TraerTodo()
        {
            return servicios.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return servicios.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            servicios.RollBack();
        }
    }
}
