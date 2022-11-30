using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Services
{
    public class RechargeCardService : IRechargeCardService
    {
        private readonly IRechargeCardRepository _rechargeCardRepository;
        public RechargeCardService(IRechargeCardRepository rechargeCardRepository)
        {
            _rechargeCardRepository = rechargeCardRepository;
        }

        public async Task<ApiResponse<TransactionResponse>> AddRecharge(RechargeModel recharge)
        {
            return await _rechargeCardRepository.AddRecharge(recharge);
        }

        public async Task<ApiResponse<List<CardResponse>>> CardList(CardDetails card)
        {
            return await _rechargeCardRepository.CardList(card);
        }

        public Task<ApiResponse<CardDetails>> GetCard(CardDetails card)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<TransactionResponse>> SaveCard(CardDetails card)
        {
            return await _rechargeCardRepository.SaveCard(card);
        }

        public async Task<ApiResponse<TransactionResponse>> SaveRequest(string requestJson, string prn)
        {
            return await _rechargeCardRepository.SaveRequest(requestJson, prn);
        }
    }
}
