using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using WoMakersCode.ToDoList.Application.Mappings;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Application.UseCases;
using WoMakersCode.ToDoList.Core.Filters;
using WoMakersCode.ToDoList.Core.Interfaces;
using WoMakersCode.ToDoList.Infra.Database;
using WoMakersCode.ToDoList.Infra.Repositories;

namespace WoMakersCode.ToDoList
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
            services.AddScoped<ITaskListRepository, TaskListRepository>();
            services.AddScoped<IAlarmRepository, AlarmRepository>();
            services.AddScoped<ITaskDetailRepository, ToDoListRepository>();
            services.AddScoped<IUseCaseAsync<TaskListRequest, List<TaskListResponse>>, GetAllTaskListUseCase>();
            services.AddScoped<IUseCaseAsync<GetFilter, GetByIdResponse>, GetByIdUseCase>();
            services.AddScoped<IUseCaseAsync<TaskListRequest, InsertToDoListResponse>, InsertTodoListUseCase>();
            services.AddScoped<IUseCaseAsync<List<InsertAlarmRequest>, InsertAlarmResponse>, InsertAlarmUseCase>();
            services.AddTransient<IUseCaseAsync<TaskRequest, TaskResponse>, InsertTaskDetailUseCase>();



            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
             );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WoMakersCode.ToDoList", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WoMakersCode.ToDoList v1"));
            }
            context.Database.Migrate();

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