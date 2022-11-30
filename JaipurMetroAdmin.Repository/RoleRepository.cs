using Dapper;
using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Framework;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static JaipurMetroAdmin.Commom.SystemMessagesHelper;

namespace JaipurMetroAdmin.Repository
{
    public class RoleRepository : AsyncDbRepository, IRoleRepository
    {
        private readonly IAppSettings _configuration;
        public RoleRepository(IAppSettings configuration, IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _configuration = configuration;
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));
        }

        #region Post Role
        public async Task<ApiResponse<TransactionResponse>> Post(RoleRequest role)
        {
            ApiResponse<TransactionResponse> result = null;
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", "Save");
                queryParameters.Add("@Role", role.RoleName);
                queryParameters.Add("@CreatedBy", "");
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.Role, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        public Task<ApiResponse<List<RoleResponse>>> Get(RoleRequest role)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<List<RoleResponse>>> GetAll()
        {
            ApiResponse<List<RoleResponse>> result = null;
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", "GetAll");
                queryParameters.Add("@Role", "");
                queryParameters.Add("@CreatedBy", "");
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<RoleResponse>(StoredProcedures.Role, queryParameters, commandType: CommandType.StoredProcedure))).ToList();
                result = new ApiResponse<List<RoleResponse>>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


    }
}
