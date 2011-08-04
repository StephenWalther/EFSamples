using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample4LazyLoading.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace EFSamples.Areas.Sample4LazyLoading.Controllers
{

    public class HomeController : Controller {
     
        private DataContext context = new DataContext();

        
        // Throws exception because movies is null
        public ActionResult Index() {
            var categories = from c in context.Categories
                             select c;

            DumpSql<Category>(categories);   

            return View(categories);
        }


        // Lazy loads
        public ActionResult Index2() {
            var categories = from c in context.Categories
                             select c;

            foreach (var category in categories) {
                var movies = category.Movies;
            }

            return View("Index", categories);
        }



        // Eager loading
        public ActionResult Index3() {
            var categories = from c in context.Categories.Include(c=>c.Movies)
                             select c;
            return View("Index", categories);
        }


        // Explicit loading
        public ActionResult Index4() {
            
            var categories = from c in context.Categories
                             select c;
            
            foreach (var category in categories) {
                context.Entry(category).Collection( c => c.Movies ).Load();
            }

            return View("Index", categories);
        }


        public void DumpSql<T>(IQueryable query) {
            var sql = ((DbQuery<T>)query).ToString();
            System.Diagnostics.Debug.WriteLine(sql);
        }



    }





}
