using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp
{
    public class Startup
    {
        private IConfiguration configuration;
        private string extensionPath;
        public Startup(IConfiguration config, IHostingEnvironment hostingEnvironment)
        {
            this.configuration = config;
            this.extensionPath = hostingEnvironment.ContentRootPath + this.configuration["Extensions:Path"];
         
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddExtCore(extensionPath);
            services.Configure<StorageContextOptions>(options =>
            {
                options.ConnectionString = configuration.GetConnectionString("Default");
            });
     
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseExtCore();
        }
    }
}
