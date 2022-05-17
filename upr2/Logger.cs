using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UserLogin
{
    static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserName
                + LoginValidation.currentUserRole
                + activity;

            
            if (File.Exists("logger.txt") == true)
            {
                File.AppendAllText("logger.txt",activityLine);
            }

            currentSessionActivities.Add(activityLine);  
        }

        static public void GetCurrentSessionActivities() 
        { 
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Current activity: ");

            for (int i = 0; i < currentSessionActivities.Count; i++)
            {
                stringBuilder.Append(currentSessionActivities[i]);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
