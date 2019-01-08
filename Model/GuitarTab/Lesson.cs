using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class Lesson
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Tab Tab { get; set; }

        public int RepeatNumber { get; set; }

        public int StartBpm { get; set; }

        public int MinTempoStep { get; set; }
    }
}
