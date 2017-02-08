using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_DocumentoxEmpleado
    {
        private readonly Repositorio<entidades.DocumentoxEmpleado> documentosxempleado;
        public D_DocumentoxEmpleado (Repositorio<entidades.DocumentoxEmpleado> documentosxempleado)
	    {
            this.documentosxempleado = documentosxempleado;
	    }


        public void AgregarNuevo(entidades.DocumentoxEmpleado modelo)
        {
            documentosxempleado.Agregar(modelo);
            documentosxempleado.Guardar();
            documentosxempleado.Commit();
        }

        public void Modificar(entidades.DocumentoxEmpleado modelo)
        {
            documentosxempleado.Modificar(modelo);
            documentosxempleado.Guardar();
            documentosxempleado.Commit();

        }

        public void Eliminar(entidades.DocumentoxEmpleado modelo)
        {
            documentosxempleado.Eliminar(modelo);
            documentosxempleado.Guardar();
            documentosxempleado.Commit();
        }

        public object TraerTodo()
        {
            return documentosxempleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return documentosxempleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            documentosxempleado.RollBack();
        }
    }
}
