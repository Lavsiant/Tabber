using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GuitarTab
{
    public class CourseCreateViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<LessonVm> Lessons { get; set; }

        public InstrumentType Type { get; set; }

        public string UserName { get; set; }
    }

    public class LessonVm
    {
        public string Name { get; set; }

        public int repeat { get; set; }

        public int startBpm { get; set; }

        public int stepBpm { get; set; }

        public int tab { get; set; }
    }
}
