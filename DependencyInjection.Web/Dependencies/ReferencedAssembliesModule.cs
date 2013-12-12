using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using Autofac;

namespace DependencyInjection.Web.Dependencies
{
    public class ReferencedAssembliesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var referencedAssemblies = BuildManager.GetReferencedAssemblies()
                                                   .Cast<System.Reflection.Assembly>()
                                                   .ToArray();

            builder.RegisterAssemblyModules(referencedAssemblies);
        }
    }
}