using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample2OneMany.Models {

    public class DataContext : DbContext {


        public DataContext()
            : base("Sample2") {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //modelBuilder.Entity<Category>()
            //    .HasMany(m => m.Movies)
            //    .WithOptional();
        }
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