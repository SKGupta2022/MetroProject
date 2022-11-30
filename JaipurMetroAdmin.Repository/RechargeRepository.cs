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
    public class RechargeRepository : IRechargeRepository
    {
        public Task<ApiResponse<UserDetails>> GetRechargeDetails(RechargeParameter rechagepara)
        {
            throw new NotImplementedException();
        }
    }
}
