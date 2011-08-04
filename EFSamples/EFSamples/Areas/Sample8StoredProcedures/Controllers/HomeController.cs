using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample8StoredProcedures.Models;

namespace EFSamples.Areas.Sample8StoredProcedures.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context = new DataContext();

        public ActionResult Index()
        {
            var movies = context.Movies.SqlQuery("GetMovies");
            return View(movies);
        }


        public ActionResult Index2() {
            var movies = context.Database.SqlQuery<BriefMovie>("GetBriefMovies");
            return View(movies);
        }


        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movieToCreate) {
            if (ModelState.IsValid) {
                context.Database.ExecuteSqlCommand("Execute CreateMovie {0}, {1}, {2}", movieToCreate.Title, movieToCreate.Director, movieToCreate.DateReleased);
                return RedirectToAction("Index");
            }
            return View(movieToCreate);
        }

    }
}
