using Decadence_DAL.Interfaces;
using System;

namespace Decadence_DAL.Entities
{
    public class AuthEntity : IEntity
    {
        public Guid Id { get ; set ; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
