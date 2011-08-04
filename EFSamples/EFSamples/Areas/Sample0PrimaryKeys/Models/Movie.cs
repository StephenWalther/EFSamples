using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample0PrimaryKeys.Models {
    public class Movie {

        private static Random rnd = new Random();

        public Movie() {
            this.SomeCrazyPKName = rnd.Next(9999);
        }
        
        public int SomeCrazyPKName { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

    }
}