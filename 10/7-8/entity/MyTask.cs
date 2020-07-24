using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8.entity
{
    [Serializable]
    public class MyTask
    {
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public Period period { get; set; }
        public Priority priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Category category { get; set; }
        public Status status { get; set; }

        

        public MyTask() { }

        public MyTask(DateTime startTime, DateTime endTime, Period period, Priority priority, string name, string description, Category category, Status status)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.period = period;
            this.priority = priority;
            this.name = name;
            this.description = description;
            this.category = category;
            this.status = status;
        }
    }
}
