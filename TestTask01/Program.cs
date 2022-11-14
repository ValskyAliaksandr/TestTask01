using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TestTask01.Data;
using TestTask01.Servisers;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextPool<TestTask01DB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TestTask01DB1")));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ControgentServises>();
builder.Services.AddScoped<PolzovatelServises>();
builder.Services.AddScoped<IPolzovatelServises, PolzovatelServises>();
builder.Services.AddScoped<IControgentServises, ControgentServises>();

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

