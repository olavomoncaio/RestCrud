using AplicacoesDistribuidas.Interfaces;
using AplicacoesDistribuidas.Repositories;
using AplicacoesDistribuidas.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AplicacoesDistribuidas.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            services.AddTransient<ICardapioService, CardapioService>();
            services.AddTransient<ICardapioRepository, CardapioRepository>();

            return services;
        }
    }
}
