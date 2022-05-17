using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for StudentInfo.xaml
    /// </summary>
    public partial class StudentInfo : Window
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        public Student checkLogin(String username,String facNum)
        {
            
            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(facNum))
            {
                return null;
            }

            
            foreach(Student student in StudentData.TestStudents)
            {
                if(student.name.Equals(username) && student.facultyNumber.Equals(facNum))
                {
                    return student;
                }
            }

            return null;            
        }

        public void btnLoginStudent_Click(object sender, RoutedEventArgs e)
        {
            String username = txtFirstName.Text;
            String facNum = txtFacultyNumber.Text;
            Student student = checkLogin(username, facNum);
            if(student != null)
            {
                MainWindow newSI = new MainWindow();
                this.Close();
                newSI.Show();
                newSI.SetStudent(student);

            }




        }
    }
}
