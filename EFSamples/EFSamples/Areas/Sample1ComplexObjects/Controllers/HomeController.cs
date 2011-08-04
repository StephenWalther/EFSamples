using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample1ComplexObjects.Models;

namespace EFSamples.Areas.Sample1ComplexObjects.Controllers
{
    public class HomeController : Controller
    {

        private DataContext context = new DataContext();


        public ActionResult Index()
        {
            var customers = context.Customers.ToList(); 
            return View(customers);
        }

    }
}
