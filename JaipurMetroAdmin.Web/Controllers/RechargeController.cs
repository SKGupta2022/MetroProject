using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Web.Controllers
{
    public class RechargeController : Controller
    {

        RechargeController()
        {

        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
