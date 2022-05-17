using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation loginValidation = new LoginValidation();
            if (loginValidation.ValidateUserInput() == true)
            {
                Console.WriteLine("Username: " + UserData.TestUser.Username);
                Console.WriteLine("Password: " + UserData.TestUser.Password);
                Console.WriteLine("FakNum: " + UserData.TestUser.FakNum);
                Console.WriteLine(LoginValidation.currentUserRole);
            }
        }
    }
}
