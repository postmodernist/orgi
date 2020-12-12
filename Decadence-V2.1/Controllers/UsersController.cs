using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces.IServices;
using DecadenceV2_1_DAL.Services;
using DecadenceV2_1_DAL.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(AppDataContext context)
        {
            _userService = new UserService(context);
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.AddUser(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public void Put([FromBody] User user)
        {
            _userService.UpdateUser(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete]
        public void Delete(User user)
        {
            _userService.DeleteUser(user);
        }
    }
}
