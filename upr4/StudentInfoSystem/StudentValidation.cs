using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
namespace StudentInfoSystem
{ class StudentValidation
    {
        static Student GetStudentDataByUser(User user)
        {
            string FacultyNumber = user.FNum;
            if (string.IsNullOrEmpty(FacultyNumber))
            {
                return null;
            }
            return (from student in StudentData.TestStudents where student.facultyNumber == FacultyNumber select student).FirstOrDefault();
        }
    }
}
