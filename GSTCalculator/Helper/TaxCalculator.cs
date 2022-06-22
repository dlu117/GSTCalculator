using GSTCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTCalculator.Helper
{
    public class TaxCalculator
    {
        public Dictionary<NzTaxRate,decimal> CalculateGST(List<Invoice> orders)
        {
            var result = new Dictionary<NzTaxRate, decimal>();
  
           
            List<decimal> k = new List<decimal>();
            List<decimal> v = new List<decimal>();
            for (int i = 0; i < orders.Count; i++)
            {
                var invoice = orders[i];
                if (k.Contains(invoice.NZTaxRate)){  // if NZTaxRate already in list 
                    int index = k.FindIndex(a => a == invoice.NZTaxRate);
                    v[index]+= invoice.Amount;
                }
                else {
                    k.Add(invoice.NZTaxRate);  // if NZTaxRate not in list
                    v.Add(invoice.Amount);
                }
       
            }
            // GST Calculation
            for (int i = 0; i < k.Count; i++)
            {
                var nztaxkey = new NzTaxRate(k[i]) ;
                result.Add(nztaxkey, v[i]*k[i]);
            }
         return result;
        }

    }
}