using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFSamples.Areas.Sample0PrimaryKeys.Models {
    public class DataContext: DbContext {

        
        public DataContext():base("Sample0") {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Movie> Movies { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
           
            // Set primary key
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.SomeCrazyPKName);

            // Don't use an Identity column for primary key
            modelBuilder.Entity<Movie>()
                .Property(m => m.SomeCrazyPKName)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            // Map Movie class to tblMovie
            modelBuilder.Entity<Movie>()
                .ToTable("tblMovie");

            // Map Director property to "Movie Director" column
            modelBuilder.Entity<Movie>()
                .Property(m => m.Director)
                .HasColumnName("Movie Director");

            // Movie Title only has 50 characters
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .HasMaxLength(50);
        
        } 
    }


    class MyInitializer : DropCreateDatabaseAlways<DataContext> {
        protected override void Seed(DataContext context) {
            
            var movies = new List<Movie> {
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="Star Wars II", Director="Lucas"},
                new Movie {Title="Star Wars III", Director="Lucas"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }

}