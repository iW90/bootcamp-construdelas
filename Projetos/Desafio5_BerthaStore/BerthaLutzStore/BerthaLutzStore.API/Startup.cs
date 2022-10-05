using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Infra.Database;
using BerthaLutzStore.Infra.Repositories;
using BerthaLutzStore.Application.Mappings;
using BerthaLutzStore.Application.UseCases;
using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Application.Models.SearchOrder;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.SearchAllUsers;
using BerthaLutzStore.Application.Models.SearchAllOrders;
using BerthaLutzStore.Application.Models.SearchAllProducts;
using System.Collections.Generic;

namespace BerthaLutzStore.API
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
            //Injeção de Dependência: evita o alto nível de acoplamento de código dentro de uma aplicação.

            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IUseCaseAsync<NewOrderRequest, IActionResult>, NewOrderUseCase>();
            services.AddTransient<IUseCaseAsync<NewProductRequest, IActionResult>, NewProductUseCase>();
            services.AddTransient<IUseCaseAsync<NewUserRequest, IActionResult>, NewUserUseCase>();

            services.AddTransient<IUseCaseAsync<SearchOrderRequest, IActionResult>, SearchOrderUseCase>();
            services.AddTransient<IUseCaseAsync<SearchProductRequest, IActionResult>, SearchProductUseCase>();
            services.AddTransient<IUseCaseAsync<SearchUserRequest, IActionResult>, SearchUserUseCase>();

            services.AddTransient<IUseCaseAsync<UpdateOrderRequest, IActionResult>, UpdateOrderUseCase>();
            services.AddTransient<IUseCaseAsync<UpdateProductRequest, IActionResult>, UpdateProductUseCase>();
            services.AddTransient<IUseCaseAsync<UpdateUserRequest, IActionResult>, UpdateUserUseCase>();

            services.AddTransient<DeleteOrderUseCase>();
            services.AddTransient<DeleteProductUseCase>();
            services.AddTransient<DeleteUserUseCase>();

            services.AddTransient<IUseCaseAsync<SearchAllOrdersRequest, IActionResult>, SearchAllOrdersUseCase>();
            services.AddTransient<IUseCaseAsync<SearchAllProductsRequest, IActionResult>, SearchAllProductsUseCase>();
            services.AddTransient<IUseCaseAsync<SearchAllUsersRequest, IActionResult>, SearchAllUsersUseCase>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BerthaLutzStore.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BerthaLutzStore.API v1"));
            }

            context.Database.Migrate(); //verifica updates automaticamente

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
