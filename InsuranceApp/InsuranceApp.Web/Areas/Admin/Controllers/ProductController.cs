using InsuranceApp.DataAccess.Data;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // View all products purchased by customers
        public IActionResult Index()
        {
            var purchases = _context.Products.Include(p => p.InsuranceProduct).ToList();
            return View(purchases);
        }
    }
}
