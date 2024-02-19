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
            var insuranceProducts = _context.InsuranceProducts.Include(i => i.Insurance).ToList();
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

        // Why I can't validate?
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateInsuranceProductViewModel viewModel)
        {
            // Check if the model is valid???
            _context.Add(viewModel.InsuranceProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET the InsuranceProduct to delete
        public async Task<IActionResult> Delete(Guid? id)
        {
            var insuranceProduct = await _context.InsuranceProducts
                .FirstOrDefaultAsync(m => m.InsuranceProductId == id);
            return View(insuranceProduct);
        }

        // POST to delete the InsuranceProduct
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuranceProduct = await _context.InsuranceProducts.FindAsync(id);
            _context.InsuranceProducts.Remove(insuranceProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: InsuranceProducts/Edit/5
        public async Task<IActionResult> Edit(Guid? id, Guid? insuranceId)
        {
            var insuranceProduct = await _context.InsuranceProducts.FindAsync(id);

            // Populate ViewBag.InsuranceId with a list of Insurances
            var insurances = _context.Insurances.ToList();
            ViewBag.InsuranceId = new SelectList(insurances, "InsuranceId", "Name", insuranceId);
            return View(insuranceProduct);
        }

        // POST: InsuranceProducts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("InsuranceProductId,Name,Description,Price,Discount,ImageUrl,InsuranceId")] InsuranceProduct insuranceProduct)
        {
            _context.Update(insuranceProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}