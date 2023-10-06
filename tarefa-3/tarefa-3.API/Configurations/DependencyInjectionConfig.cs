using Microsoft.Extensions.DependencyInjection;
using tarefa_3.ApplicationCore.Interfaces;
using tarefa_3.ApplicationCore.Notificador;
using tarefa_3.ApplicationCore.Services;
using tarefa_3.Infrastructure.Data.Repositories;

namespace tarefa_3.API.Configurations
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();

            return services;
        }
    }

}
