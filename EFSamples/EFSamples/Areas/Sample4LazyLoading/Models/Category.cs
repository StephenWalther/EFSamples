using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample4LazyLoading.Models {
    public class Category {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}