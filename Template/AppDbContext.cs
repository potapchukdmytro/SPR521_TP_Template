using Microsoft.EntityFrameworkCore;

namespace Template
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
