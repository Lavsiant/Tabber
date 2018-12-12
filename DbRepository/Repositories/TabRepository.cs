using DbRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.GuitarTab;
using System;
using System.Collections.Generic;
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
                return await context.Tabs.ToListAsync();
            }
        }

        public async Task<Tab> GetTab(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Tabs.FirstOrDefaultAsync(x => x.ID == id);
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
    }
}
