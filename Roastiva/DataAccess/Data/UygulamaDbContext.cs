using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Roastiva.Models;

namespace Roastiva.DataAccess.Data
{
    public class UygulamaDbContext : IdentityDbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) // base sınıfın yapıcı metodunu çağır
        {
        }
        public DbSet<Product> Products { get; set; }  // Ürünler tablosu



    }
}



