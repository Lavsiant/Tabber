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

        public async Task<List<User>> GetAllUsers()
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.Include(x=>x.Courses).ThenInclude(x=>x.Lessons).ThenInclude(x=>x.Tab).ToListAsync();
            }
        }

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

        public async Task<User> GetUserById(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.Include(x=>x.Courses).FirstOrDefaultAsync(x => x.ID == id);
            }
        }

        public async Task<User> GetUserWithTabs(string userName)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.Include(x=>x.BoughtTabs).FirstOrDefaultAsync(u => u.UserName == userName);
            }
        }

        public async Task<User> GetUserWithCourses(string userName)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.Include(x => x.Courses).FirstOrDefaultAsync(u => u.UserName == userName);
            }
        }

        public async Task<User> GetUserFullInfo(string userName)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Users.Include(x => x.Courses).Include(x=>x.BoughtTabs).FirstOrDefaultAsync(u => u.UserName == userName);
            }
        }

        public async Task Create(User user)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateUser(User user)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var u = await context.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName);
                u.UserName = user.UserName;
                u.Password = user.Password;
                u.Email = user.Email;
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Bio = user.Bio;
                context.Entry(u).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
