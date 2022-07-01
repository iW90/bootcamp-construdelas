using TodoList.Application.Mappings;
using Microsoft.OpenApi.Models;
using TodoList.Application.Models;
using TodoList.Application.UseCases;
using TodoList.Core.Repositories;
using TodoList.Core.DTOs;
using TodoList.Core.Services;
using TodoList.Infra.Database;
using TodoList.Infra.Repositories;
using TodoList.Infra.Services;

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
            // Use Cases
            services.AddTransient<IUseCaseAsync<TaskListRequest, TaskListResponse>, InsertTodoListUseCase>();
            services.AddTransient<IUseCaseAsync<int, TaskListResponse>, GetTodoListUseCase>();
            services.AddTransient<IUseCaseAsync<TaskRequest, TaskResponse>, InsertTaskDetailUseCase>();
            services.AddTransient<IUseCaseAsync<string, WeatherDTO>, GetWeatherForecastUseCase>();

            // Repositories
            services.AddTransient<IRepository, ToDoListRepository>();

            // Services
            services.AddTransient<IWeatherService, WeatherService>();

            // Mappers
            services.AddAutoMapper(typeof(MappingProfile));


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
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto01 v1"));
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
