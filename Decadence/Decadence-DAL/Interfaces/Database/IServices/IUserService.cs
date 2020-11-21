using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;

namespace Decadence_DAL.Interfaces.Database.IServices
{
    interface IUserService
    {
        Guid AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserById(Guid id);
        IEnumerable<User> GetAllUsers();
    }
}
