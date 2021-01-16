using System;

namespace DecadenceV3DAL.Entities
{
    public class User:Entity
    {
        public string Name { get; set; }
        public string Email { get; set; } //also used as login 
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterAt { get; set; }
    }
}