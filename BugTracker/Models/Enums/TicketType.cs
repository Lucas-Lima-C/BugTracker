using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models.Enums
{
    public enum TicketType : int
    {
        BugsErrors = 0,
        TrainingRequest = 1,
        FeatureRequest = 2,
        Comment = 3,
    }
}
