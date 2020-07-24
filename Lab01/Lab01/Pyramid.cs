using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Pyramid
    {
        static Pyramid() { }
        public Pyramid()
        {
            hashObj = GetHashCode();
            countObj++;
        }
        public Pyramid(int countTop) //кол-во вершин 
        {
            HashObj = GetHashCode();
            countObj++;
        }

        private readonly int hashObj;

        private const int classHash = 0;
        static public int countObj = 0;

        public int ClassHash
        {
            get
            {
                return classHash;
            }
        }
        public int HashObj
        {
            get
            {
                return hashObj;
            }
            private set
            {
                
            }
        }
        public int Height { get; set; } = 0;
        public int Area   { get; set; } = 0;

        public static void PrintInfoAboutClass()
        {
            Console.WriteLine($"Class name: {typeof(Pyramid)}");
        }
        public void TestRefAndOut(ref int a, out int b)
        {
            if (a > 10)
            {
                a = 0;
            }

            b = 12;
        }

        public override bool Equals(object obj)
        {
            Pyramid temp = obj as Pyramid;
            if (temp != null)
            {
                return this.Area == temp.Area && this.Height == temp.Height;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
