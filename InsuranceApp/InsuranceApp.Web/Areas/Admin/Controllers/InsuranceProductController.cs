using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class InsuranceProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsuranceProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // View all insurances
        public IActionResult Index()
        {
            var insuranceProducts = _context.InsuranceProducts.Include(i => i.Insurance).Include(i => i.Products).ToList();
            return View(insuranceProducts);
        }

        // GET: InsuranceProduct/Create
        public IActionResult Create()
        {
            var viewModel = new CreateInsuranceProductViewModel
            {
                InsuranceProduct = new InsuranceProduct(),
                Insurances = _context.Insurances.ToList()
            };

            return View(viewModel);
        }

        // POST: InsuranceProduct/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateInsuranceProductViewModel viewModel)
        {
            // Check if the model is valid???
            _context.Add(viewModel.InsuranceProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
