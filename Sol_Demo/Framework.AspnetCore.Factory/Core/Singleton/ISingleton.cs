using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Core.Singleton
{
    public interface ISingleton
    {
        IRegisterFactory AddSingleton<TService>() where TService : class;

        IRegisterFactory AddSingleton<TService, TImplementation>() where TService : class where TImplementation : class, TService;

        IRegisterFactory AddSingleton<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class where TImplementation : class, TService;

        IRegisterFactory AddSingleton<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class;

        IRegisterFactory AddSingleton<TService>(TService implementationInstance) where TService : class;
    }
}