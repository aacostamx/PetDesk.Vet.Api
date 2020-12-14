using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PetDesk.Vet.Api.Manager;
using PetDesk.Vet.Api.Services;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace PetDesk.Vet.Api
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Vet API", Version = "V1" });
            });

            services.AddHttpClient("Appointments", x =>
            {
                x.BaseAddress = new Uri(Configuration.GetSection("Appointments").Value);
                x.DefaultRequestHeaders.Add("Accept", "application/json");
                x.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddControllers();

            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IAppointmentQuery, AppointmentQuery>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Vet API V1");
            });

            app.UseRouting();
            app.UseCors("AllowOrigin");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
             {
                 endpoints.MapDefaultControllerRoute();
             });
        }
    }
}
