using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.ViewModels
{
    public class CourseCreateViewModel
    {
        public string Name { get; set; }

        public List<Lesson> Lessons { get; set; }

        public InstrumentType Type { get; set; }
    }
}
