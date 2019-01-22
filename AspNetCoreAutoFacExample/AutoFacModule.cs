using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAutoFacExample.Services;
using Autofac;
using Microsoft.Extensions.Logging;

namespace AspNetCoreAutoFacExample
{
    public class AutoFacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c=>new ValuesService(c.Resolve<ILogger<ValuesService>>())).As<IValuesService>().InstancePerLifetimeScope();
        }
    }
}
