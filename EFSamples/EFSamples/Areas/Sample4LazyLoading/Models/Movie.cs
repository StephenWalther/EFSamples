using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample4LazyLoading.Models {

    public class Movie {

        public long Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }

}