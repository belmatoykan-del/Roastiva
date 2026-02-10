using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Roastiva.DataAccess.Data;
using Roastiva.DataAccess.Repository.IRepository;
using Roastiva.DataAccess.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UygulamaDbContext>(options => // DbContext i�in servis ekliyoruz
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // SQL Server kullanarak ba�lant� dizesini yap�land�r�yoruz
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<UygulamaDbContext>().AddDefaultTokenProviders();
builder.Services.AddRazorPages(); // Razor Pages deste�i ekliyoruz

// Dikkat: Yeni bir reporitory ekledi�inizde, burada da ilgili servisi eklemeniz gerekir.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // Generic repository servisi


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
