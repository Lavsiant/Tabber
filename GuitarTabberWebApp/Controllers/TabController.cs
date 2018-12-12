using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarTabberWebApp.Services.Interfaces;
using GuitarTabberWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Model.GuitarTab;

namespace GuitarTabberWebApp.Controllers
{
    [Route("api/[controller]")]
    public class TabController : Controller
    {
        private readonly ITabService _tabService;

        public TabController(ITabService tabService)
        {
            _tabService = tabService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("tabs")]
        [HttpGet]
        public async Task<List<Tab>> GetTabs()
        {
            return await _tabService.GetAllTabs();
        }

        [Route("tab")]
        [HttpGet]
        public async Task<Tab> GetTab(int id)
        {
            return await _tabService.GetTabById(id);
        }

        [Route("tab-create")]
        [HttpPost]
        public async Task CreateTab (TabCreateViewModel tabCreateVM)
        {

        }
    }
}