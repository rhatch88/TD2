using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TD2.Models;

namespace TD2.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<TD2Event> TD2Events { get; set; }

    }
}
