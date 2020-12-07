﻿using System.Collections.Generic;
using DecadenceV2_DAL.Entities;

namespace DecadenceV2_DAL.Interfaces.IServices
{
    public interface IUserService
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
    }
}