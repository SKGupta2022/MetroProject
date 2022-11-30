using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Services
{
    public interface IRoleService
    {
        Task<ApiResponse<TransactionResponse>> Post(RoleRequest role);
        Task<ApiResponse<List<RoleResponse>>> GetAll();
        Task<ApiResponse<List<RoleResponse>>> Get(RoleRequest role);

    }
}
