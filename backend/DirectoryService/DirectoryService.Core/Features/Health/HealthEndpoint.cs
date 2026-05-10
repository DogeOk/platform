using DirectoryService.Core.EndpointsSettings;

namespace DirectoryService.Core.Features.Health
{
    internal sealed class HealthEndpoint : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost("/health", async () =>
            {
            });
        }
    }
}
