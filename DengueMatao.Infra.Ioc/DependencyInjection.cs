using DengueMatao.Application.Interfaces;
using DengueMatao.Application.Mappings;
using DengueMatao.Application.Services;
using DengueMatao.Domain.Interface;
using DengueMatao.Infra.Data.Context;
using DengueMatao.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DengueMatao.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );

            services.AddScoped<IPessoaAfetadaRepository, PessoaAfetadaRepository>();
            services.AddScoped<ICasoDengueRepository, CasoDengueRepository>();

            //MappingInjection DTOs
            services.AddScoped<ICasoDengueService, CasoDengueService>();
            services.AddScoped<IPessoaAfetadaService, PessoaAfetadaService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            return services;
        }
    }
}
