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

    public class RoleController : Controller
    {
        IRoleService _roleService = null;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RoleRequest role)
        {
             if (ModelState.IsValid)
            {
                var response = await _roleService.Post(role);
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
        public async Task<IActionResult> RoleLst()
        {
            var response = await _roleService.GetAll();
            return View(response.Response);
        }
    }
}
