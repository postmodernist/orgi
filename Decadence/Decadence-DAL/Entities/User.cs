using System;
using System.Collections.Generic;
using System.Text;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } //also used as login 
        public string Password {get;set;}
        public DateTime BirthDate { get; set; }
        public DateTime RegisterAt { get; set; }
    }
}
