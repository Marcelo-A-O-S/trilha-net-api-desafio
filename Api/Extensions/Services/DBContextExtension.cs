using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;

namespace Api.Extensions.Services
{
    public static class DBContextExtension
    {
        public static IServiceCollection AddOrganizadorContext(
            this IServiceCollection services, IConfiguration configuration
        )
        {
            services.AddDbContext<OrganizadorContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("ConexaoPadrao"),
                    ServerVersion.AutoDetect(configuration.GetConnectionString("ConexaoPadrao"))));
            return services;
        }
    }
}