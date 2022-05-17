using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        private static void LogError(string errorMsg)
        {
            Console.WriteLine("!!! " + errorMsg + " !!!");

            string a = Console.ReadLine();
        }

        private static void ShowAdminOptions()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change user role");
            Console.WriteLine("2: Change user activeTo");
            Console.WriteLine("3: Show list of users");
            Console.WriteLine("4: Show activity log");
            Console.WriteLine("5: Show current activity");
            Console.WriteLine("6: Show login fail log");
            Int32 option = Int32.Parse(Console.ReadLine());
            string username;

            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Enter username");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter new user role (1: Admin; 2: Inspector; 3: Professor; 4: Student");
                    UserRoles role = (UserRoles)Int32.Parse(Console.ReadLine());
                    UserData.AssignUserRole(username, role);
                    break;
                case 2:
                    Console.WriteLine("Enter username");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter new activeTo date (example: 01.01.2022 00:00:00)");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    UserData.SetUserActiveTo(username, dateTime);
                    break;
                case 3:
                    break;
                case 4:
                    IEnumerable<string> activityLog = Logger.GetActivityLog();
                    foreach(string line in activityLog)
                    {
                        Console.WriteLine(line.ToString());
                    }
             
                    break;
                case 5:
                    StringBuilder sb = new StringBuilder();
                    string filter = "";
                    IEnumerable<string> currentActs = Logger.GetCurrentSessionActivities(filter);
                    foreach (string line in currentActs)
                    {
                        sb.Append(line);
                    }
                    break;
                case 6:
                    StreamReader sr = new StreamReader("logFail.txt");
                    sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        sb.Append(sr.ReadLine());
                        Console.WriteLine(sb.ToString());
                    }
                    sr.Close();
                    break;
                default:
                    break;
            }
            ShowAdminOptions();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете username");
            string username = Console.ReadLine();
            Console.WriteLine("Въведете password");
            string password = Console.ReadLine();

            LoginValidation validation = new LoginValidation(username, password, LogError);
            User user = new User();
  

            if (validation.ValidateUserInput(ref user))
            {
                Console.WriteLine(user.Username + " " + user.Password + " " + user.FNum + " " + user.Role);

                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.ADMIN:
                        Console.WriteLine("The user is admin");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("The user is student");
                        break;

                }

                if (LoginValidation.currentUserRole == UserRoles.ADMIN)
                {
                    ShowAdminOptions();
                }
            }

         

     
        }
    }
}
