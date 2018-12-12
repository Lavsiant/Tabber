using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<User> GetUser(string userName);

        Task<List<Tab>> GetCreatedUserTabs(string userName);

        Task<User> GetUserWithCourses(string userName);

        Task<User> GetUserWithTabs(string userName);

        Task<User> GetUserFullInfo(string userName);

        Task<User> GetUser(int id);

        Task<User> Create(User user);

        Task<User> Authenticate(string username, string password);

        Task<List<User>> GetAllUsers();

    }
}
