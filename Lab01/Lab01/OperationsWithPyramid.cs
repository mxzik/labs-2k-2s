using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    static class OperationsWithPyramid
    {
        public static int CalculateVolume(Pyramid obj) => obj.Area * obj.Height;

        public static bool IsInsertInBox(this Pyramid obj, int a, int b, int c) => CalculateVolume(obj) < a * b * c;
    }
}
