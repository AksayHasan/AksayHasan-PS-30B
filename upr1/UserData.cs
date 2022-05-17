using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    static public class UserData
    {
        static public User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        static private User _testUser;
        static private void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User();
                _testUser.Username = "Aksay";
                _testUser.Password = "admin123";
                _testUser.FakNum = "121219033";
                _testUser.Role = 2;
            }
        }
    }

    
}
