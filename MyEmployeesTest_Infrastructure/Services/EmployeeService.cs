using MyEmployeesTest_Domain.Interfaces;
using MyEmployeesTest_Domain.Models;

namespace MyEmployeesTest_Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Gabo Lopez", BirthDate = new DateTime(1985, 4, 12) },
            new Employee { Id = 2, FullName = "John  Wick", BirthDate = new DateTime(1990, 8, 23) },
            new Employee { Id = 3, FullName = "Samuel Jackson", BirthDate = new DateTime(1979, 1, 15) }
        };

        public List<Employee> SearchEmployees(string name)
        {
            return _employees.Where(e => e.FullName.Contains(name)).ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
