using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Models.InsuranceApp.Models;
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

        // Add to cart button
        [HttpPost]
        public async Task<IActionResult> AddToCheckout(Guid id)
        {
            // Get the current user's id
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Get the current user's cart
            var cart = await _context.Carts.FirstOrDefaultAsync(c => c.CustomerId == userId);

            // If the cart doesn't exist, create a new one
            // If the cart doesn't exist, create a new one
            if (cart == null)
            {
                cart = new Cart
                {
                    CustomerId = userId,
                    CartItems = new List<CartItem>()
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            // Create a new CartItem
            var cartItem = new CartItem { CartId = cart.Id, ProductId = id };

            // Add the CartItem to the Cart
            cart.CartItems.Add(cartItem);

            // Save changes
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
