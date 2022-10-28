using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using SampleTesting.Feature.Components.Services;
using SampleTesting.Feature.Components.Controllers;

namespace SampleTesting.Feature.Components.App_Start
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISampleService, SampleService>();

            serviceCollection.AddTransient(typeof(ComponentController));
        }
    }
}