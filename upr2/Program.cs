using System;
using static UserLogin.LoginValidation;
using System.IO;
using System.Text;

namespace UserLogin
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ActionOnError actionOnError = new ActionOnError(Nofity);
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(username,password,actionOnError);

            User user=null;
            if (loginValidation.ValidateUserInput(ref user) == true)
            {
                Console.WriteLine("Username: " +user.Username);
                Console.WriteLine("Password: " + user.Password);
                Console.WriteLine("FakNum: " + user.FakNum);
                Console.WriteLine("Role: " + (UserRoles)user.Role);
                Console.WriteLine("Created: " + user.Created);

                switch (user.Role)
                {
                    case 0:
                        Console.WriteLine($"Who are you ? ");
                        break;

                    case 1:
                        Console.WriteLine($"Welcome, {LoginValidation.currentUserRole} !");
                        AdminPrivileges();
                        break;

                    case 2:
                        Console.WriteLine($"Welcome, {LoginValidation.currentUserRole} !");
                        break;

                    case 3:
                        Console.WriteLine($"Welcome, {LoginValidation.currentUserRole} !");
                        break;

                    case 4:
                        Console.WriteLine($"Welcome, {LoginValidation.currentUserRole} !");
                        break;
                }
            }

            
        }
        static void Nofity(string str)
        {
            Console.WriteLine(str);
        }

        static void AdminPrivileges()
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change user role");
            Console.WriteLine("2: Change active to");
            Console.WriteLine("3: List of users:");
            Console.WriteLine("4: View log");
            Console.WriteLine("5: View current activity");
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Console.WriteLine("Bye,bye...");
                    break;

                case "1":
                    Console.WriteLine("Enter username:");
                    string username=Console.ReadLine();
                    Console.WriteLine("Enter user role (int):");
                    int role = int.Parse(Console.ReadLine());
                    UserRoles userRole = (UserRoles)role;
                    UserData.AssignUserRole(username, userRole);
                    Console.WriteLine("Changes saved successfully !");
                    break;

                case "2":
                    Console.WriteLine("Enter username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UserData.SetUserActiveTo(userName, date);
                    Console.WriteLine("Changes saved successfully !");
                    break;

                case "3":
                    
                    break;

                case "4":
                    if (File.Exists("logger.txt") == true)
                    {
                        var lines = File.ReadAllText("logger.txt");
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append("Log file: ");

                        for (int i = 0; i < lines.Length; i++)
                        {
                            stringBuilder.Append(lines[i]);
                        }

                        Console.WriteLine(stringBuilder.ToString());
                        
                    }
                    break;

                case "5":
                    Logger.GetCurrentSessionActivities();
                    break;

                default:
                    Console.WriteLine("Invalid input !");
                    break;
            }
        }
    }
}
