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
    public class IdentityRepository : BaseRepository, IIdentityRepository
    {
        public IdentityRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<User> GetUser(string userName)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            }
        }

        public async Task<List<Tab>> GetCreatedUserTabs(string userName)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Tabs.Where(x => x.Creator == userName).ToListAsync();
            }
        }
    }
}
