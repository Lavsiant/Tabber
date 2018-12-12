using DbRepository.Interfaces;
using GuitarTabberWebApp.Services.Interfaces;
using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Implementations
{
    public class TabService : ITabService
    {
        private readonly ITabRepository _tabRepository;

        public TabService(ITabRepository tabRepository)
        {
            _tabRepository = tabRepository;
        }

        public async Task<List<Tab>> GetAllTabs()
        {
           return await _tabRepository.GetAllTabs();
        }

        public async Task<Tab> GetTabById(int id)
        {
            return await _tabRepository.GetTab(id);
        }

        public async Task AddTab(Tab tab)
        {
            await _tabRepository.AddTab(tab);
        }

        public async Task DeleteTab(int id)
        {
            await _tabRepository.DeleteTab(id);
        }

        public List<User> GetSubscribedUsers(int id)
        {
            return _tabRepository.GetSubscribedUsers(id);
        }
    }
}
