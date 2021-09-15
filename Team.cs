using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   class Team
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<User> users = new List<User>();

        public List<Category> categories = new List<Category>();
        public List<Task> TeamTasks = new List<Task>();

        public Archive archive = new Archive();

        public Team()
        {
           

        }
        public Team(string name)
        {
            this.Name = name;
        }
        public Team(string name,string description)
        {
            this.Name = name;
            this.Description = description;
            
        }

        public void DisplayTeamInformation()
        {
            Console.WriteLine($"Team Name : {Name}");
            Console.WriteLine("______________________________________");
            Console.WriteLine($"Team Description : {Description}");
            Console.WriteLine("______________________________________");
            Console.WriteLine("Team Members Informations :");
            foreach(User user in users)
            {
                user.GetUserDetails();
            }
            Console.WriteLine("______________________________________");
            Console.WriteLine("Team Categories :");
            //    foreach (Category category in categories)
            //    {
            //       Console.WriteLine( category.ToString());

            //        foreach(Task task in category.Tasks)
            //        {
            //            Console.WriteLine(task.ToString());
            //        }


            //    }




        }
    }

}
