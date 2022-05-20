using Application;
using Application.AdmissionCommittee.Data;
using Application.AdmissionCommittee.Services.ApplicantsTable;
using Application.AdmissionCommittee.Services.EnrolledStudentsTable;
using Application.AdmissionCommittee.Services.StatementDocument;
using Application.Groups.Data;
using Application.Specialities.Data;
using Application.Startup;
using Blazored.LocalStorage;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Localization;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllers().AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (_, factory) =>
        factory.Create(typeof(Resource));
});
builder.Services.AddHttpClient();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddTransient(serviceProvider =>
    (IStringLocalizer)serviceProvider.GetRequiredService<IStringLocalizer<Resource>>());
builder.Services.AddServerSideBlazor();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton<StatementDocumentCreator>();
builder.Services.AddSingleton<ApplicantsTableCreator>();
builder.Services.AddSingleton<EnrolledStudentsTableCreator>();
SpecialitiesDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
AdmissionCommitteeDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
GroupsDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
builder.AddAccess();
builder.Services.AddMudServices();
var app = builder.Build();

app.UseResourceRequestLocalization();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

var applicantsTablePath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:ApplicantsTablePath"]);
Directory.CreateDirectory(applicantsTablePath);

var statementPath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:StatementPath"]);
Directory.CreateDirectory(statementPath);

var enrolledPath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:EnrolledStudentsTablePath"]);
Directory.CreateDirectory(enrolledPath);

var wwwrootPath = Path.GetFullPath("./wwwroot/");
Directory.CreateDirectory(wwwrootPath);

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "",
    FileProvider = new CompositeFileProvider(
        new PhysicalFileProvider(wwwrootPath),
        new PhysicalFileProvider(applicantsTablePath),
        new PhysicalFileProvider(statementPath),
        new PhysicalFileProvider(enrolledPath))
});
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await using var scope = app.Services.CreateAsyncScope();
await scope.ServiceProvider.InitializeSpecialitiesDbContextDevelopmentInstallationAsync();
await app.InitializeAccessAsync();
await scope.ServiceProvider.GetRequiredService<IDbContextFactory<AdmissionCommitteeDbContext>>().CreateDbContext()
    .Database.MigrateAsync();
await scope.ServiceProvider.GetRequiredService<IDbContextFactory<GroupsDbContext>>().CreateDbContext()
    .Database.MigrateAsync();

app.Run();