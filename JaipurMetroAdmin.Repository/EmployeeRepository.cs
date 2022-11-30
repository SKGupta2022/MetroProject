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
    public class EmployeeRepository : AsyncDbRepository, IEmployeeRepository
    {
        private readonly IAppSettings _configuration;
        public EmployeeRepository(IAppSettings configuration, IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _configuration = configuration;
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));
        }


        public async Task<List<EmployeeResponse>> GetAllEmployee(EmployeeDetails emp)
        {
            List<EmployeeResponse> returnValue = new List<EmployeeResponse>();
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", CommonAction.Get);
                queryParameters.Add("@Mobile", emp.Mobile);
                queryParameters.Add("@Email", emp.Email);
                returnValue = (await WithConnection(async c => await c.QueryAsync<EmployeeResponse>(StoredProcedures.Get_Employee, queryParameters, commandType: CommandType.StoredProcedure))).ToList();
            }
            catch (Exception ex)
            {
            }
            return returnValue;
        }

        public Task<ApiResponse<EmployeeDetails>> GetEmployee(EmployeeDetails emp)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<TransactionResponse>> PostEmployee(EmployeeDetails user)
        {
            ApiResponse<TransactionResponse> result = null;
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Name", user.Name);
                queryParameters.Add("@Address", user.Address);
                queryParameters.Add("@Mobile", user.Mobile);
                queryParameters.Add("@EmailId", user.Email);
                queryParameters.Add("@City", user.City);
                queryParameters.Add("@State", user.State);
                queryParameters.Add("@CreatedBy", user.Name);
                queryParameters.Add("@Pincode", user.Pincode);
                queryParameters.Add("@Designation", user.Designation);
                queryParameters.Add("@Department", user.Department);
                queryParameters.Add("@Passwrd", user.Password);
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.Post_Employee, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
