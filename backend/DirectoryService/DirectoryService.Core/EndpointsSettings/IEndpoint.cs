namespace DirectoryService.Core.EndpointsSettings
{
    internal interface IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app);
    }
}
