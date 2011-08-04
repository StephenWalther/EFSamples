using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample7Concurrency.Models {

    public class DataContext : DbContext {

        public DataContext():base("Sample7") {
            Database.SetInitializer(new MyInitializer());
        }

        public IDbSet<Checking> CheckingAccounts { get; set; }

    }

    class MyInitializer : DropCreateDatabaseIfModelChanges<DataContext> {

        protected override void Seed(DataContext context) {

            context.CheckingAccounts.Add(new Checking { Id = 1, Balance = 500m });

        }

    }


}