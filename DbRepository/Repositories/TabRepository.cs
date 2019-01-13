using DbRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Repositories
{
    public class TabRepository : BaseRepository, ITabRepository
    {
        public TabRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<List<Tab>> GetAllTabs()
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Tabs.Include(x=>x.Iterations).ToListAsync();
            }
        }

        public async Task<Tab> GetTab(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var res = context.Tabs.Include(x => x.Iterations).ThenInclude(s=>s.ActiveNotes).FirstOrDefault(x => x.ID == id);
                return res;
            }
        }

        public async Task AddTab(Tab tab)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                context.Tabs.Add(tab);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteTab(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var tab = await context.Tabs.FirstOrDefaultAsync(x => x.ID == id);
                if (tab != null)
                {
                    context.Tabs.Remove(tab);
                    await context.SaveChangesAsync();
                }             
            }
        }

        public List<User> GetSubscribedUsers(int tabId)
        {
            var usersList = new List<User>();

            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                foreach (var user in context.Users)
                {
                    var findedUser = user.BoughtTabs.FirstOrDefault(x => x.ID == tabId);
                    if (findedUser != null)
                    {
                        usersList.Add(user);
                    }
                }
            }
            return usersList;
        }
    }
}
