using System;
using PatternMemento;

namespace Lab02
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // inheritance
            // Классы – фигура, прямоугольник, элемент управления (интерфейс с
            // методами show, input) Ctextbox(бесп)
            Console.WriteLine("sealed text box");
            CTextBox box = new CTextBox("new text");
            Console.WriteLine(box.Text);
            Console.WriteLine();
            Console.WriteLine("Shape");
            Shape sh = new Shape(3, 10);
            Console.WriteLine($"Side = {sh.LengthsSides}\nPerimetr = {sh.Perimetr}");
            Console.WriteLine();
            Rectangle rc = new Rectangle(6);
            Console.WriteLine($"Rectangle\nSide = {rc.LengthsSides}\nPerimetr = {rc.Perimetr}");
            Console.WriteLine();
            IControl[] arrShapes = new IControl[5] { rc,  sh, new Rectangle(22), new Shape(5,5), new Shape(3,3) }; 
            foreach (var item in arrShapes)
            {
                item.Show();
            }
            foreach (var item in arrShapes)
            {
                if (item is Rectangle)
                {
                    Rectangle temp = (Rectangle)item;
                    temp--;

                }
            }
            Console.WriteLine();
            foreach (var item in arrShapes)
            {
                item.Show();
            }
            Console.WriteLine();
            Console.WriteLine($"Compare:\n{arrShapes[0]} and {arrShapes[2]}");
            Console.WriteLine($"1 == 2: {(Rectangle)arrShapes[0] == (Rectangle)arrShapes[2]}");
            Console.WriteLine($"1 != 2: {(Rectangle)arrShapes[0] != (Rectangle)arrShapes[2]}");
            Console.WriteLine($"1 < 2: {(Rectangle)arrShapes[0] < (Rectangle)arrShapes[2]}");
            Console.WriteLine($"1 > 2: {(Rectangle)arrShapes[0] > (Rectangle)arrShapes[2]}");
            Console.WriteLine();

            Header h1 = Header.getInstance();
            Header h2 = Header.getInstance();
            Console.WriteLine(h1 == h2);
            Console.WriteLine($"Writing to file");
            Shape ss = new Rectangle(44);
            ss.WriteToFile();
            //sh.WriteToFile();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TEST MEMENTO");
            HistorySaves history = new HistorySaves();
            Hero mainHero = new Hero();
            Console.WriteLine(mainHero.ToString());
            mainHero.BuyArmor("knife");
            mainHero.Attack();
            Console.WriteLine(mainHero.ToString());
            history.History.Push(mainHero.SaveState());
            mainHero.Attack(); mainHero.Attack(); mainHero.Attack(); mainHero.Attack(); mainHero.Attack();
            Console.WriteLine(mainHero.ToString());
            mainHero.RestoreState(history.History.Pop());
            Console.WriteLine(mainHero.ToString());

        }
    }
}
