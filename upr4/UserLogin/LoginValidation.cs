using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {

        public static UserRoles currentUserRole { get; private set; }
        public static string currentUserUsername { get; private set; }

        private string username;
        private string password;
        private string errorMessage;

        public delegate void ActionOnError(string errorMsg);

        private ActionOnError actionOnError;

        public LoginValidation(string username, string password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = actionOnError;
        }

        public bool ValidateUserInput(ref User user)
        {
            currentUserRole = UserRoles.ANONYMOUS;

            if (username.Equals(String.Empty))
            {
                errorMessage = "Няма въведено име";
                Logger.LoginFail(1 , errorMessage);
                actionOnError(errorMessage);
                return false;
            }

            if (password.Equals(String.Empty))
            {
                errorMessage = "Няма въведена парола";
                Logger.LoginFail(2, errorMessage);
                actionOnError(errorMessage);
                return false;
            }

            if (username.Length < 5)
            {
                errorMessage = "Username е под 5 символа";
                Logger.LoginFail(3, errorMessage);
                actionOnError(errorMessage);

                return false;
            }

            if (password.Length < 5)
            {
                errorMessage = "Паролата е под 5 символа";
                Logger.LoginFail(3, errorMessage);
                actionOnError(errorMessage);
                return false;
            }

            user = UserData.IsUserPassCorrect(username, password);
            if (user == null)
            {
                errorMessage = "User не съществува";
                Logger.LoginFail(4, errorMessage);
                actionOnError(errorMessage);
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
            currentUserUsername = username;
            Logger.LogActivity("Login successful");

            return true;
        }
    }
}
