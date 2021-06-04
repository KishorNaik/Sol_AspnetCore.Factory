using Framework.AspnetCore.Factory.Core;
using Framework.AspnetCore.Factory.Core.Scoped;
using Framework.AspnetCore.Factory.Core.Singleton;
using Framework.AspnetCore.Factory.Core.Transient;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Framework.AspnetCore.Factory.Factory
{
    public class RegisterFactory : IRegisterFactory
    {
        private readonly IServiceCollection services = null;

        public RegisterFactory(IServiceCollection services)
        {
            this.services = services;
        }

        IRegisterFactory IScoped.AddScoped<TService, TImplementation>()
        {
            services.AddScoped<TService, TImplementation>();
            return this;
        }

        IRegisterFactory IScoped.AddScoped<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
        {
            services.AddScoped<TService, TImplementation>(implementationFactory);
            return this;
        }

        IRegisterFactory IScoped.AddScoped<TService>(Func<IServiceProvider, TService> implementationFactory)
        {
            services.AddScoped<TService>(implementationFactory);
            return this;
        }

        IRegisterFactory IScoped.AddScoped<TService>()
        {
            services.AddScoped<TService>();
            return this;
        }

        IRegisterFactory ISingleton.AddSingleton<TService, TImpelemntation>()
        {
            services.AddSingleton<TService, TImpelemntation>();
            return this;
        }

        IRegisterFactory ISingleton.AddSingleton<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
        {
            services.AddSingleton<TService, TImplementation>(implementationFactory);
            return this;
        }

        IRegisterFactory ISingleton.AddSingleton<TService>(Func<IServiceProvider, TService> implementationFactory)
        {
            services.AddSingleton<TService>(implementationFactory);
            return this;
        }

        IRegisterFactory ISingleton.AddSingleton<TService>(TService implementationInstance)
        {
            services.AddSingleton<TService>(implementationInstance);
            return this;
        }

        IRegisterFactory ISingleton.AddSingleton<TService>()
        {
            services.AddSingleton<TService>();
            return this;
        }

        IRegisterFactory ITransient.AddTransient<TService, TImplementation>()
        {
            services.AddTransient<TService, TImplementation>();
            return this;
        }

        IRegisterFactory ITransient.AddTransient<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
        {
            services.AddTransient<TService, TImplementation>(implementationFactory);
            return this;
        }

        IRegisterFactory ITransient.AddTransient<TService>(Func<IServiceProvider, TService> implementationFactory)
        {
            services.AddTransient<TService>(implementationFactory);
            return this;
        }

        IRegisterFactory ITransient.AddTransient<TService>()
        {
            services.AddTransient<TService>();
            return this;
        }
    }
}