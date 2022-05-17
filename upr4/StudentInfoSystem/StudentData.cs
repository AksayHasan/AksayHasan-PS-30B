using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        static public List<Student> TestStudents
        {
            get { return _testStudents; }
            private set { }
        }

        static private List<Student> _testStudents = new List<Student>()
        {
            new Student("Enis", "Berkant", "Arabov", "FKSU", "KSI", "master", "ended", "121219029", 1, 3, 32),
            new Student("Dimitar", "Dimitrov", "Dimitrov", "FPMI", "KSI", "bachelor", "ended", "121219088", 3, 1, 32),
            new Student("Orhan", "Velizarov", "Dumaev", "FKSU", "KSI", "PHD", "ended", "121219063", 4, 2, 31),

        };

    }
}
