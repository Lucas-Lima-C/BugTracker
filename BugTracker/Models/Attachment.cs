using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string File { get; set; }
        public string Uploader { get; set; }
        public string Notes { get; set; }
        public DateTime CreationDate { get; set; }

        public Attachment()
        {

        }

        public Attachment(string file, string uploader, string notes, DateTime creationDate, int id)
        {
            File = file;
            Uploader = uploader;
            Notes = notes;
            CreationDate = creationDate;
            Id = id;
        }
    }
}
