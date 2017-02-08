using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Cliente
    {
        private readonly Repositorio<entidades.Cliente> cliente;
        public D_Cliente (Repositorio<entidades.Cliente> cliente)
	    {
            this.cliente = cliente;
	    }


        public void AgregarNuevo(entidades.Cliente modelo)
        {
            cliente.Agregar(modelo);
            cliente.Guardar();
            cliente.Commit();
        }

        public void Modificar(entidades.Cliente modelo)
        {
            cliente.Modificar(modelo);
            cliente.Guardar();
            cliente.Commit();

        }

        public void Eliminar(entidades.Cliente modelo)
        {
            cliente.Eliminar(modelo);
            cliente.Guardar();
            cliente.Commit();
        }

        public object TraerTodo()
        {
            return cliente.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return cliente.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            cliente.RollBack();
        }

    }
}
