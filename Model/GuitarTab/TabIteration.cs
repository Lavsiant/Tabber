using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class TabIteration
    {
        public TabIteration()
        {
            ActiveNotes = new List<Note>();
        }

        public int ID { get; set; }

        public double WaitTimeScalar { get; set; }

        public List<Note> ActiveNotes { get; set; }
    }
}
