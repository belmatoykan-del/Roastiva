
using Microsoft.AspNetCore.Mvc;
using Roastiva.DataAccess.Repository.IRepository;
using System.Linq;

namespace Roastiva.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            var products = _productRepo.GetAll()
                                       .Where(x => x.IsActive)
                                       .ToList();

            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _productRepo
                .GetFirstOrDefault(p => p.Id == id && p.IsActive);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}

