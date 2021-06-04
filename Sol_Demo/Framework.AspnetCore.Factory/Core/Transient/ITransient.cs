using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Core.Transient
{
    public interface ITransient
    {
        IRegisterFactory AddTransient<TService>() where TService : class;

        IRegisterFactory AddTransient<TService, TImplementation>() where TService : class where TImplementation : class, TService;

        IRegisterFactory AddTransient<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class where TImplementation : class, TService;

        IRegisterFactory AddTransient<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class;
    }
}