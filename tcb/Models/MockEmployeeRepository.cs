using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tcb.model;

namespace tcb.model
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id=1,Name="John", Department=Dept.IT,Email="jihn@gamil.com"},
                new Employee() { Id=2,Name="Mohan", Department=Dept.Hr,Email="Mohan@gmail.com"},
                new Employee() { Id=3,Name="Ram", Department=Dept.Payroll ,Email="ram@gmail.com"},
                new Employee() { Id=4,Name="Sohan", Department=Dept.IT,Email="sohan@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);

        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }
    }
}
