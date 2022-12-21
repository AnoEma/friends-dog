using Api.Endpoints;

namespace Api;

public static class EndpointsConfig
{
    public static void AddEndpoints(this WebApplication app)
    {
        CustomerEndpointConfig.AddEndpoints(app);
    }
}