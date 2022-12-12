using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Week_3_Lab.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Week_3_LabContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Week_3_LabContext") ?? throw new InvalidOperationException("Connection string 'Week_3_LabContext' not found.")));

// Add services to the container.
builder.Services.AddMemoryCache(); // session state
builder.Services.AddSession();

//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(60*5);
//    options.Cookie.HttpOnly = false;
//    options.Cookie.IsEssential = true;
//});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession(); // using session

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

