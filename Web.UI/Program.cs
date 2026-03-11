
using Infrastructure.Plugins1.Context;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Plugins.InMemory;
using UseCase.Inventories;
using UseCase.PluginInterface;
using Web.UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
//builder.Services.AddSingleton
builder.Services.AddTransient<IViewInventortiesByNameUseCase, ViewInventortiesByNameUseCase>();
builder.Services.AddMudServices();
builder.Services.AddDbContextFactory<DemoDatabase>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builer.Services.AddTransient 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
