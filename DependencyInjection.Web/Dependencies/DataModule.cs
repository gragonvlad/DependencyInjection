using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using DependencyInjection.Core;

namespace DependencyInjection.Web.Dependencies
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<Repository>()
                .As<IRepository>()
                .InstancePerApiRequest()
                .InstancePerHttpRequest();
        }
    }
}