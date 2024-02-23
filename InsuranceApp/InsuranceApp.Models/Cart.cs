﻿using InsuranceApp.Models.InsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class Cart
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CustomerId { get; set; } // need to check this
        public List<CartItem> CartItems { get; set; }
    }
}