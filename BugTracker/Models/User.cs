﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User()
        {

        }

        public User(string name, string email, int id)
        {
            Name = name;
            Email = email;
            Id = id;
        }
    }
}
