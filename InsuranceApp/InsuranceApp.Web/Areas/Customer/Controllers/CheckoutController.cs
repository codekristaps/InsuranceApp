using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Models.InsuranceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InsuranceApp.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Cart _cart;

        public CheckoutController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }

        public IActionResult Index()
        {
            var cartItems = _cart.CartItems ?? new List<CartItem>(); // Ensure CartItems is not null
            _cart.CartItems = cartItems;
            return View(_cart);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id) // Change Guid to int
        {
            var cartItem = _cart.CartItems.FirstOrDefault(i => i.Id == id);
            if (cartItem != null)
            {
                _cart.CartItems.Remove(cartItem);
                // You might need to update your Cart service to persist these changes
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CancelOrder()
        {
            _cart.CartItems.Clear();
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}