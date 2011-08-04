using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFSamples.Areas.Sample7Concurrency.Models {


    public class Checking {

        public long Id { get; set; }

        public decimal Balance { get; set; }



        [Timestamp]
        public byte[] Version { get; set; }

    }



}