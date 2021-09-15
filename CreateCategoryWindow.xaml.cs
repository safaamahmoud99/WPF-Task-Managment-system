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
    /// Interaction logic for CreateCategoryWindow.xaml
    /// </summary>
    public partial class CreateCategoryWindow : Window
    {
        public static event Action<string> newCtegory;
        public CreateCategoryWindow()
        {
            InitializeComponent();
        }

        private void addnewCategory_Click(object sender, RoutedEventArgs e)
        {
            if (newCtegory != null && newCategoryName.Text != "")
            {
                newCtegory(newCategoryName.Text);
            }
            else
            {
                MessageBox.Show("category name empty!!please enter category name first");
            }
            newCategoryName.Text = "";
            this.Close();
        }
    }
}
