using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AplicacoesDistribuidas.Configurations
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ConfigurarSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Cardápio API",
                    Description = "API para Cardápio de Aplicações Distribuidas"
                });
            });

            return services;
        }
    }
}
