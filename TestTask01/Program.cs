using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using TestTask01.Data;
using TestTask01.Servisers;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextPool<TestTask01DB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TestTask01DB")));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ControgentServises>();
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
Task.Run(Task01);


Task Task01()
{
    Task.Delay(3000);
    Console.WriteLine("-----------TestTask01DB sdagasghasgha");
    return Task.CompletedTask;
}