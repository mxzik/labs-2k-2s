using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    [Serializable]
    public class Lecturer
    {
        public string Cafedra { get; set; }
        public string FIO { get; set; }
        public string POL { get; set; }
        public string Date { get; set; }
    }
    [Serializable]
    public class Discipl
    {
        public string name;
        public int sem;
        public int sem1;
        public int kurs;
        public string spec;
        public int numoflec;
        public int numoflab;
        public string typeofcontrol;
        public Lecturer Lector = new Lecturer();

    }
}
