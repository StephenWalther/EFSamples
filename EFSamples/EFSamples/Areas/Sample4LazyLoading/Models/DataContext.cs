using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample4LazyLoading.Models {


    public class DataContext : DbContext {

        
        public DataContext()
            : base("Sample4") {
            Database.SetInitializer(new MyInitializer());

            //this.Configuration.LazyLoadingEnabled = false;        
        }

        public DbSet<Category> Categories { get; set; }


    }


    class MyInitializer : DropCreateDatabaseAlways<DataContext> {
        protected override void Seed(DataContext context) {

            var categories = new List<Category> {
                new Category { 
                    Name="SciFi", 
                    Movies = new List<Movie> {
                        new Movie {Title="Star Wars"},
                        new Movie {Title="Aliens"}
                    }
                },
                new Category { 
                    Name="Horror", 
                    Movies = new List<Movie> {
                        new Movie {Title="King Kong"},
                        new Movie {Title="Sixth Sense"}
                    }
                }
            };

            categories.ForEach(m => context.Categories.Add(m));
        }
    }


}