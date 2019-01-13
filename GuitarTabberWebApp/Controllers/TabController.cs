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
        public async Task<TabCreateViewModel> GetTab(int id)
        {
            var result = await _tabService.GetTabById(id);

            return new TabCreateViewModel()
            {
                Name = result.Name,
                Creator = result.Creator,
                Tempo = Convert.ToInt32(result.Tempo),
                Type = (int)result.GuitarType,
                iterations = result.Iterations
            };
        }

        [Route("tab-delete")]
        [HttpGet]
        public async Task DeleteTab(int id)
        {
             await _tabService.DeleteTab(id);
        }

        [Route("tab-add")]
        [HttpGet]
        public async Task DeleteTab(int id, string username)
        {
            await _tabService.AddTabToUser(id,username);
        }

        [Route("tab-create")]
        [HttpPost]
        public async Task<IActionResult> CreateTab ([FromBody] TabCreateViewModel tabCreateVM)
        {
            try
            {
                var tab = new Tab()
                {
                    Creator = tabCreateVM.Creator,
                    Name = tabCreateVM.Name,
                    Tempo = tabCreateVM.Tempo,
                    GuitarType = (InstrumentType)tabCreateVM.Type,
                    Iterations = tabCreateVM.iterations
                };
                await _tabService.AddTab(tab);
                return Ok(tab);
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }
    }
}