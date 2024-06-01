using Ecommerce2.Models;
using Ecommerce2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce2.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _employeeService.GetAll();
            ViewData["employees"] = employees;
            return View();
        }
        public IActionResult Details()
        {
            
            return View();
        }
    }
}
