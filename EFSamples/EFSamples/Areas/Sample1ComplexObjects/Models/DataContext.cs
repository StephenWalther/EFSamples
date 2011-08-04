using System.Data.Entity;

namespace EFSamples.Areas.Sample1ComplexObjects.Models {
    public class DataContext: DbContext {


        public DataContext():base("Sample1") {}

        public DbSet<Customer> Customers { get; set; }
    
    }
}