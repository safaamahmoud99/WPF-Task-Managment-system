using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
       
        public string Name { set; get; }
        public string Email { set; get; }
        
        public string Picture { set; get; }
        public User() { }
        public User(  string name, string email, string picture)
        {
           
            Name = name;
            Email = email;
            Picture = picture;
        }
        public User( string name, string email )
        {
           
            Name = name;
            Email = email;
            
            Picture = "default photo";
        }
        public void GetUserDetails()
        {
            Console.WriteLine($" userName : {Name}, userEmail : {Email} ");

        }
      
        /*main */
        /* User user1 = new User()
            {
                 ID = 1,
                Name = "safaa",
                Password = "11111",
                Email = "safa",
               Picture = "ssss"
            };
            User user2 = new User()
            {
                ID = 2,
                Name = "nessma",
                Password = "11111",
                Email = "safa",
                Picture = "ssss"
            };
            User user3 = new User()
            {
                ID = 3,
                Name = "Eman",
                Password = "11111",
                Email = "safa",
                Picture = "ssss"
            };
            List<User> Users = new List<User>();
            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            foreach(User u in Users)
            {
               // Console.WriteLine("ID= {0},Name={1},Email={2}", u.ID, u.Name, u.Email);
                u.GetUserDetails();
            }
            


            Console.ReadKey();*/


    }
}
