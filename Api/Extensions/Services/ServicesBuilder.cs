using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Extensions.Services
{
    public static class ServicesBuilder
    {
        
        public static IServiceCollection AddServicesBuilder(
            this IServiceCollection services, IConfiguration configuration
        )
        {
            services.AddOrganizadorContext(configuration);
            services.AddJsonControllerExtension();
            services.AddSwaggerConfig();
            services.AddDependencyInjections();
            return services;
        }
    }
}