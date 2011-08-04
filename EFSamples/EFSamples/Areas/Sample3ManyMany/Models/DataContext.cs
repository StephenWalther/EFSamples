using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFSamples.Areas.Sample3ManyMany.Models {


    public class DataContext : DbContext {


        public DataContext()
            : base("Sample3") {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //modelBuilder.Entity<Movie>()
            //    .HasMany(m => m.Actors)
            //    .WithMany(a => a.Movies)
            //    .Map(m =>
            //    {
            //        m.ToTable("JoinMoviesActors");
            //        m.MapLeftKey("MovieIdentifier");
            //        m.MapRightKey("ActorIdentifier");
            //    });
        }
    }


    class MyInitializer : DropCreateDatabaseAlways<DataContext> {
        protected override void Seed(DataContext context) {

            var harrisonFord = new Actor { Name = "Harrison Ford"};
            var carrieFisher = new Actor { Name = "Carrie Fisher" };

            var movies = new List<Movie> {
                new Movie { 
                    Title="Star Wars", 
                    Actors = new List<Actor> {
                        harrisonFord,
                        carrieFisher
                    }
                },
                new Movie { 
                    Title="Cowboys versus Aliens", 
                    Actors = new List<Actor> {
                        harrisonFord
                    }
                }
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }



}