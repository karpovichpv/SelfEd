using Microsoft.AspNetCore.Mvc;
using MSSQL_ASP_NET_MVC_DOCKER.Models;
using MSSQL_ASP_NET_MVC_DOCKER.Repository;
using System.Diagnostics;

namespace MSSQL_ASP_NET_MVC_DOCKER.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IApplicationRepository repository) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IApplicationRepository _repository = repository;

        public IActionResult Index()
        {
            Task<IEnumerable<Employee>> employees = _repository.GetEmployeesAsync();
            EmployeesDTO dto = new() { Employees = employees.Result };

            return View(dto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
