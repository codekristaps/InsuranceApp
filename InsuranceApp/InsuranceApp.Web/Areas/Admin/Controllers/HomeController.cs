using InsuranceApp.DataAccess.Data;
using InsuranceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace InsuranceApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // injecting ApplicationDbContext
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context; // Injecting ApplicationDbContext
        }

        public async Task<IActionResult> Index()
        {
            var lastMonth = DateTime.Now.AddMonths(-1).Month;
            var thisMonth = DateTime.Now.Month;

            var totalSalesLastMonth = await _context.Orders
                .Where(o => o.OrderDate.Month == lastMonth)
                .SumAsync(o => o.TotalAmount);

            var totalSalesThisMonth = await _context.Orders
                .Where(o => o.OrderDate.Month == thisMonth)
                .SumAsync(o => o.TotalAmount);

            decimal growthRate = 0;

            if (totalSalesLastMonth > 0)
            {
                growthRate = ((totalSalesThisMonth - totalSalesLastMonth) / totalSalesLastMonth) * 100;
            }

            var model = new AdminDashboardViewModel
            {
                TotalInsuranceCount = await _context.Insurances.CountAsync(),
                TotalInsuranceProductsCount = await _context.InsuranceProducts.CountAsync(),
                TotalUsersCount = await _context.Users.CountAsync(),
                TotalOrdersCount = await _context.Orders.CountAsync(),
                TotalSalesAmount = (double)totalSalesThisMonth,
                TotalSalesLastMonth = (double)totalSalesLastMonth,
                GrowthRate = growthRate
            };

            return View(model);
        }
    }
}
