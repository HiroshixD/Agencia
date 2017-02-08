using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Habilidades
    {
        private readonly Repositorio<entidades.Habilidades> habilidades;
        public D_Habilidades (Repositorio<entidades.Habilidades> habilidades)
	    {
            this.habilidades = habilidades;
	    }


        public void AgregarNuevo(entidades.Habilidades modelo)
        {
            habilidades.Agregar(modelo);
            habilidades.Guardar();
            habilidades.Commit();
        }

        public void Modificar(entidades.Habilidades modelo)
        {
            habilidades.Modificar(modelo);
            habilidades.Guardar();
            habilidades.Commit();

        }

        public void Eliminar(entidades.Habilidades modelo)
        {
            habilidades.Eliminar(modelo);
            habilidades.Guardar();
            habilidades.Commit();
        }

        public object TraerTodo()
        {
            return habilidades.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return habilidades.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            habilidades.RollBack();
        }
    }
}
