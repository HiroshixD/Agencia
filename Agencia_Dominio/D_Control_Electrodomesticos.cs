using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Control_Electrodomesticos
    {
        private readonly Repositorio<entidades.Control_Electrodomesticos> control_electrodomesticos;
        public D_Control_Electrodomesticos (Repositorio<entidades.Control_Electrodomesticos> control_electrodomesticos)
	    {
            this.control_electrodomesticos = control_electrodomesticos;
	    }


        public void AgregarNuevo(entidades.Control_Electrodomesticos modelo)
        {
            control_electrodomesticos.Agregar(modelo);
            control_electrodomesticos.Guardar();
            control_electrodomesticos.Commit();
        }

        public void Modificar(entidades.Control_Electrodomesticos modelo)
        {
            control_electrodomesticos.Modificar(modelo);
            control_electrodomesticos.Guardar();
            control_electrodomesticos.Commit();

        }

        public void Eliminar(entidades.Control_Electrodomesticos modelo)
        {
            control_electrodomesticos.Eliminar(modelo);
            control_electrodomesticos.Guardar();
            control_electrodomesticos.Commit();
        }

        public object TraerTodo()
        {
            return control_electrodomesticos.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return control_electrodomesticos.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            control_electrodomesticos.RollBack();
        }

    }
    }

