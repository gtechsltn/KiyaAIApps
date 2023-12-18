using Blazor_ServerApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*Provides Platform for Razor Components to be rendered to Browser*/
builder.Services.AddRazorPages();
/*
    This will provide FIrst-Hand Rendering on Server as (SSR) and respond to Browser
    Further uses SignalR to Render UI Updates only 
 */
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

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
/* Blazor Server-Side Rendering and Update Notification using SignalR*/
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
