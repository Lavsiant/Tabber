using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.UserModel
{
    public class User
    {
        public User()
        {
            BoughtTabs = new List<Tab>();
            Courses = new List<Course>();
        }

        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
       
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Tab> BoughtTabs { get; set; }

        public List<Course> Courses { get; set; }

        public bool IsAdmin { get; set; }

        public string Bio { get; set; }
    }
}
