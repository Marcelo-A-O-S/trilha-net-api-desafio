using Api.Repositories;
using Api.Repositories.Interfaces;
using Api.Services;
using Api.Services.Interfaces;
using TrilhaApiDesafio.Models;

namespace Api.Extensions.Services
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjections(
            this IServiceCollection services
        )
        {
            //Services
            services.AddScoped<ITarefaServices, TarefaServices>();
            //Repositories
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            //Generics
            services.AddScoped<IGenerics<Tarefa>, Generics<Tarefa>>();
            return services;
        }
    }
}