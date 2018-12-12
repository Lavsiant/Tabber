﻿using Model.GuitarTab;
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

        Task<List<Tab>> GetCreatedUserTabs(string userName);
    }
}
