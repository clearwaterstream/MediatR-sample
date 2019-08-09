using Autofac;
using clearwaterstream.IoC;
using MediatR_sample.App.Initialization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRsample.Api.Initialization
{
    public class ApiInitializer
    {
        public static void Initialize(IConfiguration configuration)
        {
            ServiceRegistrar.SetConfigutation(configuration);

            ServiceRegistrar.Bootstrap(PerformRegistrations);
        }

        static void PerformRegistrations(ContainerBuilder builder)
        {
            builder.RegisterModule(new AppModule());
        }
    }
}
