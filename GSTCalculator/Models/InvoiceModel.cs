using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTCalculator.Models
{
    public class Invoice
    {
        public decimal Amount { get; set; }
        public decimal NZTaxRate { get; set; }
    }
}