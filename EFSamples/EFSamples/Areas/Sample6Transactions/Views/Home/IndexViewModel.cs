using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFSamples.Areas.Sample6Transactions.Models;

namespace EFSamples.Areas.Sample6Transactions.Views.Home {

    public class IndexViewModel {

        public SavingsAccount SavingsAccount { get; set; }

        public CheckingAccount CheckingAccount { get; set; }

    }

}