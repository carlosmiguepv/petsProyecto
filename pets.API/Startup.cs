using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using pets.Domain.Core.Interfaces;
using pets.Domain.Infrastructure.Data;
using pets.Domain.Infrastructure.Mappings;
using pets.Domain.Infrastructure.Repositories;

namespace pets.API
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "pets.API", Version = "v1" });
            });

            services.AddDbContext<PetsContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DevConnection"));
            });

            services.AddTransient<IAdministradorRepository, AdministradorRepository>();
            services.AddTransient<IAdoptarRepository, AdoptarRepository>();
            services.AddTransient<ICodigoRepository, CodigoRepository>();
            services.AddTransient<IComentarioRepository, ComentarioRepository>();
            services.AddTransient<IMascotaRepository, MascotaRepository>();
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IPublicacionRepository, PublicacionRepository>();
            services.AddTransient<IRazaRepository, RazaRepository>();
            services.AddTransient<ISponsorRepository, SponsorRepository>();
            services.AddTransient<ITipoRepository, TipoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddAutoMapper(typeof(AutomapperProfile));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "pets.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
