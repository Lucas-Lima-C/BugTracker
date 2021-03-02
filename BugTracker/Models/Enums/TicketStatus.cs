using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models.Enums
{
    public enum TicketStatus : int
    {
        Open = 0,
        InProgress = 1,
        Closed = 2,
    }
}
