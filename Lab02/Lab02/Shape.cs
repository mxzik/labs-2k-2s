using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab02
{
    class Shape : IControl
    {
        public Shape(int angles = minimalAngles, int lengthSide = default(int))
        {
            checked
            {
                CountAngles = angles > minimalAngles ? angles : 3;
                LengthsSides = lengthSide;
            }
        }
        protected const int minimalAngles = 3;

        protected int lengthsSides = default(int);
        public int LengthsSides
        {
            get
            {
                return lengthsSides;
            }
            set
            {
                lengthsSides = value > 0 ? value : 0;
                setPerimetr();
            }
        }
        public int CountAngles { get;protected set; } = minimalAngles;
        public int Perimetr    { get; protected set; }

        protected void setPerimetr()
        {
            Perimetr = checked(LengthsSides * CountAngles);
        }

        public void Show()
        {
            Console.WriteLine(this.ToString()); 
        }

        public bool Input()
        {
            Console.WriteLine("Enter size side:");
            try
            {
                checked
                {
                    LengthsSides = int.Parse(Console.ReadLine());
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Wrong argument\nError: {ex.Message}");
                return false;
            }
            return true;
        }

        public virtual void WriteToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\InfoAboutShape.txt",false, Encoding.Default))
                {
                    sw.WriteLine(this.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
                return;
            }
            Console.WriteLine($"Successful wirte to file");
        }

        public override string ToString() => $"Shape: Angles={CountAngles} Sides={LengthsSides} Perimetr={Perimetr}";
    }
}
