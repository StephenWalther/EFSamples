using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample6Transactions.Models {
    public class DataContext : DbContext {

        public DataContext():base("Sample6") {
            Database.SetInitializer(new MyInitializer());
        }

        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<SavingsAccount> SavingsAccounts { get; set; }
    }

    class MyInitializer : DropCreateDatabaseIfModelChanges<DataContext> {

        protected override void Seed(DataContext context) {

            context.CheckingAccounts.Add(new CheckingAccount { Id = 1, Balance = 500m });
            context.SavingsAccounts.Add(new SavingsAccount { Id = 1, Balance = 500m });

        }

    }

}