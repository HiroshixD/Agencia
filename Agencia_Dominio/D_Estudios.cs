using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Estudios
    {
        private readonly Repositorio<entidades.Estudios> estudios;
        public D_Estudios (Repositorio<entidades.Estudios> estudios)
	    {
            this.estudios = estudios;
	    }


        public void AgregarNuevo(entidades.Estudios modelo)
        {
            estudios.Agregar(modelo);
            estudios.Guardar();
            estudios.Commit();
        }

        public void Modificar(entidades.Estudios modelo)
        {
            estudios.Modificar(modelo);
            estudios.Guardar();
            estudios.Commit();

        }

        public void Eliminar(entidades.Estudios modelo)
        {
            estudios.Eliminar(modelo);
            estudios.Guardar();
            estudios.Commit();
        }

        public object TraerTodo()
        {
            return estudios.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return estudios.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            estudios.RollBack();
        }
    }
}
