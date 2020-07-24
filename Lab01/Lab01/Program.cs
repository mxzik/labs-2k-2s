using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        [STAThread]
        static void Main(string[] args) // ready
        {
            Pyramid f1 = new Pyramid();
            Pyramid f2 = new Pyramid();

            Console.WriteLine("Hash:");
            Console.WriteLine(f1.HashObj);
            Console.WriteLine(f2.HashObj);
            Console.WriteLine($"Number of object is {Pyramid.countObj}");
            Pyramid.PrintInfoAboutClass();
            Console.WriteLine();
            int a = 52, b = 0;
            Console.WriteLine($"Before: {a} , {b}");
            Pyramid ObjForTestParams = new Pyramid();
            ObjForTestParams.TestRefAndOut(ref a, out b);
            Console.WriteLine($"After: {a} , {b}");
            // Equal and GetHashCode
            f1.Area = 3;
            f1.Height = 2;
            Console.WriteLine($"Volume = {OperationsWithPyramid.CalculateVolume(f1)}");
            Console.WriteLine();
            Console.WriteLine("Compare F1 and F2:");
            Console.WriteLine($"F1: Area = {f1.Area}, Height = {f1.Height}");
            Console.WriteLine($"F2: Area = {f2.Area = 2}, Height = {f2.Height = 3}");
            Console.WriteLine($"Equal: {f1.Equals(f2)}");
            Console.WriteLine();
            Console.WriteLine($"F1: Area = {f1.Area}, Height = {f1.Height}");
            Console.WriteLine($"F2: Area = {f2.Area = 3}, Height = {f2.Height = 2}");
            Console.WriteLine($"Equal: {f1.Equals(f2)}");
            Console.WriteLine();
            Console.WriteLine($"Input size box: ");
            int a1, a2, a3;
            try
            {
                a1 = int.Parse(Console.ReadLine());
                a2 = int.Parse(Console.ReadLine());
                a3 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Can we insert our pyramid in box? {f1.IsInsertInBox(a1,a2,a3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooops");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            var anonymPiramyd = new { Area = 20, Height = 12 };
            Console.WriteLine($"Type: {anonymPiramyd.GetType()}\nName = {anonymPiramyd.Area} | Age={anonymPiramyd.Height}");
        }
    }
}
