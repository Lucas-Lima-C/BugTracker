using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models.Enums;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
        public TicketPriority Priority { get; set; }
        public TicketStatus Status { get; set; }
        public TicketType Type { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Attachment> Attachments { get; set; }


    }
}
