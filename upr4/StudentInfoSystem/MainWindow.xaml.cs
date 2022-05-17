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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int userCounter = 0;

        public Student _student;
        public Student Student
        {
            get { return _student; }
            set { SetStudent(value); }

        }

        public void SetStudent(Student student)
        {
            if (student == null || string.IsNullOrEmpty(student.name))
            {
                ClearAllBoxes();
                DisableForm();
            }
            else
            {
                DisplayStudent(student);
                EnableForm();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearAllBoxes()
        {
            foreach (var item in gridPersonalInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            foreach (var item in gridStudentInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void DisplayStudent(Student student)
        {
            txtFirstName.Text = student.name;
            txtSurname.Text = student.surName;
            txtLastName.Text = student.lastName;
            txtFaculty.Text = student.faculty;
            txtSpecialty.Text = student.faculty;
            txtDegree.Text = student.degree;
            txtStatus.Text = student.status;
            txtFacultyNumber.Text = student.facultyNumber;
            txtCourse.Text = student.year.ToString();
            txtStream.Text = student.stream.ToString();
            txtGroup.Text = student.group.ToString();
        }

        private void DisableForm()
        {
            foreach (var item in gridPersonalInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
            foreach (var item in gridStudentInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void EnableForm()
        {
            foreach (var item in gridPersonalInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
            foreach (var item in gridStudentInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        private void btnLoadStudent_Click(object sender, RoutedEventArgs e)
        {
            this.Student = StudentData.TestStudents[0];
        }

        private void btnLoadEmpty_Click(object sender, RoutedEventArgs e)
        {
            this.Student = null;
        }

        private void btnLoadNext_Student(object sender, RoutedEventArgs e) {

            testLabel.Content = "The program is in test mode";

            if (StudentData.TestStudents.Count - 2 < userCounter && StudentData.TestStudents.Count != 0)
            {
                userCounter = 0;
                this.Student = StudentData.TestStudents[userCounter];
            }
            else {
                userCounter++;
                this.Student = StudentData.TestStudents[userCounter];
                
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo si = new StudentInfo();
            si.Show();
        }
    }
}
