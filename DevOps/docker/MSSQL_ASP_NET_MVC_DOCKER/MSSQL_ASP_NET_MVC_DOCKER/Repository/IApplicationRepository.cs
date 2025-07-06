using MSSQL_ASP_NET_MVC_DOCKER.Models;

namespace MSSQL_ASP_NET_MVC_DOCKER.Repository
{
    public interface IApplicationRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
    }
}
