using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample3ManyMany.Models {
    public class Movie {

        public long Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

    }
}