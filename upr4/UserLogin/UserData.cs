using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers;
        static public List<User> TestUsers
        {
            get { ResetTestUserData(); return _testUsers; }
            set { }
        }
        private static void ResetTestUserData()
        {
            if (_testUsers == null)
            {
                User tempUser;
                _testUsers = new List<User>();

                tempUser = new User();
                tempUser.Username = "vasil123";
                tempUser.Password = "asdasd123";
                tempUser.FNum = "121219061";
                tempUser.Role = (int)UserRoles.ADMIN;
                tempUser.Created = DateTime.Now;
                tempUser.ActiveTo = DateTime.MaxValue;
                TestUsers.Add(tempUser);

                tempUser = new User();
                tempUser.Username = "student1";
                tempUser.Password = "asdasd123";
                tempUser.FNum = "121219071";
                tempUser.Role = (int)UserRoles.STUDENT;
                tempUser.Created = DateTime.Now;
                tempUser.ActiveTo = DateTime.MaxValue;
                TestUsers.Add(tempUser);

                tempUser = new User();
                tempUser.Username = "student2";
                tempUser.Password = "asdasd123";
                tempUser.FNum = "121219081";
                tempUser.Role = (int)UserRoles.STUDENT;
                tempUser.Created = DateTime.Now;
                tempUser.ActiveTo = DateTime.MaxValue;
                TestUsers.Add(tempUser);
            }
        }

        static public User IsUserPassCorrect(string username, string password)
        {
            return (from user in TestUsers where user.Password == password && user.Username == username select user).First();
        }

        static public void SetUserActiveTo(string username, DateTime date)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.ActiveTo = date;
                    Logger.LogActivity("ActiveTo changed for user " + username);
                    return;
                }
            }
        }
        static public void AssignUserRole(string username, UserRoles role)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.Role = (Int32)role;
                    Logger.LogActivity("Role changed for user " + username);
                    return;
                }
            }
        }
    }
}
