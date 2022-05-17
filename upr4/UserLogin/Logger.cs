using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserUsername + ";"
                + LoginValidation.currentUserRole + ";" + activity + "\n";
            currentSessionActivities.Add(activityLine);

            File.AppendAllText("log.txt", activityLine);
        }

        static public void LoginFail(short error, String errorInfo)
        {
            string activityLine = DateTime.Now + ";"
               + error + ";"
               + errorInfo + "\n";
            currentSessionActivities.Add(activityLine);
            File.AppendAllText("log.txt", activityLine);

        }
        static public IEnumerable<string> GetActivityLog()
        {
            StreamReader sr = new StreamReader("log.txt");
            List<string> line = new List<string>();
            while (!sr.EndOfStream)
            {
                line.Add(sr.ReadLine());
            }
            sr.Close();
            return line;
        }
        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();
            return filteredActivities;
        }
    }
}
