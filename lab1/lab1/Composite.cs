using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Search(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
    class Directory : Component
    {
        private List<Component> components = new List<Component>();

        public Directory(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Search(Component component)
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i] == component)
                    Console.WriteLine("Компонент найден");
            }
        }

        public override void Print()
        {
            Console.WriteLine("Узел " + name);
            Console.WriteLine("Подузлы:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }

    class File : Component
    {
        public File(string name)
                : base(name)
        { }
    }
}
