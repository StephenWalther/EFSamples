using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Transactions;
using EFSamples.Areas.Sample6Transactions.Models;
using EFSamples.Areas.Sample6Transactions.Views.Home;

namespace EFSamples.Areas.Sample6Transactions.Controllers {
    public class HomeController : Controller {

        private DataContext db = new DataContext();


        public ActionResult Index() {
            var vm = new IndexViewModel {
                CheckingAccount = db.CheckingAccounts.Find(1),
                SavingsAccount = db.SavingsAccounts.Find(1)
            };

            return View(vm);
        }

        public ActionResult TransferFromCheckingsToSavings() {

            // Remove $5.00 from checking
            var checkingAccount = db.CheckingAccounts.Find(1);
            checkingAccount.Balance -= 5.00m;

            // Throw Exception
            //throw new Exception("Yikes!");

            // Add $5.00 to savings
            var savingsAccount = db.SavingsAccounts.Find(1);
            savingsAccount.Balance += 5.00m;

            // Save changes as part of natural transaction
            db.SaveChanges();


            return RedirectToAction("Index");
        }



        public ActionResult TransferFromSavingsToChecking() {

            // You need to add the assembly System.Transactions.dll to use 
            // TransactionScope

            using (var scope = new TransactionScope()) {

                // Remove $5.00 from savings
                var savingsAccount = db.SavingsAccounts.Find(1);
                savingsAccount.Balance -= 5.00m;
                db.SaveChanges();

                // Throw Exception
                //throw new Exception("Yikes!");

                // Add $5.00 to checking
                var checkingAccount = db.CheckingAccounts.Find(1);
                checkingAccount.Balance += 5.00m;
                db.SaveChanges();

                // Commit Transaction
                scope.Complete();
            }

            return RedirectToAction("Index");
        }


    }
}
