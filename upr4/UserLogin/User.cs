using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {   
        public string Username { get; set; }
        public string Password { get; set; }
        public string FNum { get; set; }
        public Int32 Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime ActiveTo { get; set; }
        public User() { 
        }
        public User(string username, string password, string fNum, int role, DateTime created, DateTime activeTo)
        {
            Username = username;
            Password = password;
            FNum = fNum;
            Role = role;
            Created = created;
            ActiveTo = activeTo;
        }
    }
}
