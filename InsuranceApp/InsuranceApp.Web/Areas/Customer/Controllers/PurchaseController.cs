using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Web.Helpers;

namespace InsuranceApp.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.InsuranceProducts.ToList();
            return View(products);
        }

        // Add product to the cart when I click on the Add to Cart button
        [HttpPost]
        public async Task<IActionResult> AddProductToCart(Guid insuranceProductId, Guid customerId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.CustomerId == customerId);

            if (cart == null)
            {
                cart = new Cart { CustomerId = customerId, ProductId = insuranceProductId };
                _context.Carts.Add(cart);
            }
            else
            {
                cart.ProductId = insuranceProductId;
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
