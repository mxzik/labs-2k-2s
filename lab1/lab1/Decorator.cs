using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Car
    {
        public Car(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class ItalianCar : Car
    {
        public ItalianCar() : base("Итальянская Машина")
        { }
        public override int GetCost()
        {
            return 20;
        }
    }
    class RussinCar : Car
    {
        public RussinCar()
            : base("Русская машина")
        { }
        public override int GetCost()
        {
            return 5;
        }
    }

    abstract class CarDecorator : Car
    {
        protected Car car;
        public CarDecorator(string n, Car car) : base(n)
        {
            this.car = car;
        }
    }

    class Dveribabochkoi : CarDecorator
    {
        public Dveribabochkoi(Car p)
            : base(p.Name + ", двери поднимаются вверх", p)
        { }

        public override int GetCost()
        {
            return car.GetCost() + 10;
        }
    }

    class Spoiler : CarDecorator
    {
        public Spoiler(Car p)
            : base(p.Name + ", спойлер", p)
        { }

        public override int GetCost()
        {
            return car.GetCost() + 2;
        }
    }
}
