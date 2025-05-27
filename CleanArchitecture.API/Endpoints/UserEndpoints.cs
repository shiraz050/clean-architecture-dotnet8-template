using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/users").WithTags("Users");

        group.MapGet("/", async (IUserRepository repo) =>
        {
            var users = await repo.GetAllAsync();
            return Results.Ok(users);
        });

        group.MapGet("/{id:guid}", async (Guid id, IUserRepository repo) =>
        {
            var user = await repo.GetByIdAsync(id);
            return user is null ? Results.NotFound() : Results.Ok(user);
        });

        group.MapPost("/", async (User user, IUserRepository repo) =>
        {
            await repo.AddAsync(user);
            return Results.Created($"/users/{user.Id}", user);
        });

        group.MapPut("/{id:guid}", async (Guid id, User updated, IUserRepository repo) =>
        {
            var existing = await repo.GetByIdAsync(id);
            if (existing is null) return Results.NotFound();

            existing.FullName = updated.FullName;
            existing.Email = updated.Email;
            await repo.UpdateAsync(existing);

            return Results.Ok(existing);
        });

        group.MapDelete("/{id:guid}", async (Guid id, IUserRepository repo) =>
        {
            var user = await repo.GetByIdAsync(id);
            if (user is null) return Results.NotFound();

            await repo.DeleteAsync(id);
            return Results.NoContent();
        });
    }
}
