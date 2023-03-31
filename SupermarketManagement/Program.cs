using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Plugins.DataStore.InMemory;
using SupermarketManagement.Data;
using UseCases;
using UseCases.UseCaseInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//Dependency Injection for in-memory data
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//Dep. Injection for use cases and repos
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


/*
 * Admins:
 * - Manage categories
 * - Manage products
 * - Manage sellers
 * 
 * Sellers:
 * Selling console
 * 
 */