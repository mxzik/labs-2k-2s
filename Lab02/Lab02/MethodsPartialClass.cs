using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    partial class PartialClass
    {
        public PartialClass()
        {
            Console.WriteLine("Partial class");
        }

        public void SayHello() { Console.WriteLine("Hi"); }
        public string GetLabel() { return SomeLabel; }
    }
}
