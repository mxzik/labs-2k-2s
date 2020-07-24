using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace _7_8.entity
{
    static class Manager
    {
        
        public static BindingList<MyTask> tasktoday = new BindingList<MyTask>();
        public static BindingList<MyTask> taskFind = new BindingList<MyTask>();
        public static BindingList<MyTask> tasks = new BindingList<MyTask>();
        public static List<List<MyTask>> undoredo = new List<List<MyTask>>();
        
        static Manager()
        {
            List<MyTask> temp = new List<MyTask>(tasks);
            undoredo.Add(temp);
        }


        public static int index = 0;

        public static void Undo()
        {
            if (index > 0)
            {
                tasks = new BindingList<MyTask>(undoredo[--index]);
                
            }
            
        }
        public static void Redo()
        {
            if (index < undoredo.Count-1)
            {
                tasks = new BindingList<MyTask>(undoredo[++index]);
            }            
        }
        public static void Add(MyTask task)
        {
            tasks.Add(task);
            List<MyTask> temp = new List<MyTask>(tasks);
            undoredo.Add(temp);
            index++;
        }

        public static void Remove(MyTask task)
        {
            tasks.Remove(task);
            List<MyTask> temp = new List<MyTask>(tasks);
            undoredo.Add(temp);
            index++;
        }

        public static void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<MyTask>));
            using (FileStream fs = new FileStream("serialize.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, tasks);
            }
        }
        public static void DeSerialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<MyTask>));

            if (File.Exists("serialize.xml"))
            {
                using (FileStream fs = new FileStream("serialize.xml", FileMode.OpenOrCreate))
                {
                    tasks = (BindingList<MyTask>)deserializer.Deserialize(fs);
                }
            }
        }
    }
}

