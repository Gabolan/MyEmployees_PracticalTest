using MyEmployeesTest_Domain.Models;
using MyEmployeesTest_Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployees_Tests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private EmployeeService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new EmployeeService();
        }

        [TestMethod]
        public void SearchEmployees_ReturnsCorrectResults()
        {
            // Act
            var results = _service.SearchEmployees("Gabo");

            // Assert
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Gabo Lopez", results[0].FullName);
        }

        [TestMethod]
        public void AddEmployee_AddsCorrectly()
        {
            // Arrange
            var newEmployee = new Employee { Id = 4, FullName = "Pepe Aguilar", BirthDate = new DateTime(1984, 10, 10) };

            // Act
            _service.AddEmployee(newEmployee);
            var results = _service.SearchEmployees("Pepe");

            // Assert
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Pepe Aguilar", results[0].FullName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Cleanup code if needed
        }

    }
}
