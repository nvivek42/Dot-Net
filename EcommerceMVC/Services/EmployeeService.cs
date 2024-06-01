using Ecommerce2.Models;

namespace Ecommerce2.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees;   
        public EmployeeService() { 
            employees = new List<Employee>();
            employees.Add(new Employee { Id=1,FirstName="vivek", LastName="narole", Phone= "454545454554" });
            employees.Add(new Employee { Id = 2, FirstName = "kunal", LastName = "bura", Phone = "65484562445" });

        }
        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.Find(emp => emp.Id == id);
        }

        public void Insert(Employee employee)
        {
            employees.Add(employee);
        }

        public void Remove(int id)
        {
            employees.Remove(GetById(id));
        }

        public void Update(Employee employee)
        {
            var existingEmployee = GetById(employee.Id);
            if (existingEmployee != null)
            {
                employees[employees.IndexOf(employee)] = employee;
            }
        }
    }
}
