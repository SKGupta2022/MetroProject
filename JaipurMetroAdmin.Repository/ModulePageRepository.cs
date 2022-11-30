using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Repository
{
    public class ModulePageRepository : IModulePageService
    {
        public Task<ApiResponse<List<ModuleResponse>>> GetAllModule()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<ModuleResponse>>> GetAllPage()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<ModuleResponse>>> GetModule(ModuleRequest module)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<ModuleResponse>>> GetPage(ModuleRequest module)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<TransactionResponse>> PostModule(ModuleRequest module)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<TransactionResponse>> PostPage(ModuleRequest module)
        {
            throw new NotImplementedException();
        }
    }
}
