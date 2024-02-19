using InsuranceApp.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // View all insurances
        public IActionResult Index()
        {
            // Get the list of products from the database
            var products = _context.InsuranceProducts.Include(p => p.Products).ToList();

            // Return the view with the list of products as the model
            return View(products);
        }
    }
}
