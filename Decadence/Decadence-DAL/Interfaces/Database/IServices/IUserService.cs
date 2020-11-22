using Decadence_DAL.Entities;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Interfaces
{
    public interface IUserService
    {
        int AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
    }
}
