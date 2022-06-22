using GSTCalculator.Helper;
using GSTCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTCalculator.Controllers
{
    public class HomeController : Controller
    {   

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public ActionResult Form(List<Invoice> orders)
        {
            var calculator = new TaxCalculator();
            var result = calculator.CalculateGST(orders);
            ViewBag.Invoice = orders.Count;
            ViewBag.Result = result;
            return View("Index");
        }
    }
}