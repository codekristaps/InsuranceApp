using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class InsuranceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsuranceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // View all insurances
        public IActionResult Index()
        {
            List<Insurance> insurances = _context.Insurances.ToList();
            return View(insurances);
        }

        // GET: Insurance/Create
        public IActionResult Create()
        {
            return View();
        }

        // Create a new insurance
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Insurance insurance)
        {
            _context.Add(insurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Insurance/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurances
                .FirstOrDefaultAsync(m => m.InsuranceId == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // Edit insurance
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurances.FindAsync(id);
            if (insurance == null)
            {
                return NotFound();
            }
            return View(insurance);
        }

        // POST: Insurance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Insurance insurance)
        {
            // Validate the Model state?
            _context.Update(insurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuranceExists(Guid insuranceId)
        {
            throw new NotImplementedException();
        }

        // POST: Insurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insurance = await _context.Insurances.FindAsync(id);
            _context.Insurances.Remove(insurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
