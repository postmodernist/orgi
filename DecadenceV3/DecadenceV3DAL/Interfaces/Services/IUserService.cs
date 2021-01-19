using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserById(int id);
        Task<IEnumerable<UserDto>> GetUsers();
        Task AddUser(UserDto user);
        Task UpdateUser(UserDto user);
        Task DeleteUser(UserDto user);
    }
}