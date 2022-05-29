using Application.Access.Data;
using Application.Access.Enums;
using Application.Access.Services;
using AspNetCore.Identity.Localization.Core;
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
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        var baseUser = new User();
        var createBaseUserFlag = app.Configuration.GetSection("BaseUser:Create").Get<bool>();

        if (!createBaseUserFlag)
            return;

        app.Configuration.GetSection("BaseUser").Bind(baseUser);
        var roles = new List<string>();
        app.Configuration.GetSection("BaseUser:Roles").Bind(roles);
        var password = app.Configuration["BaseUser:Password"];
        try
        {
            foreach (var role in RoleIdentifiers.Roles) await roleManager.CreateAsync(new Role(role));
            var result = await userManager.CreateAsync(baseUser, password);
            baseUser = await userManager.FindByNameAsync(baseUser.UserName);
            await userManager.AddToRolesAsync(baseUser, roles);
            if (result.Succeeded)
                logger.LogInformation("BaseUser created {UserName} with roles {Roles}", baseUser.UserName, roles);
        }
        catch (Exception e)
        {
            logger.LogError(e, "Some error");
        }
    }

    public static void AddAccess(this WebApplicationBuilder builder)
    {
        AccessDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
        builder.Services.AddScoped(services =>
            services.GetRequiredService<IDbContextFactory<AccessDbContext>>().CreateDbContext());
        builder.Services.AddAuthentication();
        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy(PolicyIdentifiers.Default, policyBuilder =>
                policyBuilder.RequireAuthenticatedUser());
            options.DefaultPolicy = options.GetPolicy(PolicyIdentifiers.Default)!;
            foreach (var (policy, roles) in PolicyIdentifiers.PolicyRoles)
                options.AddPolicy(policy,
                    policyBuilder => policyBuilder.Combine(options.GetPolicy(PolicyIdentifiers.Default)!)
                        .RequireRole(roles));
        });
        builder.Services.AddIdentityLocalization();
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
            .AddClaimsPrincipalFactory<MyUserClaimsPrincipalFactory>()
            .AddEntityFrameworkStores<AccessDbContext>()
            .AddIdentityErrorDescriber();
    }
}