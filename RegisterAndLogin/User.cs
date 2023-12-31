﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAndLogin
{


    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }



        public override string ToString()
        {
            return $"Username : {Username}\n";
        }
        public override bool Equals(object obj)
        {
            if (!(obj is User) || obj == null)
            {
                return false;
            }
            User user = obj as User;
            return user.Username == Username;
        }
    }
}