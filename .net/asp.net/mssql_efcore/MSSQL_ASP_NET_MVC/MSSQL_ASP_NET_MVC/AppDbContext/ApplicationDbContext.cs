using Microsoft.EntityFrameworkCore;
using MSSQL_ASP_NET_MVC.Models;

namespace MSSQL_ASP_NET_MVC.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public ApplicationDbContext(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }
    }
}
