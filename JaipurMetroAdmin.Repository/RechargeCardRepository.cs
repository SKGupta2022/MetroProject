using Dapper;
using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Framework;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Models;
using Newtonsoft.Json;
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
    public class RechargeCardRepository : AsyncDbRepository, IRechargeCardRepository
    {

        private readonly IAppSettings _configuration;
        public RechargeCardRepository(IAppSettings configuration, IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _configuration = configuration;
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));
        }

        public async Task<ApiResponse<TransactionResponse>> AddRecharge(RechargeModel recharge)
        {
            ApiResponse<TransactionResponse> result = null;
            try
            {
                // Add recharge details
                Random rnd = new Random();
                string RechargeNumber = "MTR" + rnd.Next(100000, 999999);
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", "Save");
                queryParameters.Add("@Mobile", recharge.Mobile);
                queryParameters.Add("@Recharge", RechargeNumber);
                queryParameters.Add("@ExpiryFrom", recharge.ExpiryFrom);
                queryParameters.Add("@ExpiryTo", recharge.ExpiryTo);
                queryParameters.Add("@PaymentAmt", recharge.PaymentAmt);
                queryParameters.Add("@PaymentMode", "Card");
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.AddRecharge, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);

                // Add Payment Transactions
                PaymentResponse paymentResponse = new PaymentResponse();
                paymentResponse = recharge.PaymentTransDetails;
                var PaymentDetailParameters = new DynamicParameters();
                PaymentDetailParameters.Add("@Mobile", recharge.Mobile);
                PaymentDetailParameters.Add("@PaymentAmt", recharge.PaymentAmt);
                PaymentDetailParameters.Add("@EncData", paymentResponse.ENCDATA);
                PaymentDetailParameters.Add("@ResponseJson", paymentResponse.RESPONSEJSON);
                PaymentDetailParameters.Add("@CheckSumValid", paymentResponse.CHECKSUMVALID ? 1 : 0);
                PaymentDetailParameters.Add("@RespStatus", paymentResponse.STATUS);

                ResponseParameters responseParameters = new ResponseParameters();
                responseParameters = JsonConvert.DeserializeObject<ResponseParameters>(paymentResponse.ResponseParameterJson);
                PaymentDetailParameters.Add("@PRN", responseParameters.PRN);
                PaymentDetailParameters.Add("@CheckSum", responseParameters.CHECKSUM);
                PaymentDetailParameters.Add("@ResParameter", paymentResponse.ResponseParameterJson);

                var returnvalue1 = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.ResponseTransaction, PaymentDetailParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



        public Task<ApiResponse<CardDetails>> GetCard(CardDetails card)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<TransactionResponse>> SaveCard(CardDetails card)
        {
            ApiResponse<TransactionResponse> result = null;
            try
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Action", "Save");
                queryParameters.Add("@CardNo", card.CardNo);
                queryParameters.Add("@RetypeCardNo", card.RetypeCardNo);
                queryParameters.Add("@Mobile", card.Mobile);
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.AddNewCard, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public async Task<ApiResponse<TransactionResponse>> SaveRequest(string requestJson, string prn)
        {
            ApiResponse<TransactionResponse> result = null;
            try
            {
                UserModel objRequestDetailsModel = new UserModel();
                objRequestDetailsModel = JsonConvert.DeserializeObject<UserModel>(requestJson);
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Mobile", objRequestDetailsModel.UserMobile);
                queryParameters.Add("@Username", objRequestDetailsModel.UserName);
                queryParameters.Add("@UserMail", objRequestDetailsModel.UserMail);
                queryParameters.Add("@Amount", objRequestDetailsModel.Amount);
                queryParameters.Add("@Purpose", objRequestDetailsModel.Purpose);
                queryParameters.Add("@PRN", prn);
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<TransactionResponse>(StoredProcedures.SaveRequestTransaction, queryParameters, commandType: CommandType.StoredProcedure))).FirstOrDefault();
                result = new ApiResponse<TransactionResponse>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<ApiResponse<List<CardResponse>>> CardList(CardDetails card)
        {
            ApiResponse<List<CardResponse>> result = null;
            try
            {
                string action = CommonAction.Get;
                if (card.Mobile != null)
                    action = CommonAction.GetByMobile;
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@action", action);
                queryParameters.Add("@Mobile", card.Mobile);
                var returnvalue = (await WithConnection(async c => await c.QueryAsync<CardResponse>(StoredProcedures.CardDetails, queryParameters, commandType: CommandType.StoredProcedure))).ToList();
                result = new ApiResponse<List<CardResponse>>(HttpStatusCode.OK, Functions.Success, SystemMessagesHelper.GetMessage(SystemMessages.Success), returnvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
