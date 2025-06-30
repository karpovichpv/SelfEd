using Microsoft.EntityFrameworkCore;
using MSSQL_ASP_NET_MVC.AppDbContext;
using MSSQL_ASP_NET_MVC.Models;

namespace MSSQL_ASP_NET_MVC.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ApplicationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
    }
}
