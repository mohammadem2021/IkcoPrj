using IKCOProject.Blazor.Components;
using IKCOProject.Blazor.Components.Contract;
using IKCOProject.Blazor.Components.Services;
using IKCOProject.Blazor.Components.Services.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<HttpClient>(r => new HttpClient
    { BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!) });
builder.Services.AddSingleton<IClient, Client>();
builder.Services.AddScoped<INoteService, NoteService>();
builder.Services.AddBlazorBootstrap();
var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
