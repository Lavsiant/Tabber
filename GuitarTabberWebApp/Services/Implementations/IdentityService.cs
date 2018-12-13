using DbRepository.Interfaces;
using GuitarTabberWebApp.Helpers;
using GuitarTabberWebApp.Services.Interfaces;
using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Implementations
{
    public class IdentityService : IIdentityService
    {
        private readonly IIdentityRepository _identityRepository;

        public IdentityService(IIdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _identityRepository.GetAllUsers();
        }

        public async Task<User> Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = await _identityRepository.GetUser(username);

            if (user == null)
                return null;

            if (password != user.Password)
                return null;

            return user;
        }

        public async Task<User> Create(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                return null;
            }

            if (await _identityRepository.GetUser(user.UserName) != null)
                throw new AppException("Username '" + user.UserName + "' is already taken");

            await _identityRepository.Create(user);

            return user;
        }

        public async Task<User> GetUser(string userName)
        {
            return await _identityRepository.GetUser(userName);
        }


        public async Task<User> GetUser(int id)
        {
            return await _identityRepository.GetUserById(id);
        }

        public async Task<List<Tab>> GetCreatedUserTabs(string userName)
        {
            return await _identityRepository.GetCreatedUserTabs(userName);
        }

        public async Task<User> GetUserWithCourses(string userName)
        {
            return await _identityRepository.GetUserWithCourses(userName);
        }

        public async Task<User> GetUserWithTabs(string userName)
        {
            return await _identityRepository.GetUserWithTabs(userName);
        }

        public async Task<User> GetUserFullInfo(string userName)
        {
            return await _identityRepository.GetUserFullInfo(userName);
        }

    }
}
