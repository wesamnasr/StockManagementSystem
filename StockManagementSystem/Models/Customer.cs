﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int Debt { get; set; } = 0; 
        public string Address { get; set; }

        public virtual ICollection<CustomerBill> Invoices { get; set; }
    }
}
