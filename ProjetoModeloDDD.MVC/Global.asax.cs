using AutoMapper;
using ProjetoModeloDDD.MVC.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoModeloDDD.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {        
        public static IMapper AutoMapperConfig { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configuração do AutoMapper usando a API baseada em instância
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
                // Adicione outros Profiles aqui
            });

            // Armazena em um container estático para reuso
            AutoMapperConfig = config.CreateMapper();            

            // Opcional: validar configuração
            config.AssertConfigurationIsValid();
        }
    }
}
