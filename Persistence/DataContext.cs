using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    // This will be used as a service, so needs to be injected
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Adds the table to the DB
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, name = "Value 101"},
                    new Value {Id = 2, name = "Value 102"},
                    new Value {Id = 3, name = "Value 103"},
                    new Value {Id = 4, name = "Value 104"}
                );
        }
    }
}