using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestingConnectionWithPostgre.Models;
using TestingConnectionWithPostgre.Services;
using Xero.NetStandard.OAuth2.Config;

namespace TestingConnectionWithPostgre
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
            services.AddHttpClient<IXeroService, XeroService>();
            services.AddScoped<IXeroService, XeroService>();
            services.Configure<XeroConfiguration>(Configuration.GetSection("Xero"));
            services.AddControllers();

            services.AddEntityFrameworkNpgsql().AddDbContext<MyWebApiContext>(
                opt => opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConnection")));
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Person}/{action=Get}/{id?}");
            });
        }
    }
}
