using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Repository
{
    public interface IRechargeRepository
    {
        Task<ApiResponse<UserDetails>> GetRechargeDetails(RechargeParameter rechagepara);

    }
}
