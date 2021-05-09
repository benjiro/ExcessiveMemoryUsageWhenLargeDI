using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace LargeDependencyMemoryBlowout
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
            
            services.AddScoped<DI0, DS0>();
            services.AddScoped<DI1, DS1>();
            services.AddScoped<DI2, DS2>();
            services.AddScoped<DI3, DS3>();
            services.AddScoped<DI4, DS4>();
            services.AddScoped<DI5, DS5>();
            services.AddScoped<DI6, DS6>();
            services.AddScoped<DI7, DS7>();
            services.AddScoped<DI8, DS8>();
            services.AddScoped<DI9, DS9>();
            services.AddScoped<DI10, DS10>();
            services.AddScoped<DI11, DS11>();
            services.AddScoped<DI12, DS12>();
            services.AddScoped<DI13, DS13>();
            services.AddScoped<DI14, DS14>();
            services.AddScoped<DI15, DS15>();
            services.AddScoped<DI16, DS16>();
            services.AddScoped<DI17, DS17>();
            services.AddScoped<DI18, DS18>();
            services.AddScoped<DI19, DS19>();
            services.AddScoped<DI20, DS20>();
            services.AddScoped<DI21, DS21>();
            services.AddScoped<DI22, DS22>();
            services.AddScoped<DI23, DS23>();
            services.AddScoped<DI24, DS24>();
            services.AddScoped<DI25, DS25>();
            services.AddScoped<DI26, DS26>();
            services.AddScoped<DI27, DS27>();
            services.AddScoped<DI28, DS28>();
            services.AddScoped<DI29, DS29>();
            services.AddScoped<DI30, DS30>();
            services.AddScoped<DI31, DS31>();
            services.AddScoped<DI32, DS32>();
            services.AddScoped<DI33, DS33>();
            services.AddScoped<DI34, DS34>();
            services.AddScoped<DI35, DS35>();
            services.AddScoped<DI36, DS36>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}