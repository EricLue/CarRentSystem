using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Infrastructure;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Infrastructure;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Infrastructure;

namespace CarRent
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
            services.AddDbContext<CarRentDbContext>(settings =>
            {
                settings.UseSqlServer(Configuration.GetConnectionString("dbConnection"));
            });

            services.AddTransient<ICarService, CarService>();
            services.AddScoped<ICarRepository, CarRepository>();

            services.AddTransient<ICarClassService, CarClassService>();
            services.AddScoped<ICarClassRepository, CarClassRepository>();

            services.AddTransient<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddTransient<IReservationService, ReservationService>();
            services.AddScoped<IReservationRepository, ReservationRepository>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarRent", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRent v1"));
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
