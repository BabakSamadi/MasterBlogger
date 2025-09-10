using Application;
using Application.Contracts;
using Domain.ArticleCategoryAgg;
using infrastracture_Services.Config;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// خواندن ConnectionString
var Connectionstring = builder.Configuration.GetConnectionString("MasterBlog");

// فراخوانی bootstrtaper config

var bootstrapper = new Bootstrapper();
bootstrapper.config(builder.Services, Connectionstring);

// Add services to the container.
builder.Services.AddRazorPages();

    
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

app.UseAuthorization();


app.MapRazorPages();
//app.UseEndpoints(endpoint =>
//{
//    endpoint.MapRazorPages();
//    endpoint.MapDefaultControllerRoute();
//});

app.Run();
