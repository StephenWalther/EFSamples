using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample5Inheritance.Models {
    public abstract class Movie {

        public long Id { get; set; }

        public string Title { get; set; }

        public int AverageRating { get; set; }

    }
}