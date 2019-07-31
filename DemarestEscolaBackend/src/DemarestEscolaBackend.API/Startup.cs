using System;
using DemarestEscolaBackend.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DemarestEscolaBackend.API
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
            NativeInjectorBootStrapper.Services(services, Configuration.GetConnectionString("DefaultConnection"));

            services.AddMvc()
                   .AddMvcOptions(options =>
                   {                                              
                       options.Filters.Add(new ProducesAttribute("application/json"));
                   })
                   .AddJsonOptions(options =>
                   {
                       options.SerializerSettings.Converters.Add(new StringEnumConverter());
                       options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                       options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                   })
                   .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowFront", builder =>
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                );
            });           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors("AllowFront");
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
            InitializeDatabase(app);
        }

        private void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                Console.WriteLine("Seeding database...");
                NativeInjectorBootStrapper.SeedData(serviceScope);
                Console.WriteLine("Done seeding database.");
                Console.WriteLine();
            }
        }
    }
}
