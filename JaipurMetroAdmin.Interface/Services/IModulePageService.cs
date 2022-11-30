using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Services
{
    public interface IModulePageService
    {
        Task<ApiResponse<TransactionResponse>> PostModule(ModuleRequest module);
        Task<ApiResponse<List<ModuleResponse>>> GetAllModule();
        Task<ApiResponse<List<ModuleResponse>>> GetModule(ModuleRequest module);

        Task<ApiResponse<TransactionResponse>> PostPage(ModuleRequest module);
        Task<ApiResponse<List<ModuleResponse>>> GetAllPage();
        Task<ApiResponse<List<ModuleResponse>>> GetPage(ModuleRequest module);
    }
}
