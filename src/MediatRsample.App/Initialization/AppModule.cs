using Autofac;
using MediatR_sample.App.RequestHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR_sample.App.Initialization
{
    public class AppModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => new PlaceOrderRequestHandler()).AsImplementedInterfaces().SingleInstance();
        }
    }
}
