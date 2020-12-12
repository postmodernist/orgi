using System.Collections.Generic;
using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces;
using DecadenceV2_1_DAL.Interfaces.IServices;
using DecadenceV2_1_DAL.UnitOfWork;

namespace DecadenceV2_1_DAL.Services
{
    public class UserService: IUserService
    {
        IUnitOfWork _unitOfWork;

        public UserService(AppDataContext context)
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(context);
        }

        public void AddUser(User user)
        {
             _unitOfWork.UserRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            _unitOfWork.UserRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            _unitOfWork.UserRepository.Delete(user);
        }

        public User GetUserById(int id)
        {
            return _unitOfWork.UserRepository.GetById(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.UserRepository.GetAll();
        }
    }
}