using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SampleData
    {
        public static List<User> Users = new List<User>
        {
             new User{Name="Eman",Email="Eman@yahoo.com"},
             new User{Name="Saffa",Email="Saffa@yahoo.com"},
             new User{ Name="Nessama",Email="Nessma@yahoo.com"}
        };
        public static List<Team> Teams = new List<Team>
        {
            new Team{Name="C#",Description="We design C# project",users=new List<User>
            {
                new User{Name="Eman"},
                new User{Name="Saffa"},
                new User{Name="Nessma"}
            },categories=new List<Category>
            {
                new Category("Design")
                {
                    Tasks=new List<Task>
                    {
                        new Task("Design")
                        {
                            Name="login Interface",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task("Design")
                        {
                            Name="signup Interface",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                },
                 new Category("Development")
                {
                    Tasks=new List<Task>
                    {
                        new Task("Design")
                        {
                            Name="login",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task("Design")
                        {
                            Name="signup",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                }

            } },
             new Team{Name="SQl",Description="We design SQL project",users=new List<User>
            {
                new User{Name="Eman"},
                new User{Name="Ahmed"},
                new User{Name="Hany"}
            },categories=new List<Category>
            {
                new Category("Design")
                {
                    Tasks=new List<Task>
                    {
                        new Task("Design")
                        {
                            Name="Erd Design",
                            pirority=Pirority.high,
                            IsDone=false
                        },
                        new Task("Design")
                        {
                            Name="Mapping Design",
                            pirority=Pirority.meduim,
                            IsDone=false
                        },

                    }
                }

            } }
        };
    }
}
