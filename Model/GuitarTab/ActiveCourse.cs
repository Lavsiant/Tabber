using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class ActiveCourse
    {
        public User User { get; set; }

        public Course ActivatedCourse { get; set; }
    }
}
