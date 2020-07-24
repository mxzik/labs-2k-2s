using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //IFactory factory = new Rich_car();
            //var speed = factory.Createspeed();
            //var color = factory.CreateCars();
            //Console.WriteLine("Rich_car - Vw, characteristics:");
            //color.Get_color();
            //speed.Speed();
            //IFactory factory1 = new Poor_car();
            //var speed1 = factory1.Createspeed();
            //var color1 = factory1.CreateCars();
            //color1.Get_color();
            //speed1.Speed();
            //Console.WriteLine("Rich_car - Vw, characteristics:");
            //color.Get_color();
            //Police police = new Police();
            //police.GetInfo();

            //var carsbuild = new CarsBuilder();
            //var pageDirector = new CarDirectory(carsbuild);
            //Console.WriteLine("New car: Porshe");
            //var newcar = pageDirector.BuildPage(370, "Green");

            //IFigure cars = new Cars(30, "red");
            //IFigure clonedFigure = cars.Clone();
            //cars.GetInfo();

            //clonedFigure.GetInfo();



            //Painter painter = new Painter();

            //VW auto = new VW();

            //painter.Paint(auto);

            //Good_car goodcar = new Good_car();

            //Icar car = new GoodcarToColor(goodcar);

            //painter.Paint(car);

            //Car car1 = new ItalianCar();
            //car1 = new Dveribabochkoi(car1);
            //Console.WriteLine("Название: {0}", car1.Name);
            //Console.WriteLine("Цена: {0}", car1.GetCost());

            //Car car2 = new ItalianCar();
            //car2 = new Spoiler(car2);
            //Console.WriteLine("Название: {0}", car2.Name);
            //Console.WriteLine("Цена: {0}", car2.GetCost());

            //Car car3 = new RussinCar();
            //car3 = new Dveribabochkoi(car3);
            //car3 = new Spoiler(car3);
            //Console.WriteLine("Название: {0}", car3.Name);
            //Console.WriteLine("Цена: {0}", car3.GetCost());

            //Console.WriteLine("========================================");

            //Component fileSystem = new Directory("Файловая система");
            //Component diskC = new Directory("Диск С");
            //Component pngFile = new File("12345.png");
            //Component docxFile = new File("Document.docx");
            //diskC.Add(pngFile);
            //diskC.Add(docxFile);
            //fileSystem.Add(diskC);
            //fileSystem.Print();
            //Console.WriteLine("========================================");
            //diskC.Remove(pngFile);
            //Component docsFolder = new Directory("Мои Документы");
            //Component txtFile = new File("readme.txt");
            //Component csFile = new File("Program.cs");
            //docsFolder.Add(txtFile);
            //docsFolder.Add(csFile);
            //diskC.Add(docsFolder);
            //diskC.Search(docxFile);
            //fileSystem.Print();
            Key key = new Key();
            Car1 car1 = new Car1();
            key.SetCommand(new CarComm(car1));
            key.TurnKey();
            key.TakeOffKey();
            Console.WriteLine("====================================");
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            Console.WriteLine("====================================");
            Car1 car2 = new Car1();
            car2.RaiseSpeed(); 
            SpeedHistory speed = new SpeedHistory();

            speed.History.Push(car2.SaveState()); 

            car2.RaiseSpeed();

            car2.RestoreState(speed.History.Pop());

            car2.RaiseSpeed();
            car2.RaiseSpeed();
            Console.WriteLine("====================================");
            Car2 auto = new Car2(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
            Console.WriteLine("====================================");
            //Stock stock = new Stock();
            //Bank bank = new Bank("ЮнитБанк", stock);
            //Broker broker = new Broker("Иван Иваныч", stock);
            //stock.Market();
            //broker.StopTrade();
            //stock.Market();
        }
    }
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Cars : IFigure
    {
        int Speed;
        string Color;
        public Cars(int s, string c)
        {
            Speed = s;
            Color = c;
        }

        public IFigure Clone()
        {
            return new Cars(this.Speed, this.Color);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Car with max speed {Speed} and color {Color}");
        }
    }
    public interface Icar
    {
        void Get_color();
    }
    public interface ISpeed
    {
        void Speed();
    }
    public class VW : Icar
    {
        public void Get_color() => Console.WriteLine("Цвет машины - черный");
    }
    public class Painter
    {
        public void Paint(Icar car)
        {
            car.Get_color();
        }
    }
    public class Good_car : ISpeed
    {
        public void Speed() => Console.WriteLine("Max speed - 250");
    }
    public class Bad_car : ISpeed
    {
        public void Speed() => Console.WriteLine("Max speed - 150");
    }
    public class GoodcarToColor : Icar
    {
        Good_car good_car;
        public GoodcarToColor(Good_car a)
        {
            good_car = a;
        }

        public void Get_color()
        {
            good_car.Speed();
        }
    }

    //public class Lada : Icar
    //{
    //    public void Get_color() => Console.WriteLine("Цвет машины - белый");
    //}
    //public interface IFactory
    //{
    //    ISpeed Createspeed();
    //    Icar CreateCars();
    //}
    //public class Rich_car : IFactory
    //{
    //    public ISpeed Createspeed()
    //    {
    //        return new Good_car();
    //    }
    //    public Icar CreateCars()
    //    {
    //        return new VW();
    //    }
    //}
    //public class Poor_car : IFactory
    //{
    //    public ISpeed Createspeed()
    //    {
    //        return new Bad_car();
    //    }
    //    public Icar CreateCars()
    //    {
    //        return new Lada();
    //    }
    //}
    //public interface IBuilder
    //{
    //    void EngineBuild(string speed);
    //    void ColorBuild(string color);
    //    string GetResult();

    //}
    //public class CarsBuilder : IBuilder
    //{
    //    private string Car = string.Empty;

    //    void IBuilder.ColorBuild(string color)
    //    {
    //        Console.WriteLine(color);
    //    }
    //    void IBuilder.EngineBuild(string speed)
    //    {
    //        Console.WriteLine(speed);
    //    }
    //    string IBuilder.GetResult()
    //    {
    //        return Car;
    //    }
    //}
    //public class CarDirectory
    //{
    //    private readonly IBuilder _builder;
    //    public CarDirectory(IBuilder builder)
    //    { _builder = builder; }
    //    public string BuildPage(int speed, string Color)
    //    {
    //        _builder.EngineBuild(Getengine(speed));
    //        _builder.ColorBuild(GetColor(Color));
    //        return _builder.GetResult();
    //    }

    //    private string Getengine(int speed)
    //    {
    //        return "Speed " + speed;
    //    }
    //    private string GetColor(string Color)
    //    {
    //        return "Color: " + Color;
    //    }

    //}
    //public sealed class Police
    //{
    //    public static Police instance;

    //    public string Color { get; }
    //    public int max_speed { get; }
    //    public Police()
    //    {
    //        this.Color = "Special";
    //        this.max_speed = 280;
    //    }

    //    public static Police getInstance()
    //    {
    //        if (instance == null)
    //            instance = new Police();
    //        return instance;
    //    }
    //    public void GetInfo()
    //    {
    //        Console.WriteLine("Its a police track");
    //        Console.WriteLine($"Color: {Color}, max_speed - {max_speed}");
    //    }
    //}
}
