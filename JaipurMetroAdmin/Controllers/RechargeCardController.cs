using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Controllers
{
    public class RechargeCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CardLst()
        {
            return View();
        }

    }
}
