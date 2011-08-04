using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample3ManyMany.Models;

namespace EFSamples.Areas.Sample3ManyMany.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Sample3ManyMany/Home/

        private DataContext context = new DataContext();

        public ActionResult Index()
        {
            var movies = from m in context.Movies
                         select m;
            return View(movies);
        }

    }
}
