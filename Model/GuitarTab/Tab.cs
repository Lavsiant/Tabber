using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class Tab
    {
        public Tab()
        {
            Iterations = new List<TabIteration>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public InstrumentType GuitarType { get; set; }

        public List<TabIteration> Iterations { get; set; }

        public double Tempo { get; set; }

        //Creator login
        public string Creator { get; set; }
    }
}
