using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public User Commenter { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }

        public Comment()
        {

        }

        public Comment(User commenter, string message, DateTime creationDate, int id)
        {
            Commenter = commenter;
            Message = message;
            CreationDate = creationDate;
            Id = id;
        }
    }
}
