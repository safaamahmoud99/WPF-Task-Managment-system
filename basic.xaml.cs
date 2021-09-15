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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class basic : Window
    {
        List<Team> listOfTeams = new List<Team>();

        public basic()
        {
            InitializeComponent();
            AddUser.newuser += adduser;
            CreatTeam.NewTeam += addteam; 
             
        }

       
        private void addteam(string teamName, string teamDesciption)
        {
            listOfTeams.Add(new Team(teamName, teamDesciption));
            //int width = 120;
            //int height = 100;

            //foreach (Team team in listOfTeams)
            //{

                Button dynamicTeamBtn = new Button();
                dynamicTeamBtn.Width = 120;
                dynamicTeamBtn.Height = 100;
                dynamicTeamBtn.Content = teamName;
            
                dynamicTeamBtn.Click += new RoutedEventHandler(ShowTeam);
                sp.Children.Add(dynamicTeamBtn);
                
                //dynamicTeamBtn.Location = new Point(width, height);
                //dynamicTeamBtn.Text = team.Name;
                //dynamicTeamBtn.Font = new Font("Georgia", 16);
                //dynamicTeamBtn.Click += new EventHandler(ShowTeam);
                //dynamicTeamBtn.Size = new Size(150, 70);
                // Team_Tab.Controls.Add(dynamicTeamBtn);
                //width += 160;
                //loc2 += 50;
                // label1.Text = "you have " + listOfTeams.Count.ToString() + " Teams";
            //}

        }
        public void ShowTeam(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Content.ToString();
            TeamWindow teamform = new TeamWindow(s);
            teamform.Show();
        }


        //private void adduser(string arg1, string arg2, string arg3)
        //{

        //}
        private void adduser(string nameOFuser, string emailofuser)
        {
            // ListViewItem items = listView.Items.Add(nameOFuser);
            // items.SubItems.Add(emailofuser);
            User c = new User(nameOFuser, emailofuser);

           SampleData.Users.Add(c);

            listView.Visibility = Visibility.Visible;
            lvData.Visibility = Visibility.Visible;
        
             //listView.ItemsSource = SampleData.Users;
            // listView.ItemsSource = "";
            this.listView.Items.Add(new User { Name = nameOFuser, Email = emailofuser});
            lvData.Content = "No Of Users " + listView.Items.Count;

        }

      

        private void addTeam_btn_Click(object sender, RoutedEventArgs e)
        {
            CreatTeam addteam = new CreatTeam();
            addteam.Show();
        }

        private void addUser_btn_Click(object sender, RoutedEventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();

        }
    }
}
