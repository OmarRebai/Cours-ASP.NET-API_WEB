using TP5_ASP.NET_API_WEB.Models;

namespace TP5_ASP.NET_API_WEB.Repositories
{
    public interface IEmployeeRepository

    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> Addemployee(Employee employee);
        Task<Employee> UpdatetEmployee(Employee employee);
        Task<Employee> DeletetEmployee(int employeeld);
        Task<Employee> GetEmployeeByEmail(string email);
    }
}
