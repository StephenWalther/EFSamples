using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFSamples.Areas.Sample2OneMany.Models {
    public class Movie {

        public long Id { get; set; }

        public string Title { get; set; }

        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
