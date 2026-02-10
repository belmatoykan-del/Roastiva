using Roastiva.DataAccess.Data;
using Roastiva.DataAccess.Repository.IRepository;
using Roastiva.Models;

namespace Roastiva.DataAccess.Repository.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository // ProductRepository, Repository<Product> arayüzlerini uygular
    {
        private readonly UygulamaDbContext _context; // UygulamaDbContext türünde özel bir alan

        public ProductRepository(UygulamaDbContext context) : base(context) // Yapıcı metod, base sınıfın yapıcı metodunu çağırır
        {
            _context = context;
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }

}
