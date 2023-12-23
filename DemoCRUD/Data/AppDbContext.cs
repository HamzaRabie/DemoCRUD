using DemoCRUD.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public AppDbContext( DbContextOptions options ) : base( options ) { }
        
    }
}
