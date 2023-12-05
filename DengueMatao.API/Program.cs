using DengueMatao.Application.Interfaces;
using DengueMatao.Application.Mappings;
using DengueMatao.Application.Services;
using DengueMatao.Domain.Interface;
using DengueMatao.Infra.Data.Context;
using DengueMatao.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DengueMatao.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IPessoaAfetadaRepository, PessoaAfetadaRepository>();
            builder.Services.AddScoped<ICasoDengueRepository, CasoDengueRepository>();

            //MappingInjection DTOs
            builder.Services.AddScoped<ICasoDengueService, CasoDengueService>();
            builder.Services.AddScoped<IPessoaAfetadaService, PessoaAfetadaService>();

            builder.Services.AddAutoMapper(typeof(DomainToDTOMappingProfile));


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseRouting();



            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}