using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FakNum { get; set; }

        public int Role { get; set; }

        public DateTime Created { get; set; }

        public DateTime ValidTo { get; set; }
    }
}
