using System.Collections.Generic;
using AutoMapper;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class UserService: IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public UserService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public UserDto GetUserById(int id)
        {
            return _mapper.Map<UserDto>(unitOfWork.UserRepository.GetEntityById(id));
        }

        public IEnumerable<UserDto> GetUsers()
        {
            return _mapper.Map<IEnumerable<UserDto>>(unitOfWork.UserRepository.GetEntities());
        }

        public void AddUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            unitOfWork.UserRepository.Add(item);
        }

        public void UpdateUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            unitOfWork.UserRepository.Update(item);
        }

        public void DeleteUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            unitOfWork.UserRepository.Delete(item);
        }
    }
}