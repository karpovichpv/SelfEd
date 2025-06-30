using MSSQL_ASP_NET_MVC.Models;

namespace MSSQL_ASP_NET_MVC.Repository
{
    public interface IApplicationRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
    }
}
