using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Repository
{
    public interface ICustomerRepository
    {
        Task<ApiResponse<UserDetails>> GetCustomer(LoginModel login);
        Task<ApiResponse<TransactionResponse>> PostCustomer(UserDetails user);
        Task<List<UserDetails>> GetAllCustomer();
    }
}
