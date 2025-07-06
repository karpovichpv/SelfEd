using Microsoft.EntityFrameworkCore;
using MSSQL_ASP_NET_MVC_DOCKER.Models;

namespace MSSQL_ASP_NET_MVC_DOCKER.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public ApplicationDbContext(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Employee> Employees { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string? dbHost = Environment.GetEnvironmentVariable("DB_HOST");
        //    string? dbName = Environment.GetEnvironmentVariable("DB_NAME");
        //    string? dbPassword = Environment
        //        .GetEnvironmentVariable("DB_SA_PASSWORD");
        //    string? connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID = sa; Password={dbPassword}";
        //    optionsBuilder.UseSqlServer();
        //   // optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        //}
    }
}
