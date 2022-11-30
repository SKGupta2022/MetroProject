using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository = null;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<ApiResponse<List<RoleResponse>>> Get(RoleRequest role)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<List<RoleResponse>>> GetAll()
        {
            return await _roleRepository.GetAll();
        }

        public async Task<ApiResponse<TransactionResponse>> Post(RoleRequest role)
        {
            return await _roleRepository.Post(role);
        }
    }
}
