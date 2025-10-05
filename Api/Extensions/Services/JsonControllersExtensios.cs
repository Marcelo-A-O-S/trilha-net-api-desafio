using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Extensions.Services
{
    public static class JsonControllersExtensios
    {
        public static IServiceCollection AddJsonControllerExtension(
            this IServiceCollection services
        )
        {
            services.AddControllers().AddJsonOptions(options =>
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            return services;
        }
    }
}