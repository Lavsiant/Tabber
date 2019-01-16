using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Interfaces
{
    public interface IIdentityRepository
    {
        Task<User> GetUser(string userName);

        Task<List<User>> GetAllUsers();

        Task<User> GetUserById(int id);

        Task<List<Tab>> GetCreatedUserTabs(string userName);

        Task<User> GetUserWithCourses(string userName);

        Task<User> GetUserWithTabs(string userName);

        Task<User> GetUserFullInfo(string userName);

        Task Create(User user);

        Task UpdateUser(User user);
    }
}
