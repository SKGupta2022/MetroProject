using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository = null;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<EmployeeResponse>> GetAllEmployee(EmployeeDetails emp)
        {
            return await _employeeRepository.GetAllEmployee(emp);
        }

        public Task<ApiResponse<EmployeeDetails>> GetEmployee(EmployeeDetails emp)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<TransactionResponse>> PostEmployee(EmployeeDetails emp)
        {
            return await _employeeRepository.PostEmployee(emp);
        }
    }
}
