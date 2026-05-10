using DirectoryService.Core.EndpointsSettings;
using Microsoft.OpenApi;

namespace DirectoryService.Core.Configuration
{
    internal static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddOpenApi()
                .AddSwagger()
                .AddEndpoints(typeof(DependencyInjectionExtensions).Assembly);
        }

        private static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen((options) =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "DirectoryService API",
                    Description = "DirectoryService API Documentation",
                    Contact = new OpenApiContact
                    {
                        Name = "Soer",
                        Email = "gagar170202@gmail.com",
                    },
                });
            });
        }
    }
}
