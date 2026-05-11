using DirectoryService.Core.EndpointsSettings;

namespace DirectoryService.Core.Configuration
{
    internal static class AppExtensions
    {
        public static IApplicationBuilder Configure(this WebApplication app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            RouteGroupBuilder apiGroup = app.MapGroup("/api");
            app.UseEndpoints(apiGroup);

            return app;
        }
    }
}
