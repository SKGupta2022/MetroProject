using Dapper;
using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Framework;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static JaipurMetroAdmin.Commom.SystemMessagesHelper;
using System.Linq;


namespace JaipurMetroAdmin.Repository
{
    public class CustomerRepository : AsyncDbRepository, ICustomerRepository
    {
        private readonly IAppSettings _configuration;
        public CustomerRepository(IAppSettings configuration, IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _configuration = configuration;
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));
        }

        public async Task<List<UserDetails>> GetAllCustomer()
        {
            List<UserDetails> returnValue = new List<UserDetails>();
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", CommonAction.Get);
                queryParameters.Add("@Mobile", null);
                returnValue = (await WithConnection(async c => await c.QueryAsync<UserDetails>(StoredProcedures.Get_Customer, queryParameters, commandType: CommandType.StoredProcedure))).ToList();
            }
            catch (Exception ex)
            {
            }
            return returnValue;
        }

        public Task<ApiResponse<UserDetails>> GetCustomer(LoginModel login)
        {
            throw new NotImplementedException();
        }



      
        //public async Task<ApiResponse<UserDetails>> GetCustomer(LoginModel login)
        //{
        //    var returnvalue = new UserDetails();
        //    UserDetails userDetail = new UserDetails();
        //    List<PaymentDetails> paymentDetails = new List<PaymentDetails>();
        //    CardDetails cardDetails = new CardDetails();

        //    ApiResponse<UserDetails> result = null;
        //    try
        //    {
        //        var queryParameters = new DynamicParameters();

        //        // user details
        //        queryParameters.Add("@Action", "CustomerDetails");
        //        queryParameters.Add("@Mobile", login.Mobile);
        //        userDetail = (await WithConnection(async c => await c.QueryAsync<UserDetails>(StoredProcedures.Get_Customer, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();

        //        // recharge details
        //        queryParameters.Add("@Action", "RechargeDetails");
        //        queryParameters.Add("@Mobile", login.Mobile);
        //        paymentDetails = (await WithConnection(async c => await c.QueryAsync<PaymentDetails>(StoredProcedures.Get_Customer, queryParameters, commandType: CommandType.StoredProcedure))).ToList();

        //        //CardDetails
        //        queryParameters.Add("@Action", "CardDetails");
        //        queryParameters.Add("@Mobile", login.Mobile);
        //        cardDetails = (await WithConnection(async c => await c.QueryAsync<CardDetails>(StoredProcedures.Get_Customer, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();

        //        if (paymentDetails != null)
        //            userDetail.RechargePaymentLst = paymentDetails;

        //        if (cardDetails == null)
        //        {
        //            cardDetails = new CardDetails
        //            {
        //                CardNo = "-",
        //                PendingAmt = "0",
        //            };
        //        }
        //        userDetail.cardDetails = cardDetails;


        //        result = new ApiResponse<UserDetails>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), userDetail);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}

        //public Task<ApiResponse<TransactionResponse>> PostCustomer(UserDetails user)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ApiResponse<TransactionResponse>> PostCustomer(UserDetails user)
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
                queryParameters.Add("@CreatedBy", "1");
                //queryParameters.Add("@passwrd", user.Password);
                queryParameters.Add("@Pincode   ", user.Pincode);
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.Post_Customer, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


    }
}
