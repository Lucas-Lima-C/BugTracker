﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<User> Users { get; set; }

        public Project()
        {

        }

        public Project(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
