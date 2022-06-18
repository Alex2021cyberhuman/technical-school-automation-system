using Application;
using Application.AdmissionCommittee.Services.ApplicantsTable;
using Application.AdmissionCommittee.Services.EnrolledStudentsTable;
using Application.AdmissionCommittee.Services.StatementDocument;
using Application.Common.Services;
using Application.Data;
using Application.Schedules.Data;
using Application.Schedules.Services.GroupsSchedule;
using Application.Schedules.Services.ReplacementSchedule;
using Application.Schedules.Services.TeacherReplacementSchedule;
using Application.Schedules.Services.TeacherSchedule;
using Application.Specialities.Data;
using Application.Startup;
using Application.Teachers.Services.MonthProofreadingTeacherLoads;
using Application.Teachers.Services.ProofreadingTeacherLoadVacancies;
using Blazored.LocalStorage;
using FluentValidation;
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
builder.Services.AddSingleton<MonthProofreadingTeacherLoadsCreator>();
builder.Services.AddSingleton<ProofreadingTeacherLoadVacanciesCreator>();
MainDbContext.AddToServices(builder.Services, builder.Configuration, builder.Environment);
builder.AddAccess();
builder.Services.AddSingleton<MonthsService>();
builder.Services.AddMudServices();
builder.Services.AddSingleton<WeekSeparationService>();
builder.Services.AddSingleton<TeacherScheduleGenerator>();
builder.Services.AddSingleton<GroupsScheduleGenerator>();
builder.Services.AddSingleton<ReplacementScheduleGenerator>();
builder.Services.AddSingleton<TeacherReplacementScheduleGenerator>();

var app = builder.Build();

app.UseResourceRequestLocalization();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

var tempFiles = Path.GetFullPath(builder.Configuration["TempFilesPath"]);
Directory.CreateDirectory(tempFiles);

var applicantsTablePath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:ApplicantsTablePath"]);
Directory.CreateDirectory(applicantsTablePath);

var statementPath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:StatementPath"]);
Directory.CreateDirectory(statementPath);

var enrolledPath = Path.GetFullPath(builder.Configuration["AdmissionCommittee:EnrolledStudentsTablePath"]);
Directory.CreateDirectory(enrolledPath);

var proofreadingTeacherLoadVacanciesPath =
    Path.GetFullPath(builder.Configuration["AdmissionCommittee:ProofreadingTeacherLoadVacanciesPath"]);
Directory.CreateDirectory(proofreadingTeacherLoadVacanciesPath);

var monthProofreadingTeacherLoadsPath =
    Path.GetFullPath(builder.Configuration["AdmissionCommittee:MonthProofreadingTeacherLoadsPath"]);
Directory.CreateDirectory(monthProofreadingTeacherLoadsPath);

var wwwrootPath = Path.GetFullPath("./wwwroot/");
Directory.CreateDirectory(wwwrootPath);

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "",
    FileProvider = new CompositeFileProvider(
        new PhysicalFileProvider(wwwrootPath),
        new PhysicalFileProvider(tempFiles),
        new PhysicalFileProvider(applicantsTablePath),
        new PhysicalFileProvider(statementPath),
        new PhysicalFileProvider(enrolledPath),
        new PhysicalFileProvider(proofreadingTeacherLoadVacanciesPath),
        new PhysicalFileProvider(monthProofreadingTeacherLoadsPath))
});
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await using var scope = app.Services.CreateAsyncScope();
await app.InitializeAccessAsync();
await scope.ServiceProvider.InitializeMainDbContextDevelopmentInstallationAsync();

app.Run();