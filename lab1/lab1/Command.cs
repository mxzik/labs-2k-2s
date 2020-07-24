using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Car1
    {
        public int speed = 110;
        public void RaiseSpeed()
        {
            if (speed < 210)
            {
                speed += 10;
                Console.WriteLine("Увеличиваем скорость, текущая скорось {0} км/ч", speed);
            }
            else
                Console.WriteLine("Достигнута максимальная скорость");
        }
        public CarMem SaveState()
        {
            Console.WriteLine("Сохранение скорости. Cкорость = {0} км/ч", speed);
            return new CarMem(speed);
        }

        // восстановление состояния
        public void RestoreState(CarMem memento)
        {
            this.speed = memento.Speed;
            Console.WriteLine("Восстановление скорости. Скорость = {0} км/ч", speed);
        }
        public void On()
        {
            Console.WriteLine("Машина заведена");
        }

        public void Off()
        {
            Console.WriteLine("Машина заглушена");
        }
    }
    class CarMem
    {
        public int Speed { get; private set; }

        public CarMem(int speed)
        {
            this.Speed = speed;
        }
    }
    class SpeedHistory
    {
        public Stack<CarMem> History { get; private set; }
        public SpeedHistory()
        {
            History = new Stack<CarMem>();
        }
    }
    class Car2
    {
        protected int passengers; 
        protected string model; 

        public Car2(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
    class CarComm : ICommand
    {
        Car1 car;
        public CarComm(Car1 Caropt)
        {
            car = Caropt;
        }
        public void Execute()
        {
            car.On();
        }
        public void Undo()
        {
            car.Off();
        }
    }

    class Key
    {
        ICommand command;

        public Key() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void TurnKey()
        {
            command.Execute();
        }
        public void TakeOffKey()
        {
            command.Undo();
        }
    }
}
