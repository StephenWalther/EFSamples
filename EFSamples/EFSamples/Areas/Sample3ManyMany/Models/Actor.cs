using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample3ManyMany.Models {
    public class Actor {

        public long Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}