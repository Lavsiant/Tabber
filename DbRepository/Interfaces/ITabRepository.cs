using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Interfaces
{
    public interface ITabRepository
    {
        Task<List<Tab>> GetAllTabs();

        Task<Tab> GetTab(int id);

        Task AddTab(Tab tab);

        Task DeleteTab(int id);
    }
}
