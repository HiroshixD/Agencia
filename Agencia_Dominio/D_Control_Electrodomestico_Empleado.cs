using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_Datos_Repositorio;
using entidades = Agencia_Datos_Entidades;

namespace Agencia_Dominio
{
    public class D_Control_Electrodomestico_Empleado
    {
 private readonly Repositorio<entidades.Control_Electrodomestico_Empleado> c_e_empleado;
        public D_Control_Electrodomestico_Empleado (Repositorio<entidades.Control_Electrodomestico_Empleado> c_e_empleado)
	    {
            this.c_e_empleado = c_e_empleado;
	    }


        public void AgregarNuevo(entidades.Control_Electrodomestico_Empleado modelo)
        {
            c_e_empleado.Agregar(modelo);
            c_e_empleado.Guardar();
            c_e_empleado.Commit();
        }

        public void Modificar(entidades.Control_Electrodomestico_Empleado modelo)
        {
            c_e_empleado.Modificar(modelo);
            c_e_empleado.Guardar();
            c_e_empleado.Commit();

        }

        public void Eliminar(entidades.Control_Electrodomestico_Empleado modelo)
        {
            c_e_empleado.Eliminar(modelo);
            c_e_empleado.Guardar();
            c_e_empleado.Commit();
        }

        public object TraerTodo()
        {
            return c_e_empleado.TraerTodo();
        }

        public object TraerUnoPorId(int id)
        {
            return c_e_empleado.TraerUnoPorId(id);
        }

        public void Rollback()
        {
            c_e_empleado.RollBack();
        }

    }    }

