using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalInsuranceCount { get; set; }
        public int TotalInsuranceProductsCount { get; set; }
        public int TotalUsersCount { get; set; }
        public int TotalOrdersCount { get; set; }
        public double TotalSalesAmount { get; set; }
        public double TotalSalesLastMonth { get; set; }
        public decimal GrowthRate { get; set; }
    }
}
