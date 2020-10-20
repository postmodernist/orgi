using System;
using System.Collections.Generic;
using System.Text;

namespace ordiDAL.Entities
{
    class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime register_at { get; set;}
        public DateTime last_updated_at { get; set; }
    }
}
