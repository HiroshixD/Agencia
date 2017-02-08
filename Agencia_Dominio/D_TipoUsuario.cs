using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_TipoUsuario
    {
        private readonly Repositorio<entidades.TipoUsuario> tipousuario;
        public D_TipoUsuario (Repositorio<entidades.TipoUsuario> tipousuario)
	    {
            this.tipousuario = tipousuario;
	    }


        public void AgregarNuevo(entidades.TipoUsuario modelo)
        {
            tipousuario.Agregar(modelo);
            tipousuario.Guardar();
            tipousuario.Commit();
        }

        public void Modificar(entidades.TipoUsuario modelo)
        {
            tipousuario.Modificar(modelo);
            tipousuario.Guardar();
            tipousuario.Commit();

        }

        public void Eliminar(entidades.TipoUsuario modelo)
        {
            tipousuario.Eliminar(modelo);
            tipousuario.Guardar();
            tipousuario.Commit();
        }

        public object TraerTodo()
        {
            return tipousuario.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return tipousuario.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            tipousuario.RollBack();
        }
    }
}
