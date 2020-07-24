using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Rectangle : Shape
    {
        public Rectangle(int side = default(int)) : base(minimalAngles, side)
        {
        }

        protected new const int minimalAngles = 4;
        public override void WriteToFile()
        {
            base.WriteToFile();
            Console.WriteLine("Rectangle in log!");
        }

        public static Rectangle operator++(Rectangle obj)
        {
            obj.LengthsSides++;
            return obj;
        }
        public static Rectangle operator--(Rectangle obj)
        {
            if (obj.LengthsSides-- != 0)
            {
                return obj;
            }
            obj.LengthsSides = 1;
            return obj;
        }
        public static bool operator < (Rectangle obj1, Rectangle obj2) => obj1.LengthsSides < obj2.LengthsSides;
        public static bool operator > (Rectangle obj1, Rectangle obj2) => obj1.LengthsSides > obj2.LengthsSides;
        public static bool operator ==(Rectangle obj1, Rectangle obj2) => obj1.LengthsSides == obj2.LengthsSides;
        public static bool operator !=(Rectangle obj1, Rectangle obj2) => obj1.LengthsSides != obj2.LengthsSides;

        public override string ToString() => $"Rectangle: Angles={CountAngles} Sides={LengthsSides} Perimetr={Perimetr}";
        
    }
}
