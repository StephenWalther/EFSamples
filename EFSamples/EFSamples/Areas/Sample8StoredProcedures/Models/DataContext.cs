using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample8StoredProcedures.Models {
    public class DataContext: DbContext {

        public DataContext() : base("MoviesDB") { }


        public DbSet<Movie> Movies { get; set; }
    }
}