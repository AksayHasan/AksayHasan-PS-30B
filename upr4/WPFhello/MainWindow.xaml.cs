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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem mike = new ListBoxItem();
            mike.Content = "Mike";
            peopleListBox.Items.Add(mike);

            ListBoxItem lisa = new ListBoxItem();
            lisa.Content = "Lisa";
            peopleListBox.Items.Add(lisa);

            ListBoxItem john = new ListBoxItem();
            john.Content = "John";
            peopleListBox.Items.Add(john);

            ListBoxItem mary = new ListBoxItem();
            mary.Content = "Mary";
            peopleListBox.Items.Add(mary);

            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);


            peopleListBox.SelectedItem = james;
                    
           
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            Boolean isErrorProne = false;

            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox) {
                    s = s + ((TextBox)item).Text;
                    s = s + "\n";
                }

                if (item is TextBox && ((TextBox)item).Text.Length < 2) {
                    MessageBox.Show("Грешка!!! Моля въведете текст с дължина над 2 символа!!!");
                    isErrorProne = true;
                    break;
                }

            }
            if (!isErrorProne) MessageBox.Show("Здравейте " + s + "!!!\n Това е твоята първа програма на Visual Studio 2012!");
        }

        private void Btn_Click(object sender, RoutedEventArgs e) {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {

            string msg = "Terminate the app?";
            MessageBoxResult result =
              MessageBox.Show(
                msg,
                "Warning",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                // If user doesn't want to close, cancel closure
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnHandleList(object sender, RoutedEventArgs e) {
            string greetingMessage;
            greetingMessage = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMessage);    
        }

       
    }
}
