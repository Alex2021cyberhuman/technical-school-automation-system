using Application;
using Application.AdmissionCommittee.Data;
using Application.Specialities.Data;
using Blazored.LocalStorage;
using FluentValidation;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddTransient(serviceProvider => (IStringLocalizer)serviceProvider.GetRequiredService<IStringLocalizer<Resource>>());
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
builder.Services.AddBlazoredLocalStorage();
SpecialitiesDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
AdmissionCommitteeDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
var app = builder.Build();
app.UseResourceRequestLocalization();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
await using var scope = app.Services.CreateAsyncScope();
await scope.ServiceProvider.InitializeSpecialitiesDbContextDevelopmentInstallationAsync();
app.Run();