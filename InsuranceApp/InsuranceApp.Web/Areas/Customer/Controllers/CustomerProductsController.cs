using InsuranceApp.DataAccess.Data;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = SD.Role_Customer)]
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
            // If no products just return the view
            if (_context.InsuranceProducts.Count() == 0)
            {
                return View();
            }
            else
            {
                // Get the list of products from the database
                var products = _context.InsuranceProducts.ToList();

                // Return the view with the list of products as the model
                return View(products);
            }
        }

        public IActionResult Purchase()
        {
            return View();
        }
    }
}
