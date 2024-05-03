using CodeFirst.Models;
using CodeFirst.Data;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst.Services
{
    public class EmployeeDBService
    {
        private readonly AppDbContext _context;
        private readonly Employee _employee;

        public EmployeeDBService(AppDbContext context)
        {
            _context = context;

            _employee = new Employee
            {
                EmployeeId = 214,
                FirstName = "Abhiraj",
                LastName = "Chaudhuri",
                Salary = 50000
            };
        }

        // Create operation: Add an employee to the database
        public void AddEmployee()
        {
            _context.Employees.Add(_employee);
            _context.SaveChanges();
        }

        // Read operation: Retrieve all employees from the database
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        // Read operation: Retrieve an employee by their ID
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        // Update operation: Update an existing employee in the database
        public void UpdateEmployee()
        {
            _context.Employees.Update(_employee);
            _context.SaveChanges();
        }

        // Delete operation: Remove an employee from the database by their ID
        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
