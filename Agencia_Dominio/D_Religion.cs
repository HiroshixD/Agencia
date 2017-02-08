using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Religion
    {
        private readonly Repositorio<entidades.Religion> religion;
        public D_Religion (Repositorio<entidades.Religion> religion)
	    {
            this.religion = religion;
	    }


        public void AgregarNuevo(entidades.Religion modelo)
        {
            religion.Agregar(modelo);
            religion.Guardar();
            religion.Commit();
        }

        public void Modificar(entidades.Religion modelo)
        {
            religion.Modificar(modelo);
            religion.Guardar();
            religion.Commit();

        }

        public void Eliminar(entidades.Religion modelo)
        {
            religion.Eliminar(modelo);
            religion.Guardar();
            religion.Commit();
        }

        public object TraerTodo()
        {
            return religion.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return religion.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            religion.RollBack();
        }
    }
}
