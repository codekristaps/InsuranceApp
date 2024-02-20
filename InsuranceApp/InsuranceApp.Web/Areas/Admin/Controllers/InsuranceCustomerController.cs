using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using InsuranceApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class InsuranceCustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        // for managing roles
        private readonly UserManager<InsuranceCustomer> _userManager;

        public InsuranceCustomerController(ApplicationDbContext context, UserManager<InsuranceCustomer> userManager)
        {
            _context = context;
            // for managing roles
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Retrieve all InsuranceCustomer users from the database
            var customers = await _userManager.Users.OfType<InsuranceCustomer>().ToListAsync();

            foreach (var customer in customers)
            {
                // Retrieve the roles for each customer
                customer.Roles = await _userManager.GetRolesAsync(customer);
            }

            // Pass the list of customers to the view
            return View(customers);
        }

        // GET: InsuranceCustomer/Delete/
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuranceCustomer = await _context.InsuranceCustomer
                .FirstOrDefaultAsync(m => m.Id == id);

            if (insuranceCustomer == null)
            {
                return NotFound();
            }

            return View(insuranceCustomer);
        }

        // POST: InsuranceCustomer/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var insuranceCustomer = await _context.InsuranceCustomer.FindAsync(id);
            _context.InsuranceCustomer.Remove(insuranceCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: InsuranceCustomer/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuranceCustomer = await _context.InsuranceCustomer.FindAsync(id);
            if (insuranceCustomer == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(insuranceCustomer.Id);
            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                insuranceCustomer.Roles = roles;
            }

            return View(insuranceCustomer);
        }

        // POST: InsuranceCustomer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,FirstName,LastName,Email,EmailConfirmed,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,Roles")] InsuranceCustomer model)
        {

            // Get the existing customer from the database
            var existingCustomer = await _context.InsuranceCustomer.FindAsync(model.Id);

            if (existingCustomer == null)
            {
                return NotFound();
            }

            // Update the properties
            existingCustomer.FirstName = model.FirstName;
            existingCustomer.LastName = model.LastName;
            existingCustomer.Email = model.Email;
            existingCustomer.EmailConfirmed = model.EmailConfirmed;
            existingCustomer.PhoneNumber = model.PhoneNumber;
            existingCustomer.PhoneNumberConfirmed = model.PhoneNumberConfirmed;
            existingCustomer.TwoFactorEnabled = model.TwoFactorEnabled;

            // Save the changes
            _context.Update(existingCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuranceCustomerExists(string id)
        {
            return _context.InsuranceCustomer.Any(e => e.Id == id);
        }
    }
}
