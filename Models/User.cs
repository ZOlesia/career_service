using System;
using System.Collections.Generic;


namespace career.Models{
    public class User{
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

        public User()
        {
            this.Created_At = DateTime.Now;
            this.Updated_At = DateTime.Now;
        }
    }

}