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
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<UserDetails>> GetAllCustomer()
        {
            return await _customerRepository.GetAllCustomer();
        }

        public async Task<ApiResponse<UserDetails>> GetCustomer(LoginModel login)
        {
            return await _customerRepository.GetCustomer(login);
        }

        public async Task<ApiResponse<TransactionResponse>> PostCustomer(UserDetails user)
        {
            return await _customerRepository.PostCustomer(user);
        }
    }
}
