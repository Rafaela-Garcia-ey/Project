using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class Db : DbContext
    {
        public DbSet<Hero> heroes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Project;Integrated Security=True");
        }
    }
}
