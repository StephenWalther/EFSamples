using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFSamples.Areas.Sample5Inheritance.Models {


    public class DataContext : DbContext {


        public DataContext()
            : base("Sample5") {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Movie> Movies { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            // Table Per Hierarchy (TPH) (Default)


            // Table Per Type (TPT)
            modelBuilder.Entity<SciFiMovie>().ToTable("SciFiMovies");
            modelBuilder.Entity<ActionMovie>().ToTable("ActionMovies");


            // Table Per Concrete Type (TPC)
            //modelBuilder.Entity<SciFiMovie>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("SciFiMovies");
            //});

            //modelBuilder.Entity<ActionMovie>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("ActionMovies");
            //});

            //modelBuilder.Entity<Movie>()
            //.Property(m => m.Id)
            //.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }


    class MyInitializer : DropCreateDatabaseAlways<DataContext> {
        protected override void Seed(DataContext context) {

            var starWars = new SciFiMovie {
                Id = 1,
                Title = "Star Wars",
                RobotCount = 59
            };


            var dieHard = new ActionMovie {
                Id = 2,
                Title="Die Hard",
                ExplosionsPerSecond=9
            };

            context.Movies.Add(starWars);
            context.Movies.Add(dieHard);
        
        }
    }


}