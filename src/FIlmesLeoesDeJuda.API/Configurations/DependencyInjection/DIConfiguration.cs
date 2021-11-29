using FIlmesLeoesDeJuda.BL.Services;
using FIlmesLeoesDeJuda.BL.Services.Interfaces;
using FIlmesLeoesDeJuda.DAL;
using FIlmesLeoesDeJuda.DAL.Repositories;
using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.API.Configurations.DependencyInjection
{
    public static class DIConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<FilmesLeoesDeJudaContext>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
