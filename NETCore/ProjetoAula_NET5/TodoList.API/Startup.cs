using Microsoft.OpenApi.Models;
using TodoList.Application.Models;
using TodoList.Application.UseCases;
using TodoList.Core.Repositories;
using TodoList.Infra.Database;
using TodoList.Infra.Repositories;

namespace TodoList.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) //construtor
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUseCaseAsync<TaskListRequest, TaskListResponse>, InsertTodoListUseCase>();
            services.AddTransient<IRepository, ToDoListRepository>();
            services.AddTransient<ApplicationContext>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Projeto01", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment environment) //"IApplicationBuilder" (.NET5) = "WebApplication" (.NET6)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
