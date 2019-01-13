using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.ViewModels
{
    public class TabCreateViewModel
    {

        public string Name { get; set; }

        public int Type { get; set; }


        public int Tempo { get; set; }

        //Creator login
        public string Creator { get; set; }

        public List<TabIteration> iterations { get; set; }
    }
}
