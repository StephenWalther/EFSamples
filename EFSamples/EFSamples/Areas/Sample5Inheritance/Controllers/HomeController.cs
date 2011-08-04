using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample5Inheritance.Models;

namespace EFSamples.Areas.Sample5Inheritance.Controllers
{
    public class HomeController : Controller
    {
        
        private DataContext context = new DataContext();

        public ActionResult Index()
        {
            var movies = from m in context.Movies 
                         select m;

            return View(movies.ToList());
        }


        // Only SciFi Movies
        public ActionResult Index2() {
            var movies = from m in context.Movies.OfType<SciFiMovie>()
                         select m;

            return View("Index", movies.ToList());
        }


    }
}
