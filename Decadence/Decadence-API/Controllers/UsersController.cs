﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decadence_DAL.Interfaces;
using Decadence_DAL.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService service)
        {
            _userService = service;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _userService.GetUserById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public Guid Post([FromBody] User user)
        {
            return _userService.AddUser(user);
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
