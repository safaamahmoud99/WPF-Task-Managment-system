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
    /// Interaction logic for CreatTeam.xaml
    /// </summary>
   
    public partial class CreatTeam : Window
    {
         public static event Action<string, string> NewTeam;
        public CreatTeam()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Team Add_team = new Team(txtbxTeamName.Text, txtbxDescrip.Text);
           NewTeam(Add_team.Name, Add_team.Description);
            SampleData.Teams.Add(Add_team);

            this.Hide();
            TeamWindow w = new TeamWindow(txtbxTeamName.Text);
            w.Show();
        }
    }
}
