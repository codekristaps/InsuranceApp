using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Models.InsuranceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        
    }
}
