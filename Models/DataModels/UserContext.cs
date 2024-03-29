using Microsoft.EntityFrameworkCore;
 
namespace WeddingPlanner.Models
{
    public class UserContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<Plans> Plans { get; set; }
    }
}
