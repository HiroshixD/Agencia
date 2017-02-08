using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Agencia_Datos_Repositorio;
using Agencia_Datos_Entidades;

namespace Agencia_Dominio.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IRepositorio<Cliente>, Repositorio<Cliente>>();
            container.RegisterType<IRepositorio<Contrato>, Repositorio<Contrato>>();
            container.RegisterType<IRepositorio<Control_Electrodomestico_Empleado>, Repositorio<Control_Electrodomestico_Empleado>>();
            container.RegisterType<IRepositorio<Control_Electrodomesticos>, Repositorio<Control_Electrodomesticos>>();
            container.RegisterType<IRepositorio<Doc_Identidad>, Repositorio<Doc_Identidad>>();
            container.RegisterType<IRepositorio<Documentos>, Repositorio<Documentos>>();
            container.RegisterType<IRepositorio<D_DocumentoxEmpleado>, Repositorio<D_DocumentoxEmpleado>>();
            container.RegisterType<IRepositorio<Empleado>, Repositorio<Empleado>>();
            container.RegisterType<IRepositorio<Empleado_Detalle>, Repositorio<Empleado_Detalle>>();
            container.RegisterType<IRepositorio<Estudios>, Repositorio<Estudios>>();
            container.RegisterType<IRepositorio<HabilidadEmpleado>, Repositorio<HabilidadEmpleado>>();
            container.RegisterType<IRepositorio<Habilidades>, Repositorio<Habilidades>>();
            container.RegisterType<IRepositorio<Idiomas>, Repositorio<Idiomas>>();
            container.RegisterType<IRepositorio<MenuEmpleado>, Repositorio<MenuEmpleado>>();
            container.RegisterType<IRepositorio<Menus>, Repositorio<Menus>>();
            container.RegisterType<IRepositorio<Religion>, Repositorio<Religion>>();
            container.RegisterType<IRepositorio<ServicioEmpleado>, Repositorio<ServicioEmpleado>>();
            container.RegisterType<IRepositorio<Servicios>, Repositorio<Servicios>>();
            container.RegisterType<IRepositorio<TipoUsuario>, Repositorio<TipoUsuario>>();
            container.RegisterType<IRepositorio<Ubigeo>, Repositorio<Ubigeo>>();   


        
        
        }
    }
}
