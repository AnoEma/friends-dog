using Application.services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints;

public static class CustomerEndpointConfig
{
    public static void AddEndpoints(WebApplication app)
    {
        app.MapGet("customer", () =>
        {
            return "ok";
        });

        app.MapPost("customer",  async ([FromServices] ICustomersApplication service) =>
        {
            return "Ok";
        });
    }
}