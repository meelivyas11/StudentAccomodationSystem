using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAccommodationSystem.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        public UserModel (string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        public UserModel() { }
    }
}