using Framework.AspnetCore.Factory.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Factory
{
    public class ExecuteFactory : IExecuteFactory
    {
        private readonly IServiceProvider serviceProvider = null;

        public ExecuteFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        TService IExecuteFactory.Execute<TService>()
        {
            return serviceProvider.GetRequiredService<TService>();
        }
    }
}