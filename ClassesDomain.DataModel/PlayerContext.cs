using PlayerDomain.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Scaffolding;



//dbcontext in data model
namespace PlayerDomain.DataModel
{
    public class PlayerContext : DbContext
    {
        public DbSet<classes.Player> Player { get; set; }
        public DbSet<classes.PlayerStats> PlayerStats { get; set; }

        // virtual method OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog= TeamAppDatabase"
                );
        }

    }

}