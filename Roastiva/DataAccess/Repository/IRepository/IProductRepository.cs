using Roastiva.Models;

namespace Roastiva.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }


}
