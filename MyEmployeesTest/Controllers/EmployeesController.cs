using Microsoft.AspNetCore.Mvc;
using MyEmployeesTest_Domain.Interfaces;
using MyEmployeesTest_Domain.Models;

namespace MyEmployees_Api.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            var results = _employeeService.SearchEmployees(name);
            return Ok(results);
        }

        [HttpPost("add")]
        public IActionResult Add(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return CreatedAtAction(nameof(Search), new { name = employee.FullName }, employee);
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Remove(int id)
        {
            _employeeService.RemoveEmployee(id);
            return NoContent();
        }
    }
}
