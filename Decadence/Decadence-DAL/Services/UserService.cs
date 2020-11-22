using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AddUser(User user)
        {
            return _unitOfWork.UserRepository.Add(user);
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
            return _unitOfWork.UserRepository.Get(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.UserRepository.GetAll();
        }
    }
}