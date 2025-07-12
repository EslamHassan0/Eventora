
using AutoMapper;
using Eventora.Application.Contracts.Customers;
using Eventora.Application.Contracts.Tenants;
using Eventora.Application.Customers;
using Eventora.Application.Tenants;
using Eventora.Domain.Customers;
using Eventora.Domain.Services;
using Eventora.Domain.Tenants;
using Eventora.Infrastructure.EventoraDBContexts;
using Eventora.Infrastructure.Repository;
using Eventora.WebAPi;
using Eventora.WebAPi.Middlewares;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace Eventora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<EventoraDBContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //TenantSetting options = new();
            //builder.Configuration.GetSection(nameof(TenantSetting)).Bind(options);

            builder.Services.AddScoped<ITenantService, TenantService>(); 
            builder.Services.AddScoped<ICustomersService, CustomersService>();
            builder.Services.AddScoped<CustomerManager>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>(); 
            builder.Services.AddScoped<ITenantRepository, TenantRepository>(); 
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<TenantHeaderMiddleware>();
            app.UseMiddleware<TenantMiddleware>();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
