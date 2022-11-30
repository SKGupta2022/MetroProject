using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Interface.Services
{
    public interface IRechargeCardService
    {
        Task<ApiResponse<TransactionResponse>> SaveCard(CardDetails card);
        Task<ApiResponse<List<CardResponse>>> CardList(CardDetails card);
        Task<ApiResponse<CardDetails>> GetCard(CardDetails card);
        Task<ApiResponse<TransactionResponse>> AddRecharge(RechargeModel recharge);
        Task<ApiResponse<TransactionResponse>> SaveRequest(string requestJson, string prm);
    }
}
