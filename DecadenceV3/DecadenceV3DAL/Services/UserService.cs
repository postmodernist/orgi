using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<UserDto> GetUserById(int id)
        {
            return _mapper.Map<UserDto>(await unitOfWork.UserRepository.GetEntityById(id));
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            return _mapper.Map<IEnumerable<UserDto>>(await unitOfWork.UserRepository.GetEntities());
        }

        public async Task AddUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            await unitOfWork.UserRepository.Add(item);
        }

        public async Task UpdateUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            await unitOfWork.UserRepository.Update(item);
        }

        public async Task DeleteUser(UserDto user)
        {
            var item = _mapper.Map<User>(user);
            await unitOfWork.UserRepository.Delete(item);
        }
    }
}