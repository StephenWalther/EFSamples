using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample8StoredProcedures.Models {
    public class Movie {

        public long Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime DateReleased { get; set; }

    }
}