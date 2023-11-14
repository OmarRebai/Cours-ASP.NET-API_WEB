using Microsoft.EntityFrameworkCore;
using System;
using TP5_ASP.NET_API_WEB.Models;

namespace TP5_ASP.NET_API_WEB.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {


        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }


        public async Task<Employee> Addemployee(int EmployeeId)
        {
            return await appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == EmployeeId);

        }

        public Task<Employee> DeletetEmployee(int employeeld)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        

        public Task<Employee> UpdatetEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
