using Application.Access.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Startup;

public static class StartupAccessExtensions
{
    public static async Task InitializeAccessAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        await using var context = scope.ServiceProvider.GetRequiredService<AccessDbContext>();
        await context.Database.MigrateAsync();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        var baseUser = new User();
        app.Configuration.GetSection("BaseUser").Bind(baseUser);
        var roles = new List<string>();
        app.Configuration.GetSection("BaseUser:Roles").Bind(roles);
        var password = app.Configuration["BaseUser:Password"];
        try
        {
            await userManager.CreateAsync(baseUser, password);
            await userManager.AddToRolesAsync(baseUser, roles);
            logger.LogInformation("BaseUser created {UserName} with roles {Roles}", baseUser.UserName, roles);
        }
        catch (Exception e)
        {
            logger.LogError(e, "Probably base user already created");
        }
    }

    public static void AddAccess(this WebApplicationBuilder builder)
    {
        AccessDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
        builder.Services.AddScoped(services =>
            services.GetRequiredService<IDbContextFactory<AccessDbContext>>().CreateDbContext());
        builder.Services.AddAuthentication();
        builder.Services.AddAuthorization();
        builder.Services.AddIdentity<User, Role>(options =>
            {
                options.Password = new()
                {
                    RequireDigit = false,
                    RequireLowercase = false,
                    RequireUppercase = false,
                    RequireNonAlphanumeric = false
                };
                options.User.AllowedUserNameCharacters =
                    "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddEntityFrameworkStores<AccessDbContext>();
    }
}