using ApiSeriesCoreOAuth.Data;
using ApiSeriesCoreOAuth.Repositories;
using ApiSeriesCoreOAuth.Token;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ApiSeriesCoreOAuth
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
            string cadena = this.Configuration.GetConnectionString("DefaultConnection");
            services.AddTransient<ISeriesRepository, SeriesRepository>();
            services.AddTransient<IPersonajesRepository, PersonajesRepository>();
            services.AddTransient<IUsuariosRepository, UsuariosRepository>();

            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(cadena));

            services.AddSwaggerGen(
                c =>
                {
                    // Version 2 & Version 1
                    c.SwaggerDoc(
                        name: "v1", new OpenApiInfo
                        {
                            Title = "ApiTvShows Seguridad OAuth",
                            Version = "v1",
                            Description = "ApiTvShows con seguridad OAuth Token"
                        });
                });
            HelperToken helper = new HelperToken(this.Configuration);
            // Añadir Autentificación al Servicio
            services.AddAuthentication(helper.GetAuthOptions())
                .AddJwtBearer(helper.GetJwtOptions());

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiTvShowsCoreOAuth v1"));
            }
            app.UseSwagger();
            // UI indica donde va a visualizar el Usuario la documentación generada por Swagger en nuestro servidor
            app.UseSwaggerUI(
                c =>
                {
                    // Configurar la URL del servidor para la documentación
                    c.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "Api v1");
                    c.RoutePrefix = "";
                });

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
