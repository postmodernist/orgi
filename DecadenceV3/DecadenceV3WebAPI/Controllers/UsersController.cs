using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DecadenceV3WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(AppDbContext context, IMapper mapper)
        {
            _userService = new UserService(context, mapper);
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await _userService.GetUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await _userService.GetUserById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task Post([FromBody] UserDto user)
        {
            await _userService.AddUser(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public async Task Put([FromBody] UserDto user)
        {
            await _userService.UpdateUser(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete]
        public async Task Delete(UserDto user)
        {
            await _userService.DeleteUser(user);
        }
    }
}
