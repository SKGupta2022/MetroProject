using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;

namespace JaipurMetroAdmin.Interface.Services
{
     public interface ICustomerService
    {
        Task<ApiResponse<TransactionResponse>> PostCustomer(UserDetails user);
        Task<ApiResponse<UserDetails>> GetCustomer(LoginModel login);
        Task<List<UserDetails>> GetAllCustomer();


    }
}
