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
    public class IdentityService : IIdentityService
    {
        private readonly IIdentityRepository _identityRepository;

        public IdentityService(IIdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;
        }

        public async Task<User> GetUser(string userName)
        {
            return await _identityRepository.GetUser(userName);
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
