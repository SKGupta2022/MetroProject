using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JaipurMetroAdmin.Models.ShowAlertHelper;

namespace JaipurMetroAdmin.Web.Controllers
{
    public class RechargeCardController : Controller
    {
        private readonly IRechargeCardService _rechargeCardService;
        public RechargeCardController(IRechargeCardService rechargeCardService)
        {
            _rechargeCardService = rechargeCardService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CardDetails card)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ApiResponse<TransactionResponse> response = await _rechargeCardService.SaveCard(card);
                    if (response != null)
                    {
                        if (response.Response != null)
                        {
                            TransactionResponse transaction = new TransactionResponse();
                            transaction = response.Response;
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                if (transaction.AlertType == (int)Alerts.Success)
                                {
                                    ViewBag.Alert = ShowAlertHelper.ShowAlert(Alerts.Success, transaction.TransResponse);
                                }
                                else
                                {
                                    ViewBag.Alert = ShowAlertHelper.ShowAlert(Alerts.Info, transaction.TransResponse);
                                }
                            }
                            else
                            {
                                ViewBag.Alert = ShowAlertHelper.ShowAlert(Alerts.Danger, transaction.TransResponse);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return View();
        }

        public string Get(string key)
        {
            return Request.Cookies[key];
        }   

        public async Task<IActionResult> CardLst()
        {
            CardDetails card = new CardDetails();
            var response = await _rechargeCardService.CardList(card);
            return View(response.Response);
        }
    }
}
