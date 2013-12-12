using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

namespace DependencyInjection.Web
{
    public static class DependencyConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            var builder = new ContainerBuilder();

            var currentAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterApiControllers(currentAssembly);
            builder.RegisterControllers(currentAssembly);
            builder.RegisterAssemblyModules(currentAssembly);

            var container = builder.Build();

            // set resolver for WebApi
            configuration.DependencyResolver = new Autofac.Integration.WebApi.AutofacWebApiDependencyResolver(container);

            // set resolver for MVC
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));
        }
    }
}