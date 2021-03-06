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
    public partial class MainWindow : Window
    {
        public Student student;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clear()
        {
            foreach(var item in MainGrid.Children)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void setStudent(Student student)
        {
            if(isStudentDataCorrect(student))
            {
                enableControls();
                fillStudentInfo(student);
            }
            else
            {
                clear();
                disableControls();
            }
            
        }

        private Boolean isStudentDataCorrect(Student student)
        {
            return student != null && !String.IsNullOrWhiteSpace(student.firstName) && !String.IsNullOrWhiteSpace(student.secondName) && !String.IsNullOrWhiteSpace(student.lastName)
                && !String.IsNullOrWhiteSpace(student.faculty) && !String.IsNullOrWhiteSpace(student.speciality) && !String.IsNullOrWhiteSpace(student.degree)
                && !String.IsNullOrWhiteSpace(student.status) && !String.IsNullOrWhiteSpace(student.facultyNumber) && student.course != 0
                && student.flow != 0 && student.group != 0;
        }

        private void fillStudentInfo(Student student)
        {   
            this.student = student;

            txtFirstName.Text = this.student.firstName;
            txtSecondName.Text = this.student.secondName;
            txtLastName.Text = this.student.lastName;
            txtFaculty.Text = this.student.faculty;
            txtSpeciality.Text = this.student.speciality;
            txtDegree.Text = this.student.degree;
            txtStatus.Text = this.student.status;
            txtFacultyNumber.Text = this.student.facultyNumber;
            txtCourse.Text = Convert.ToString(this.student.course);
            txtFlow.Text = Convert.ToString(this.student.flow);
            txtGroup.Text = Convert.ToString(this.student.group);
        }

        private void disableControls()
        {
            foreach(Control ctr in MainGrid.Children)
            {
                if(ctr.Name == "btnUnlock" || ctr.Name == "btnTest")
                {
                    ctr.IsEnabled = true;
                }
                else
                {
                    ctr.IsEnabled = false;
                }
            }
        }

        private void enableControls()
        {
            foreach(Control ctr in MainGrid.Children)
            {
                ctr.IsEnabled = true;
            }
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            StudentData data = new StudentData();
            setStudent(data.getStudents().First());
        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {
            setStudent(null);
        }

        private void btnLock_Click(object sender, RoutedEventArgs e)
        {
            disableControls();
        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            enableControls();
        }
    }
}
