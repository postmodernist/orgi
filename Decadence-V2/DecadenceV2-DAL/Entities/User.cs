using System;
using DecadenceV2_DAL.Interfaces.Entity;

namespace DecadenceV2_DAL.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } //also used as login 
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterAt { get; set; }
    }
}