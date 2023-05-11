using Microsoft.EntityFrameworkCore;

namespace Resturant_System.Model
{
    public class CustomerDB_Context : DbContext
    {


        public CustomerDB_Context(DbContextOptions<CustomerDB_Context> options): base(options)
        { 
             
        
        }

        public DbSet<Customer> customer { get; set;} 
        public DbSet<Product> products { get; set;}
    }
}
