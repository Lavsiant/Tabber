using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class Course
    {
        public Course()
        {
            Lessons = new List<Lesson>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public List<Lesson> Lessons { get; set; }

        public InstrumentType Type { get; set; }

        public string Description { get; set; }

        public string Creator { get; set; }
    }
}
