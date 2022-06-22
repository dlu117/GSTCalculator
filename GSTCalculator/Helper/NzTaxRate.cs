using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTCalculator.Helper
{
    public class NzTaxRate
    {
        public decimal nzrate { get; set; }

        // Intializing class
        public NzTaxRate(decimal x)
        {
            nzrate = x;
        }
    }
}