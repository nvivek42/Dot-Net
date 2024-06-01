using Ecommerce2.Models;
using System.Net.Http.Headers;

namespace Ecommerce2.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        void Remove(int id);
        void Insert(Employee employee);
        void Update(Employee employee);
    }
}
