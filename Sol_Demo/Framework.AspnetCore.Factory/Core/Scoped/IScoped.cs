using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Core.Scoped
{
    public interface IScoped
    {
        IRegisterFactory AddScoped<TService>() where TService : class;

        IRegisterFactory AddScoped<TService, TImplementation>() where TService : class where TImplementation : class, TService;

        IRegisterFactory AddScoped<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class where TImplementation : class, TService;

        IRegisterFactory AddScoped<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class;
    }
}