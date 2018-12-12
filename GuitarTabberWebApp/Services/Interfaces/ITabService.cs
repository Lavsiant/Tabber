using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Interfaces
{
    public interface ITabService 
    {
        Task<List<Tab>> GetAllTabs();

        Task<Tab> GetTabById(int id);

        Task AddTab(Tab tab);
    }
}
