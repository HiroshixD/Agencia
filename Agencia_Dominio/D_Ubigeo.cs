using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;


namespace Agencia_Dominio
{
    public class D_Ubigeo
    {
        private readonly Repositorio<entidades.Ubigeo> ubigeo;
        public D_Ubigeo (Repositorio<entidades.Ubigeo> ubigeo)
	    {
            this.ubigeo = ubigeo;
	    }


        public void AgregarNuevo(entidades.Ubigeo modelo)
        {
            ubigeo.Agregar(modelo);
            ubigeo.Guardar();
            ubigeo.Commit();
        }

        public void Modificar(entidades.Ubigeo modelo)
        {
            ubigeo.Modificar(modelo);
            ubigeo.Guardar();
            ubigeo.Commit();

        }

        public void Eliminar(entidades.Ubigeo modelo)
        {
            ubigeo.Eliminar(modelo);
            ubigeo.Guardar();
            ubigeo.Commit();
        }

        public object TraerTodo()
        {
            return ubigeo.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return ubigeo.TraerUnoPorId(id);
        }


        public object TraerUno(string id)
        {
            var data = ubigeo.TraerUno(x => x.IdUbigeo == id);
            return data;
        }

        public void Rollback()
        {
            ubigeo.RollBack();
        }
    }
}
