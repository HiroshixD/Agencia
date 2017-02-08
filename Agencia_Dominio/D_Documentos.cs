using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Documentos
    {
        private readonly Repositorio<entidades.Documentos> documentos;
        public D_Documentos (Repositorio<entidades.Documentos> documentos)
	    {
            this.documentos = documentos;
	    }


        public void AgregarNuevo(entidades.Documentos modelo)
        {
            documentos.Agregar(modelo);
            documentos.Guardar();
            documentos.Commit();
        }

        public void Modificar(entidades.Documentos modelo)
        {
            documentos.Modificar(modelo);
            documentos.Guardar();
            documentos.Commit();

        }

        public void Eliminar(entidades.Documentos modelo)
        {
            documentos.Eliminar(modelo);
            documentos.Guardar();
            documentos.Commit();
        }

        public object TraerTodo()
        {
            return documentos.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return documentos.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            documentos.RollBack();
        }
    }
}
