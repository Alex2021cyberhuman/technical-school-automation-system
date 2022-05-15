using Application;
using Application.AdmissionCommittee.Data;
using Application.AdmissionCommittee.Services.StatementDocument;
using Application.Groups.Data;
using Application.Specialities.Data;
using Blazored.LocalStorage;
using FluentValidation;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (_, factory) =>
        factory.Create(typeof(Resource));
});
builder.Services.AddHttpClient();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddTransient(serviceProvider =>
    (IStringLocalizer)serviceProvider.GetRequiredService<IStringLocalizer<Resource>>());
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton<StatementDocumentCreator>();
SpecialitiesDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
AdmissionCommitteeDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
GroupsDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
var app = builder.Build();
app.UseResourceRequestLocalization();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles(new StaticFileOptions()
    {
        FileProvider = new CompositeFileProvider(
            new PhysicalFileProvider(Path.GetFullPath(builder.Configuration["AdmissionCommittee:ApplicantsTablePath"])),
            new PhysicalFileProvider(Path.GetFullPath(builder.Configuration["AdmissionCommittee:StatementPath"])))
    });
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllers();

await using var scope = app.Services.CreateAsyncScope();
await scope.ServiceProvider.InitializeSpecialitiesDbContextDevelopmentInstallationAsync();
var basePath = builder.Configuration["AdmissionCommittee:StatementPath"];
Directory.CreateDirectory(basePath);
app.Run();