using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class ActiveCourse
    {
        public int ID { get; set; }

        public User User { get; set; }

        public Course ActivatedCourse { get; set; }
    }
}
