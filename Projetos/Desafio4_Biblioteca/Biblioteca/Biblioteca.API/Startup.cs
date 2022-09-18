using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Biblioteca.Application.Mappings;
//using Biblioteca.Application.Models.AdicionarAutor;
//using Biblioteca.Application.Models.AdicionarUsuario;
//using Biblioteca.Application.Models.AtualizarDevolucaoLivro;
//using Biblioteca.Application.Models.DevolucoesEmAtraso;
//using Biblioteca.Application.Models.ExcluirEmprestimo;
//using Biblioteca.Application.Models.ListarLivros;
//using Biblioteca.Application.Models.LivrosDisponiveis;
//using Biblioteca.Application.Models.LivrosEmEmprestimo;
//using Biblioteca.Application.UseCases;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infra.Database;
//using Biblioteca.Infra.Repositories;

namespace Biblioteca.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Biblioteca.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biblioteca.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
