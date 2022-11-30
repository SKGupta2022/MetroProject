using JaipurMetroAdmin.Commom;
using JaipurMetroAdmin.Interface.Repository;
using JaipurMetroAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Web.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IModulePageService _modulePageService;

        public ModuleController(IModulePageService modulePageService)
        {
            _modulePageService = modulePageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ModuleRequest moduleRequest)
        {
            ApiResponse<TransactionResponse> data = await _modulePageService.PostModule(moduleRequest);
            return View();
        }

        //public async Task<IActionResult> modulelst()
        //{
        //    //ApiResponse<List<ModuleResponse>> data = await _modulePageRepository.GetAllModule();
        //    return View(data);
        //}
    }
}
