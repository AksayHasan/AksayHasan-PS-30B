using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            StudentData studentData = new StudentData();
            if (String.IsNullOrWhiteSpace(user.facNumber) || user == null)
            {
                Console.WriteLine("Faculty number is empty or there is no such student with this faculty number");
                return null;
            }

            IEnumerable<Student> students = studentData.getStudents();

            foreach (Student student in students)
            {
                if (student.FacultyNumber.Equals(user.facNumber))
                {
                    return student;
                }
            }

            Console.WriteLine("No such student!");
            return null;
        }

        public Student GetStudentDataByNameAndFacNum(string firstName,string facNumber)
        {
            StudentData studentData = new StudentData();

            IEnumerable<Student> students = studentData.getStudents();

            foreach (Student student in students)
            {
                if (student.FacultyNumber.Equals(facNumber) && student.FirstName.Equals(firstName))
                {
                    return student;
                }
            }
            return null;
        }
    }
}
