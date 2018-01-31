using Microsoft.EntityFrameworkCore;
 
namespace dojoTest.Models
{
    public class DojoContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DojoContext(DbContextOptions<DojoContext> options) : base(options) { }
        //<User> stands for Module , Users stands for table name of db table
        public DbSet<User> Users {get; set;}
        public DbSet<Post> Posts {get; set;}
        public DbSet<Like> Likes {get; set;}
    }
}