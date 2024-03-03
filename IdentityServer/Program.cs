using IdentityServer;
using IdentityServer.Data;
using IdentityServer.DbInitializer;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthConString"));
});
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IDbInitializer, DbInitializer>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 0;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
});

builder.Services.AddIdentityServer(options => {
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;
    options.Events.RaiseFailureEvents = true;

}).AddInMemoryIdentityResources(SD.IdentityResources).AddInMemoryApiScopes(SD.GetApiScopes).AddInMemoryClients(SD.Clients)
   .AddAspNetIdentity<ApplicationUser>().AddDeveloperSigningCredential();
builder.Services.AddRazorPages();

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
app.UseIdentityServer();
app.MapRazorPages();
app.UseAuthorization();
//app.MapRazorPages();//.RequireAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//SeedDataase();
app.Run();
//void SeedDataase()
//{
//    using (var scope = app.Services.CreateScope())
//    {
//        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
//        dbInitializer.Initialize();
//    }
//}




