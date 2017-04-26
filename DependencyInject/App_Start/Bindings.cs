using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInject.App_Start
{
    public class Bindings
    {
        public static void RegisterServices()
        {
            var builder = new ContainerBuilder();
        }
    }
}