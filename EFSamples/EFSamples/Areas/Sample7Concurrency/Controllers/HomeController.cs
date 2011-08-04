using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSamples.Areas.Sample7Concurrency.Models;
using System.Data;
using System.Data.Entity.Infrastructure;

namespace EFSamples.Areas.Sample7Concurrency.Controllers
{
    public class HomeController : Controller {
     
        private DataContext db = new DataContext();


        public ActionResult Edit() {
            var account = db.CheckingAccounts.Find(1);
            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(Checking account) {

            try {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException cex) {
                // Reload new value from database
                cex.Entries.Single().Reload();

                // Update model state to show original balance
                ModelState.Clear();
                ModelState.AddModelError("Balance", "Concurrency Exception - you are too slow!");

                return View(account);
            }

            // Get request
            return RedirectToAction("Edit");
        }


    }
}
