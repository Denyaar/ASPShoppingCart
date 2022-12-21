using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShoppingCartDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShoppingCartConString")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//seeding data seeders
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<ShoppingCartDataContext>();
SeedData.SeedDatabase(context);

app.Run();