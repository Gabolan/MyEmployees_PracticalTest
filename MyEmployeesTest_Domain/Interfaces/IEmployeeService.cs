using MyEmployeesTest_Domain.Models;

namespace MyEmployeesTest_Domain.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> SearchEmployees(string name);
        void AddEmployee(Employee employee);
        void RemoveEmployee(int id);
    }
}
