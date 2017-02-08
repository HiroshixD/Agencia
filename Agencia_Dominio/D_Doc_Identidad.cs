using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Doc_Identidad
    {
        private readonly Repositorio<entidades.Doc_Identidad> doc_identidad;
        public D_Doc_Identidad (Repositorio<entidades.Doc_Identidad> doc_identidad)
	    {
            this.doc_identidad = doc_identidad;
	    }


        public void AgregarNuevo(entidades.Doc_Identidad modelo)
        {
            doc_identidad.Agregar(modelo);
            doc_identidad.Guardar();
            doc_identidad.Commit();
        }

        public void Modificar(entidades.Doc_Identidad modelo)
        {
            doc_identidad.Modificar(modelo);
            doc_identidad.Guardar();
            doc_identidad.Commit();

        }

        public void Eliminar(entidades.Doc_Identidad modelo)
        {
            doc_identidad.Eliminar(modelo);
            doc_identidad.Guardar();
            doc_identidad.Commit();
        }

        public object TraerTodo()
        {
            return doc_identidad.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return doc_identidad.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            doc_identidad.RollBack();
        }
    }
}
