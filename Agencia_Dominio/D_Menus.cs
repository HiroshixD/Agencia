using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Menus
    {
        private readonly Repositorio<entidades.Menus> menus;
        public D_Menus (Repositorio<entidades.Menus> menus)
	    {
            this.menus = menus;
	    }


        public void AgregarNuevo(entidades.Menus modelo)
        {
            menus.Agregar(modelo);
            menus.Guardar();
            menus.Commit();
        }

        public void Modificar(entidades.Menus modelo)
        {
            menus.Modificar(modelo);
            menus.Guardar();
            menus.Commit();

        }

        public void Eliminar(entidades.Menus modelo)
        {
            menus.Eliminar(modelo);
            menus.Guardar();
            menus.Commit();
        }

        public object TraerTodo()
        {
            return menus.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return menus.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            menus.RollBack();
        }
    }
}
