using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class UserService: IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(AppDbContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public UserViewModel GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserViewModel> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(UserDto user)
        {
            throw new System.NotImplementedException();
        }
    }
}