using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IUserService
    {
        UserDto GetUserById(int id);
        IEnumerable<UserDto> GetUsers();
        void AddUser(UserDto user);
        void UpdateUser(UserDto user);
        void DeleteUser(UserDto user);
    }
}