using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample0PrimaryKeys.Models;

namespace EFSamples.Areas.Sample0PrimaryKeys.Controllers
{
    public class HomeController : Controller
    {

        private DataContext context = new DataContext();


        public ActionResult Index() {
            var movies = context.Movies.ToList();
            return View(movies);
        }


    }
}
