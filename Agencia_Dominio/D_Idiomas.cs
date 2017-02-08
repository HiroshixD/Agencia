using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Idiomas
    {
        private readonly Repositorio<entidades.Idiomas> idiomas;
        public D_Idiomas (Repositorio<entidades.Idiomas> idiomas)
	    {
            this.idiomas = idiomas;
	    }


        public void AgregarNuevo(entidades.Idiomas modelo)
        {
            idiomas.Agregar(modelo);
            idiomas.Guardar();
            idiomas.Commit();
        }

        public void Modificar(entidades.Idiomas modelo)
        {
            idiomas.Modificar(modelo);
            idiomas.Guardar();
            idiomas.Commit();

        }

        public void Eliminar(entidades.Idiomas modelo)
        {
            idiomas.Eliminar(modelo);
            idiomas.Guardar();
            idiomas.Commit();
        }

        public object TraerTodo()
        {
            return idiomas.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return idiomas.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            idiomas.RollBack();
        }
    }
}
