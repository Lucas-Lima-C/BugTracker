using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options)
            : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Attachment> Attachment { get; set; }

    }
}