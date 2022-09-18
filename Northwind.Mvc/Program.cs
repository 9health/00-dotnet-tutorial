using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Northwind.Mvc.Data;
using Packt.Shared;

// creates and configures a web host builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//registers an  database context using SQL Server or SQLite with connection string loaded from the appsettings.json 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString)); //SQLite
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// for authentication and configures it to use the application database
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() //enable role management
    .AddEntityFrameworkStores<ApplicationDbContext>();
//adds support for MVC controllers with views
builder.Services.AddControllersWithViews();

builder.Services.AddNorthwindContext(); // load the appropriate connection string and then to register the Northwind database context
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
