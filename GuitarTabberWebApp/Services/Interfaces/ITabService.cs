using Model.GuitarTab;
using Model.UserModel;
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

        Task DeleteTab(int id);

        List<User> GetSubscribedUsers(int tabId);

        Task AddTabToUser(int id, string userName);
    }
}
