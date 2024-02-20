using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public enum OrderStatus
    {
        Open,
        Cancelled,
        Fulfilled
    }

    public class Order
    {
        public Guid Id { get; set; } // Changed from int to Guid
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key for InsuranceCustomer
        public string CustomerId { get; set; }

        // Navigation property for InsuranceCustomer
        public InsuranceCustomer Customer { get; set; }
    }
}