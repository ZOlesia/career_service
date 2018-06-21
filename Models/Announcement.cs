using System;
using System.Collections.Generic;

namespace career{
    public class Announcement {
        public int AnId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

        public Announcement()
        {
            this.Created_At = DateTime.Now;
            this.Updated_At = DateTime.Now;
        }


    }
}