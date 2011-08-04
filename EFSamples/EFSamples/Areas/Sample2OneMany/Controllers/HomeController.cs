using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample2OneMany.Models;

namespace EFSamples.Areas.Sample2OneMany.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Sample2OneMany/Home/

        private DataContext context = new DataContext(); 

        public ActionResult Index()
        {
            var categories = from c in context.Categories.Include("Movies")
                             select c;
            return View(categories);
        }

    }
}
