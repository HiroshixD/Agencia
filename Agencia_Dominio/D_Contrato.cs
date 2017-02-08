using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Contrato
    {
         private readonly Repositorio<entidades.Contrato> contrato;
        public D_Contrato (Repositorio<entidades.Contrato> contrato)
	    {
            this.contrato = contrato;
	    }


        public void AgregarNuevo(entidades.Contrato modelo)
        {
            contrato.Agregar(modelo);
            contrato.Guardar();
            contrato.Commit();
        }

        public void Modificar(entidades.Contrato modelo)
        {
            contrato.Modificar(modelo);
            contrato.Guardar();
            contrato.Commit();

        }

        public void Eliminar(entidades.Contrato modelo)
        {
            contrato.Eliminar(modelo);
            contrato.Guardar();
            contrato.Commit();
        }

        public object TraerTodo()
        {
            return contrato.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return contrato.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            contrato.RollBack();
        }

    }
    }

