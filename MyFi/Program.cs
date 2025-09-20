using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyFiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => 
options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MyFiDbContext>();

// Protect the Admin folder
//builder.Services.AddAuthorization(o =>
//{
//    o.AddPolicy("RequireAdmin", p => p.RequireRole("Admin"));
//});
//builder.Services.AddRazorPages(o =>
//{
//    o.Conventions.AuthorizeFolder("/Admin", "RequireAdmin");
//});

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
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.MapGet("/", async (HttpContext context) =>
{
    if (context.User?.Identity?.IsAuthenticated == true)
    {
        // Already logged in
        return Results.Redirect("/Home/Index");
        //return Results.Redirect("/Dashboard");
    }
    else 
    {
        // Needs to login
        return Results.Redirect("/Identity/Account/Login");
        //return Results.Redirect("/LandingIndex");
    }
});

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await MyFi.Data.Infrastructure.DataSeeders.RoleSeeder.SeedRolesAsync(roleManager);
}

app.Run();