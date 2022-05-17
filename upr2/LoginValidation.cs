using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class LoginValidation
    {
        static public string currentUserName { get; set; }
        static public UserRoles currentUserRole { get; private set; }

        public delegate void ActionOnError(string errorMsg);

        private string _username;

        private string _password;

        private string _exceptionMessege;

        private ActionOnError _onError;

        public LoginValidation(string username,string password,ActionOnError onError)
        {
            this._username = username;
            this._password = password;
            this._onError = onError;
        }
        public bool ValidateUserInput(ref User user)
        {
            if(this._username == String.Empty )
            {
                this._exceptionMessege = "Username must not be empty !";
                _onError(_exceptionMessege);
                return false;
            }
            else if (this._username.Length < 5)
            {
                this._exceptionMessege = "Username is too short !";
                _onError(_exceptionMessege);
                return false;
            }

            if (this._password == String.Empty)
            {
                this._exceptionMessege = "Password must not be empty !";
                _onError(_exceptionMessege);
                return false;
            }
            else if (this._password.Length < 5)
            {
                this._exceptionMessege = "Password too short !";
                _onError(_exceptionMessege);
                return false;
            }

            user = UserData.IsUserPassCorrect(this._username,this._password);
            if (user!=null)
            {
                currentUserRole = (UserRoles)user.Role;
                currentUserName=this._username;
            }
            else
            {
                user = new User();
                currentUserRole = 0;
            }

            Logger.LogActivity("Log in successful !");
            return true;
        }  

    }
}
