using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Repository
{
    public interface IEmployeeRepository
    {
        Task<ApiResponse<TransactionResponse>> PostEmployee(EmployeeDetails emp);
        Task<ApiResponse<EmployeeDetails>> GetEmployee(EmployeeDetails emp);
        Task<List<EmployeeResponse>> GetAllEmployee(EmployeeDetails emp);
    }
}
