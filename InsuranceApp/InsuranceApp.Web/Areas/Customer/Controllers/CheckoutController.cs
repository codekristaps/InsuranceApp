using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InsuranceApp.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = SD.Role_Customer)]
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(Guid customerId)
        {
            var cart = _context.Carts
                .Include(c => c.InsuranceProduct)
                .FirstOrDefault(c => c.CustomerId == customerId);

            if (cart == null)
            {
                // Handle the case where the cart is not found
                return NotFound();
            }

            return View(cart);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(Guid customerId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.CustomerId == customerId);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CancelOrder(Guid customerId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.CustomerId == customerId);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}