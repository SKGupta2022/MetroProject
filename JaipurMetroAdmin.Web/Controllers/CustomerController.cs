using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JaipurMetroAdmin.Models.ShowAlertHelper;

namespace JaipurMetroAdmin.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UserDetails user)
        {
          //  if (ModelState.IsValid)
            {
                ApiResponse<TransactionResponse> response = await _customerService.PostCustomer(user);
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
                // Validation success.
            }
            return View();
        }

        //public async Task<IActionResult> CustomerLst()
        //{
        //    List<UserDetails> data = await _customerService.GetAllCustomer();
        //    return View(data);
        //}
    }
}
