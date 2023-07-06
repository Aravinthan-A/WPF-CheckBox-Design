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

namespace Genderproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("WELCOME", "LOGIN", MessageBoxButton.YesNoCancel);
            string gender = "";
            if(chkmale.IsChecked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("YES");
                MessageBox.Show("Your Name is:" + txtname.Text + ",Your Age is:" + txtage.Text + ",Password is:" + pwdpassword.Password + ",Your gender:" + gender);
            }
            if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No");
            }
            if (result == MessageBoxResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
