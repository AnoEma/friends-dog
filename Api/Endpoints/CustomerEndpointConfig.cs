using Application.services;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints;

public static class CustomerEndpointConfig
{
    public static void AddEndpoints(WebApplication app)
    {
        app.MapPost("customer", (
            HttpContext context,
            [FromBody] Customers command,
            [FromServices] ICustomersApplication service
            ) =>
        {
            return Results.Text(
                service.CreateCustomers(command).ToString(),
                contentType: "application/json");
        });

        app.MapGet("customer", () => {
            return Results.Text(
                "Ok",
                contentType: "application/json");
        });
    }
}