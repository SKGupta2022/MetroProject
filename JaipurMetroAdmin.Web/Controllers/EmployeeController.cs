using JaipurMetroAdmin.Interface.Services;
using JaipurMetroAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JaipurMetroAdmin.Models.ShowAlertHelper;

namespace JaipurMetroAdmin.Views.Shared
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService = null;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmployeeDetails employee)
        {
            if (ModelState.IsValid)
            {
                var response = await _employeeService.PostEmployee(employee);
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

        public async Task<IActionResult> userlst()
        {
            var respData = await _employeeService.GetAllEmployee(new EmployeeDetails());
            return View(respData);
        }
    }
}
