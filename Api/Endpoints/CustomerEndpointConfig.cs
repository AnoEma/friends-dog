namespace Api.Endpoints;

public static class CustomerEndpointConfig
{
    public static void AddEndpoints(WebApplication app)
    {
        app.MapGet("customer", () =>
        {
            return "ok";
        });
    }
}