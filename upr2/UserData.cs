using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    static public class UserData
    {
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static private List<User> _testUsers;
        static private void ResetTestUserData()
        {
            if (_testUsers == null)
            {
                _testUsers = new List<User>();

                _testUsers.Add(new User()); 
                _testUsers[0].Username = "Aksay";
                _testUsers[0].Password = "admin123";
                _testUsers[0].FakNum = "121219033";
                _testUsers[0].Role = 1;
                _testUsers[0].Created = DateTime.Now;
                _testUsers[0].ValidTo = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[1].Username = "Ivancho";
                _testUsers[1].Password = "admin123";
                _testUsers[1].FakNum = "131219033";
                _testUsers[1].Role = 4;
                _testUsers[1].Created = DateTime.Now;
                _testUsers[1].ValidTo = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[2].Username = "Georgi";
                _testUsers[2].Password = "admin123";
                _testUsers[2].FakNum = "141219033";
                _testUsers[2].Role = 4;
                _testUsers[2].Created = DateTime.Now;
                _testUsers[2].ValidTo = DateTime.MaxValue;
            }
        }

        static public User IsUserPassCorrect(string username,string password)
        {
            foreach (var testUser in TestUsers)
            {
                if(testUser.Username==username && testUser.Password == password)
                {
                    return testUser;
                }
            }
            return null;
        }

        static public void SetUserActiveTo(string username,DateTime date)
        {
            foreach(var testUser in TestUsers)
            {
                if (testUser.Username == username)
                {
                    testUser.ValidTo = date;
                    Logger.LogActivity("Valid to changed to: " + date);
                }
            }
        }

        static public void AssignUserRole(string username,UserRoles role)
        {
            foreach (var testUser in TestUsers)
            {
                if (testUser.Username == username)
                {
                    testUser.Role = (int)role;
                    Logger.LogActivity("Role changed to: " + role);
                }
            }
        }
    }

    
}
