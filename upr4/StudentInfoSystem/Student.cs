using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string lastName { get; set; }
        public string faculty { get; set; }
        public string major { get; set; }
        public string degree { get; set; }
        public string status { get; set; }
        public string facultyNumber { get; set; }
        public int year { get; set; }
        public int stream { get; set; }
        public int group { get; set; }

        public Student(string name, string surName, string lastName, string faculty, string major, string degree, string status, string facultyNumber, int year, int stream, int group)
        {
            this.name = name;
            this.surName = surName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.major = major;
            this.degree = degree;
            this.status = status;
            this.facultyNumber = facultyNumber;
            this.year = year;
            this.stream = stream;
            this.group = group;
        }
    }
}
