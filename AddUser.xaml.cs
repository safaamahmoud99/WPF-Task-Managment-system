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

namespace Project
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    /// 
    public partial class AddUser : Window
    {
        public static event Action<string, string> newuser;
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool vaild = true;


            // lblEmailValidation.Visible = false;


            if (txtbxUserName.Text.Length >= 4)
            {
                NamError.Visibility = Visibility.Hidden;

            }
            else
            {
                NamError.Visibility = Visibility.Visible;
                vaild = false;
            }


            if (txtbxmail.Text.Contains("@") && txtbxmail.Text.Contains("."))
            {
                EmailError.Visibility = Visibility.Hidden;

            }
            else
            {

                EmailError.Visibility = Visibility.Visible;

                vaild = false;

            }

            if (vaild == true)
            {

                User AddNewUser = new User(txtbxUserName.Text, txtbxmail.Text);


               
                SampleData.Users.Add(AddNewUser);


               
                newuser(AddNewUser.Name, AddNewUser.Email);
                MessageBox.Show("sucess added user");
                txtbxUserName.Text = "";
                txtbxmail.Text = "";
                this.Hide();
            }
                
           
          //  this.Close();
        }
    }
}
