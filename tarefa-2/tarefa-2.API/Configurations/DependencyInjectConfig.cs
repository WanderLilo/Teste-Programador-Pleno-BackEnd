using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using tarefa_2.ApplicationCore.Interfaces;
using tarefa_2.ApplicationCore.Notificador;
using tarefa_2.ApplicationCore.Services;
using tarefa_2.Infrastructure.Data;
using tarefa_2.Infrastructure.Data.Repositories;

namespace tarefa_2.API.Configurations
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IUnitOfWork,UnitOfWork>();

            services.AddScoped<IEstadoRepository, EstadoRepository>();

            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<ICidadeService, CidadeService>();

            return services;
        }
    }
}
