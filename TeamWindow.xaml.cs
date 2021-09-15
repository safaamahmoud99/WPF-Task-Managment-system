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
    /// Interaction logic for TeamWindow.xaml
    /// </summary>
    public partial class TeamWindow : Window
    {
        public TeamWindow(string TName)
        {
            InitializeComponent();
            Team curent = GetCurrentTeam(TName);
            teamnamelabl.Text = TName;
            CreateCategoryWindow.newCtegory += AddCategory;
            TeamUsers.ItemsSource = curent.users;

        }
        private Team checkExistingTeam(string name)
        {
            Team Currentteam = new Team();
            foreach (Team team in SampleData.Teams)
            {
                if (team.Name == name)
                {
                    Currentteam = team;
                }
            }
            return Currentteam;

        }
        private Team GetCurrentTeam(String Teamname)
        {
            Team t = checkExistingTeam(Teamname);
            if (string.IsNullOrEmpty(t.Name))
            {
                SampleData.Teams.Add(new Team(Teamname));
                t = checkExistingTeam(Teamname);
            }
            return t;

        }
        private void FillCategoryList()
        {
            Team current = GetCurrentTeam(teamnamelabl.Text);
            foreach (Category i in current.categories)
            {
                categoryList.ItemsSource = current.categories;
            }
        }
        private bool CheckifCategoryExist(string name)
        {
            bool result = false;
            Team t = GetCurrentTeam(teamnamelabl.Text);
            foreach (Category c in t.categories)
            {
                if (c.Name == name)
                    result = true;
            }
            return result;
        }
        public void AddCategory(string name)
        {
            Team Currentteam = GetCurrentTeam(teamnamelabl.Text);
            if (CheckifCategoryExist(name))
            {
                MessageBox.Show("Exist");
            }
            else
            {
                Currentteam.categories.Add(new Category(name));
                categoryList.ItemsSource = null;
                foreach (Category c in Currentteam.categories)
                {
                    categoryList.ItemsSource = Currentteam.categories;
                }
            }

        }
        private void fillListOfTask(List<Task> Tasks)
        {
            TasksList.Items.Clear();
            foreach (Task task in Tasks)
            {
                if (task.IsDone == false)
                    TasksList.Items.Add(task);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateCategoryWindow categoryWindow = new CreateCategoryWindow();
            categoryWindow.Show();
        }

        private void AddTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTask t = new AddTask();
            t.Show();
        }

       
        private void addM_Click(object sender, RoutedEventArgs e)
        {
            InviteUser u = new InviteUser();
            u.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void categoryList_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (categoryList.SelectedIndex == -1)
            {
                return;
            }
            Category category = (Category)categoryList.SelectedItem;
            fillListOfTask(category.Tasks);
        }
        private void TeamWindow_Load(object sender, RoutedEventArgs e)
        {
            FillCategoryList();
        }

        private void viewTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            ViweTask viwe = new ViweTask();
            viwe.Show();
        }
    }
}
