using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class LoginValidation
    {
        static public UserRoles currentUserRole { get; private set; }
        public bool ValidateUserInput()
        {
            currentUserRole = UserRoles.ADMIN;
            return true;
        }  
    }
}
