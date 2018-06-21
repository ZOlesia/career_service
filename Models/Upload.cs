using System;
using System.Collections.Generic;

namespace career{
    public class Upload{
        public int UploadId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Day { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

        public Upload()
        {
            this.Created_At = DateTime.Now;
            this.Updated_At = DateTime.Now;
        }
    }
}