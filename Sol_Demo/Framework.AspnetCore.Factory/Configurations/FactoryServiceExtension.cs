using Framework.AspnetCore.Factory.Core;
using Framework.AspnetCore.Factory.Factory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Configurations
{
    public static class FactoryServiceExtension
    {
        public static IServiceCollection AddFactory(this IServiceCollection services, Action<IRegisterFactory> registerFactory)
        {
            registerFactory?.Invoke(new RegisterFactory(services));

            services.TryAddSingleton<IExecuteFactory, ExecuteFactory>();

            return services;
        }
    }
}